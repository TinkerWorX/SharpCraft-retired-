using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential, Size = 0x14)]
    unsafe public struct ClassPrototype
    {
        public Int32 ClassSize;
        public Int32 BatchSize;
        public Int32 ElementsCreatedCount;
        public IntPtr MemoryAreas;
        public IntPtr FirstFreeElement;

        public ClassPrototypePtr AsSafe()
        {
            fixed (ClassPrototype* pointer = &this)
                return new ClassPrototypePtr(new IntPtr(pointer));
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ClassPrototypePtr
    {
        private IntPtr pointer;

        public ClassPrototypePtr(IntPtr pointer)
        {
            this.pointer = pointer;
        }

        unsafe public ClassPrototype* AsUnsafe()
        {
            return (ClassPrototype*)this.pointer;
        }
    }
}
