using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Utilities
{
    public static class Utility
    {
        public static T PtrAsFunction<T>(IntPtr address) where T : class
        {
            if (typeof(Delegate).IsAssignableFrom(typeof(T)))
                return (T)(Object)Marshal.GetDelegateForFunctionPointer(address, typeof(T));
            throw new InvalidOperationException("Generic T is not a delegate type");
        }

        public static T PtrAsFunction<T>(IntPtr address, Int32 offset) where T : class
        {
            return Utility.PtrAsFunction<T>(address + offset);
        }

        public static IntPtr FunctionAsPtr(Delegate function)
        {
            return Marshal.GetFunctionPointerForDelegate(function);
        }
    }
}
