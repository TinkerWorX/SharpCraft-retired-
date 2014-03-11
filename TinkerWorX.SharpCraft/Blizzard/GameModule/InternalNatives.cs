using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows;
using EasyHook;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Blizzard.Types;
using TinkerWorX.Utilities;
using TinkerWorX.Windows;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    internal static partial class InternalNatives
    {
        private static GameFunctions.InitNativesPrototype InitNatives;

        private static GameFunctions.JassStringHandleToStringPrototype JassStringHandleToString;

        private static GameFunctions.CTriggerWar3__ExecutePrototype CTriggerWar3__Execute;

        private static List<NativeDeclaration> vanillaNatives = new List<NativeDeclaration>();

        private static List<NativeDeclaration> customNatives = new List<NativeDeclaration>();

        //private static Dictionary<Type, Object> buckets = new Dictionary<Type, Object>();

        private static Dictionary<CTriggerWar3Ptr, HashSet<ManagedActionBase>> actions = new Dictionary<CTriggerWar3Ptr, HashSet<ManagedActionBase>>();

        private static Dictionary<CTriggerWar3Ptr, JassTrigger> handles = new Dictionary<CTriggerWar3Ptr, JassTrigger>();

        public static void Initialize()
        {
            if (Kernel32.GetModuleHandle("game.dll") == IntPtr.Zero)
                throw new Exception("Attempted to initialize " + typeof(InternalNatives).Name + " before 'game.dll' has been loaded.");

            if (!GameAddresses.IsReady)
                throw new Exception("Attempted to initialize " + typeof(InternalNatives).Name + " before " + typeof(GameAddresses).Name + " was ready.");

            var address = IntPtr.Zero;

            address = GameAddresses.InitNatives;
            Trace.Write("InitNatives: 0x" + address.ToString("X8") + " . ");
            InternalNatives.InitNatives = Memory.InstallHook(address, new GameFunctions.InitNativesPrototype(InternalNatives.InitNativesHook), true, false);
            Trace.WriteLine("hook installed!");

            address = GameAddresses.JassStringHandleToString;
            Trace.Write("JassStringHandleToString: 0x" + address.ToString("X8") + " . ");
            InternalNatives.JassStringHandleToString = Memory.InstallHook(address, new GameFunctions.JassStringHandleToStringPrototype(InternalNatives.JassStringHandleToStringHook), true, false);
            Trace.WriteLine("hook installed!");

            address = GameAddresses.CTriggerWar3__Execute;
            Trace.Write("CTriggerWar3__Execute: 0x" + address.ToString("X8") + " . ");
            InternalNatives.CTriggerWar3__Execute = Memory.InstallHook(address, new GameFunctions.CTriggerWar3__ExecutePrototype(InternalNatives.CTriggerWar3__ExecuteHook), true, false);
            Trace.WriteLine("hook installed!");

            Trace.Write("Scanning vanilla natives . ");
            address = GameAddresses.InitNatives;
            var offset = 0x05;
            while (Memory.Read<Byte>(address + offset) == 0x68)
            {
                InternalNatives.vanillaNatives.Add(new NativeDeclaration(address + offset));
                offset += 0x14;
            }
            InternalNatives.GetVanillaNatives();
            Trace.WriteLine("found " + InternalNatives.vanillaNatives.Count + "!");
        }

        private static Int32 InitNativesHook()
        {
            var result = InternalNatives.InitNatives();

            foreach (var native in InternalNatives.customNatives)
            {
                GameFunctions.BindNative(native.Function, native.Name, native.Prototype);
            }

            return result;
        }

        private static IntPtr JassStringHandleToStringHook(IntPtr stringJassHandle)
        {
            //.rdata:6F96B6C0                 dd offset aButton_0     ; "BUTTON"
            //.rdata:6F96B6C4                 dd offset sub_6F5E9400
            // Open the sub on the second line.
            //.text:6F5E9450                 push    3
            //.text:6F5E9452                 mov     ecx, esi
            //.text:6F5E9454                 call    sub_6F5E15A0
            // Find the code above and open the sub.
            //.text:6F5E15F5                 lea     ebx, [esi+128h]
            //.text:6F5E15FB                 push    edi
            //.text:6F5E15FC                 mov     ecx, ebx
            //.text:6F5E15FE                 mov     byte ptr [esp+28h+var_4], 1
            //.text:6F5E1603                 call    sub_6F011300
            //.text:6F5E1608                 mov     dword ptr [ebx], offset off_6F969F5C
            //.text:6F5E160E                 lea     ebx, [esi+134h]
            //.text:6F5E1614                 push    edi
            //.text:6F5E1615                 mov     ecx, ebx
            //.text:6F5E1617                 mov     byte ptr [esp+28h+var_4], 2
            //.text:6F5E161C                 call    sub_6F011300
            //.text:6F5E1621                 mov     dword ptr [ebx], offset off_6F969F5C
            // Code like the above repeats several times, where off_6F969F5C is used seven times. This is the first vtable. Rebase it and we get 969F5C.

            // xref ".?AUJassString@@" and find the function where it's used three times.
            //.text:6F44C678                 add     ebx, edi
            //.text:6F44C67A                 mov     [esi+4], eax
            //.text:6F44C67D                 mov     dword ptr [esi], offset off_6F87688C
            //.text:6F44C683                 mov     [esi+8], eax
            // Find code that looks like the stuff above. It's between the second and third use of the string.
            // This is the vtable we'er looking for.
            if (Memory.Read<IntPtr>(stringJassHandle) == Kernel32.GetModuleHandle("game.dll") + 0x87688C ||
                Memory.Read<IntPtr>(stringJassHandle) == Kernel32.GetModuleHandle("game.dll") + 0x969F5C)
            {
                // The two checks above are vtables for the two only know string handles.
                return JassStringHandleToString(stringJassHandle);
            }
            // Anything but the two types above must be strings that doesn't need to be converted.
            return stringJassHandle;
        }

        private static void CTriggerWar3__ExecuteHook(CTriggerWar3Ptr @this, Boolean wait)
        {
            try
            {
                InternalNatives.CTriggerWar3__Execute(@this, wait);
                InternalNatives.TriggerRunActions(@this);
            }
            catch (Exception e)
            {
                Trace.WriteLine("CTriggerWar3__ExecuteHook");
                Trace.WriteLine(e.ToString());
            }
        }

        // private ... AddCallback(...) 

        //private static void AddCallback<T>(T callback)
        //    where T : class, new()
        //{
        //    var boxedBucket = (Object)null;
        //    var bucket = (HashSet<T>)null;
        //    if (!buckets.TryGetValue(typeof(T), out boxedBucket))
        //    {
        //        // install bucket + hook
        //        bucket = new HashSet<T>();
        //        buckets[typeof(T)] = bucket;

        //        // create the method.
        //        var callbackDelegate = (callback as Delegate);

        //        var traceWriteLineArgs = new[] { typeof(String) };
        //        var traceWriteLineFunc = typeof(Trace).GetMethod("WriteLine", traceWriteLineArgs);

        //        var method = new DynamicMethod(String.Empty, callbackDelegate.Method.ReturnType,
        //            callbackDelegate.Method.GetParameters().Select(t => t.ParameterType).ToArray());

        //        var il = method.GetILGenerator();
        //        var i = 0;
        //        foreach (var type in callbackDelegate.Method.GetParameters())
        //        {
        //            il.Emit(OpCodes.Ldarg_S, i);
        //            i += 1;
        //        }

        //    }
        //    else
        //    {
        //        // fetch bucket
        //        bucket = (HashSet<T>)boxedBucket;
        //    }
        //    // add to bucket
        //}

        private static void Add(NativeDeclaration native)
        {
            InternalNatives.customNatives.Add(native);
        }

        public static void Add(Delegate function, String name, String prototype)
        {
            InternalNatives.Add(new NativeDeclaration(function, name, prototype));
        }

        public static void Add(Delegate function, String name)
        {
            JassTypeAttribute attribute;

            var prototype = "(";
            foreach (var parameter in function.Method.GetParameters())
            {
                attribute = (JassTypeAttribute)parameter.ParameterType.GetCustomAttributes(typeof(JassTypeAttribute), true).Single();
                prototype += attribute.TypeString;
            }
            prototype += ")";

            if (function.Method.ReturnType == typeof(void))
            {
                prototype += "V";
            }
            else
            {
                attribute = (JassTypeAttribute)function.Method.ReturnType.GetCustomAttributes(typeof(JassTypeAttribute), true).Single();
                prototype += attribute.TypeString;
            }

            Add(function, name, prototype);
        }

        public static void Add(Delegate function)
        {
            InternalNatives.Add(function, function.Method.Name);
        }

        public static NativeDeclaration Get(String name)
        {
            return InternalNatives.vanillaNatives.FirstOrDefault(native => native.Name == name);
        }

        public static void TriggerAddAction(JassTrigger trigger, ManagedActionBase action)
        {
            try
            {
                var key = trigger.ToCTrigger();
                InternalNatives.handles[key] = trigger;
                HashSet<ManagedActionBase> bucket;
                if (!InternalNatives.actions.TryGetValue(key, out bucket))
                    InternalNatives.actions.Add(key, bucket = new HashSet<ManagedActionBase>());
                bucket.Add(action);
            }
            catch (Exception e)
            {
                Trace.WriteLine("TriggerAddAction");
                Trace.WriteLine(e.ToString());
            }
        }

        public static void TriggerRunActions(CTriggerWar3Ptr key)
        {
            try
            {
                HashSet<ManagedActionBase> bucket;
                if (InternalNatives.actions.TryGetValue(key, out bucket))
                {
                    foreach (var action in bucket)
                    {
                        action.Invoke(InternalNatives.handles[key]);
                    }
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("TriggerRunActions");
                Trace.WriteLine(e.ToString());
            }
        }
    }
}
