using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0x04)]
    public struct ThreadLocalStorage
    {
        private readonly IntPtr Pointer;

        unsafe public ThreadLocalStorageInternal* Internal
        {
            get { return (ThreadLocalStorageInternal*)this.Pointer; }
        }

        public Jass Jass
        {
            get { unsafe { return this.Internal->Jass; } }
        }

        public IntPtr NetProviderLOOP
        {
            get { unsafe { return this.Internal->NetProviderLOOP; } }
        }
    }

    [StructLayout(LayoutKind.Sequential, Size = 0x50)]
    unsafe public struct ThreadLocalStorageInternal
    {
        public IntPtr field0000;
        public IntPtr field0004;
        public IntPtr field0008;
        public IntPtr field000C;

        public IntPtr field0010;
        public Jass Jass;
        public IntPtr field0018;
        public IntPtr field001C;

        public IntPtr field0020;
        public IntPtr field0024;
        public IntPtr field0028;
        public IntPtr field002C;

        public IntPtr field0030;
        public IntPtr field0034;
        public IntPtr NetProviderLOOP;
        public IntPtr field003C;

        public IntPtr field0040;
        public IntPtr field0044;
        public IntPtr field0048;
        public IntPtr field004C;
    }
}
