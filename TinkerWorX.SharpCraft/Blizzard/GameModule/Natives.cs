using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using EasyHook;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.Utilities;
using TinkerWorX.Windows;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    internal static partial class Natives
    {
        private static GameFunctions.InitNativesPrototype InitNatives;

        private static List<NativeDeclaration> vanillaNatives = new List<NativeDeclaration>();

        private static List<NativeDeclaration> customNatives = new List<NativeDeclaration>();

        //private static Dictionary<Type, Object> buckets = new Dictionary<Type, Object>();

        public static void Initialize()
        {
            if (Kernel32.GetModuleHandle("game.dll") == IntPtr.Zero)
                throw new Exception("Attempted to initialize " + typeof(Natives).Name + " before 'game.dll' has been loaded.");

            if (!GameAddresses.IsReady)
                throw new Exception("Attempted to initialize " + typeof(Natives).Name + " before " + typeof(GameAddresses).Name + " was ready.");

            var address = IntPtr.Zero;

            address = GameAddresses.InitNatives;
            Trace.Write("InitNatives: 0x" + address.ToString("X8") + " . ");
            Natives.InitNatives = Memory.InstallHook(address, new GameFunctions.InitNativesPrototype(Natives.InitNativesHook), true, false);
            Trace.WriteLine("hook installed!");

            Trace.Write("Scanning vanilla natives . ");
            address = GameAddresses.InitNatives;
            var offset = 0x05;
            while (Memory.Read<Byte>(address + offset) == 0x68)
            {
                Natives.vanillaNatives.Add(new NativeDeclaration(address + offset));
                offset += 0x14;
            }
            Natives.GetVanillaNatives();
            Trace.WriteLine("found " + Natives.vanillaNatives.Count + "!");
        }

        private static Int32 InitNativesHook()
        {
            var result = Natives.InitNatives();

            foreach (var native in Natives.customNatives)
            {
                GameFunctions.BindNative(native.Function, native.Name, native.Prototype);
            }

            return result;
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
            Natives.customNatives.Add(native);
        }

        public static void Add(Delegate function, String name, String prototype)
        {
            Natives.Add(new NativeDeclaration(function, name, prototype));
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
            Natives.Add(function, function.Method.Name);
        }

        public static NativeDeclaration Get(String name)
        {
            return Natives.vanillaNatives.FirstOrDefault(native => native.Name == name);
        }
    }
}
