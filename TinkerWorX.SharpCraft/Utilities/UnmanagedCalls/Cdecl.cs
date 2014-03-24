using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Utilities.UnmanagedCalls
{
    public static class Cdecl
    {
        private static Dictionary<IntPtr, DynamicMethod> methods = new Dictionary<IntPtr, DynamicMethod>();

        public static TReturned Invoke<TReturned>(IntPtr address, params Object[] parameters) where TReturned : struct
        {
            DynamicMethod method;

            if (!methods.TryGetValue(address, out method))
            {
                var returnType = typeof(TReturned);
                var paramTypes = parameters.Select(o => o.GetType()).ToArray();

                method = new DynamicMethod("Cdecl_Invoke_" + address.ToString("X8"), returnType, paramTypes, typeof(Cdecl).Module);
                var il = method.GetILGenerator();
                for (var i = 0; i < parameters.Length; i += 1)
                {
                    il.Emit(OpCodes.Ldarg, i);
                }
                il.Emit(OpCodes.Ldc_I4, (Int32)address);
                il.Emit(OpCodes.Conv_I);
                il.EmitCalli(OpCodes.Calli, CallingConvention.Cdecl, returnType, paramTypes);
                il.Emit(OpCodes.Ret);

                methods.Add(address, method);
            }

            return (TReturned)method.Invoke(null, parameters);
        }
    }
}
