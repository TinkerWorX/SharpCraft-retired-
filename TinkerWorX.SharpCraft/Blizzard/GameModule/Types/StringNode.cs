using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.Utilities;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0x18)]
    unsafe public struct StringNode
    {
        public IntPtr field0000;
        public IntPtr field0004;
        public IntPtr field0008;
        public IntPtr field0010;
        public IntPtr field0014;
        public IntPtr ValuePtr;

        public String Value { get { return Memory.ReadString(this.ValuePtr); } }

        public StringNodePtr AsSafe()
        {
            fixed (StringNode* pointer = &this)
                return new StringNodePtr(pointer);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct StringNodePtr
    {
        private IntPtr pointer;

        unsafe public StringNodePtr(StringNode* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public StringNode* AsUnsafe()
        {
            return (StringNode*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }
}
