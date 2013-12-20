using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential, Size = 0xC)]
    unsafe public struct StringPool
    {
        public IntPtr field0000;
        public IntPtr field0004;
        public StringNode** Nodes;

        public StringPoolPtr AsSafe()
        {
            fixed (StringPool* pointer = &this)
                return new StringPoolPtr(pointer);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct StringPoolPtr
    {
        private IntPtr pointer;

        unsafe public StringPoolPtr(StringPool* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public StringPool* AsUnsafe()
        {
            return (StringPool*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }
}
