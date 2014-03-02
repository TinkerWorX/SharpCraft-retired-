using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
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

        private static GameFunctions.CTriggerWar3__ExecutePrototype CTriggerWar3__Execute;

        private static List<NativeDeclaration> vanillaNatives = new List<NativeDeclaration>();

        private static List<NativeDeclaration> customNatives = new List<NativeDeclaration>();

        //private static Dictionary<Type, Object> buckets = new Dictionary<Type, Object>();

        private static Dictionary<CTriggerWar3Ptr, HashSet<ManagedAction>> actions = new Dictionary<CTriggerWar3Ptr, HashSet<ManagedAction>>();

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

        private static void CTriggerWar3__ExecuteHook(CTriggerWar3Ptr @this, Boolean wait)
        {
            GameFunctions.CTriggerWar3__Execute(@this, wait);
            InternalNatives.TriggerRunActions(@this);
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

        public static void TriggerAddAction(JassTrigger trigger, ManagedAction action)
        {
            var key = trigger.ToCTrigger();
            InternalNatives.handles[key] = trigger;
            HashSet<ManagedAction> bucket;
            if (!InternalNatives.actions.TryGetValue(key, out bucket))
                InternalNatives.actions.Add(key, bucket = new HashSet<ManagedAction>());
            bucket.Add(action);
        }

        public static void TriggerRunActions(CTriggerWar3Ptr key)
        {
            HashSet<ManagedAction> bucket;
            if (InternalNatives.actions.TryGetValue(key, out bucket))
                foreach (var action in bucket)
                    action.Invoke(InternalNatives.handles[key]);
        }
    }
}
