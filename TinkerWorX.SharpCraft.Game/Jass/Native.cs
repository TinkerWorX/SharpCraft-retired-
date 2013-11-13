using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    public class Native
    {
        internal static readonly List<Native> AllNatives = new List<Native>();

        internal static Native FromString(String nativeName)
        {
            return Native.AllNatives.First(native => native.Name == nativeName);
        }

        internal readonly Delegate Function;

        internal readonly IntPtr FunctionPtr;

        internal readonly String Name;

        internal readonly String Prototype;

        internal Native(IntPtr address)
        {
            this.Prototype = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(address, 0x01));
            this.Name = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(address, 0x06));
            this.FunctionPtr = Marshal.ReadIntPtr(address, 0x0B);
        }

        internal Native(IntPtr function, String name, String prototype)
        {
            this.FunctionPtr = function;
            this.Name = name;
            this.Prototype = prototype;
        }

        internal Native(Delegate function, String name, String prototype)
        {
            this.Function = function;
            this.FunctionPtr = Marshal.GetFunctionPointerForDelegate(function);
            this.Name = name;
            this.Prototype = prototype;
        }

        public T ToDelegate<T>()
        {
            return (T)(Object)Marshal.GetDelegateForFunctionPointer(this.FunctionPtr, typeof(T));
        }
    }
}
