using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential, Size = 0x28)]
    unsafe public struct Variable
    {
        public IntPtr field0000;
        public IntPtr field0004;
        public IntPtr field0008;
        public IntPtr field000C;
        public IntPtr field0010;
        public IntPtr field0014;
        public IntPtr field0018;
        public IntPtr field001C;
        public IntPtr field0020;
        public IntPtr field0024;

        public VariablePtr AsSafe()
        {
            fixed (Variable* pointer = &this)
                return new VariablePtr(pointer);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VariablePtr
    {
        private IntPtr pointer;

        unsafe public VariablePtr(Variable* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public Variable* AsUnsafe()
        {
            return (Variable*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }
}
