using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.Utilities.UnmanagedCalls
{
    public static class FastCall
    {
        private static Byte[] InvokeFastCallCode = new Byte[]
            {
                0x5A,                           // pop edx
                0x36, 0x87, 0x54, 0x24, 0x08,   // xchg ss:[esp+08],edx
                0x58,                           // pop eax
                0x59,                           // pop ecx
                0xFF, 0xE0                      // jmp eax
            };

        private static GCHandle InvokeFastCallHandle;

        private static Dictionary<IntPtr, DynamicMethod> methods = new Dictionary<IntPtr, DynamicMethod>();

        static FastCall()
        {
            InvokeFastCallHandle = GCHandle.Alloc(InvokeFastCallCode, GCHandleType.Pinned);
            //Make the native method executable
            uint old;
            VirtualProtect(InvokeFastCallHandle.AddrOfPinnedObject(), (IntPtr)InvokeFastCallCode.Length, 0x40, out old);
        }

        public static TReturned Invoke<TReturned>(IntPtr address, params Object[] parameters) where TReturned : struct
        {
            parameters = PrependAddress(parameters, address);

            DynamicMethod method;

            if (!methods.TryGetValue(address, out method))
            {
                var returnType = typeof(TReturned);
                var paramTypes = parameters.Select(o => o.GetType()).ToArray();

                method = new DynamicMethod("FastCall_Invoke_" + address.ToString("X8"), returnType, paramTypes, typeof(FastCall).Module);
                var il = method.GetILGenerator();
                for (var i = 0; i < parameters.Length; i += 1)
                {
                    il.Emit(OpCodes.Ldarg, i);
                }
                il.Emit(OpCodes.Ldc_I4, (Int32)InvokeFastCallHandle.AddrOfPinnedObject());
                il.Emit(OpCodes.Conv_I);
                il.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, paramTypes);
                il.Emit(OpCodes.Ret);

                methods.Add(address, method);
            }

            return (TReturned)method.Invoke(null, parameters);
        }

        private static Object[] PrependAddress(Object[] input, IntPtr address)
        {
            var newArray = new Object[input.Length + 1];
            newArray[0] = address;
            Array.Copy(input, 0, newArray, 1, input.Length);
            return newArray;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool VirtualProtect(IntPtr address, IntPtr size, UInt32 protect, out UInt32 oldProtect);
    }
}
