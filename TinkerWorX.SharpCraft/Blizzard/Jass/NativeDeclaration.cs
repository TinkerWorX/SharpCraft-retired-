using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TinkerWorX.Utilities;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    internal class NativeDeclaration
    {
        private readonly IntPtr FunctionPtr;

        public readonly Delegate Function;

        public readonly String Name;

        public readonly String Prototype;

        public NativeDeclaration(IntPtr address)
        {
            this.Prototype = Memory.ReadString(Memory.Read<IntPtr>(address, 0x01));
            this.Name = Memory.ReadString(Memory.Read<IntPtr>(address, 0x06));
            this.FunctionPtr = Memory.Read<IntPtr>(address, 0x0B);
        }

        public NativeDeclaration(IntPtr function, String name, String prototype)
        {
            this.FunctionPtr = function;
            this.Name = name;
            this.Prototype = prototype;
        }

        public NativeDeclaration(Delegate function, String name, String prototype)
        {
            this.Function = function;
            this.FunctionPtr = Utility.FunctionAsPtr(function);
            this.Name = name;
            this.Prototype = prototype;
        }

        public T ToDelegate<T>() where T : class
        {
            return Utility.PtrAsFunction<T>(this.FunctionPtr);
        }
    }
}
