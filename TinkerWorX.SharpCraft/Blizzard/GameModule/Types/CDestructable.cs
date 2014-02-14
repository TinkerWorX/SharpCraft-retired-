using System;
using System.Runtime.InteropServices;
using TinkerWorX.Utilities;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0x88)]
    unsafe public struct CDestructable
    {
        public static CDestructable* FromHandle(IntPtr destructableJassHandle)
        {
            return GameFunctions.GetDestructableFromHandle(destructableJassHandle).AsUnsafe();
        }



        public CDestructableVTable* Virtual;
        public IntPtr field0004;
        public IntPtr field0008;
        public IntPtr field000C;
        public IntPtr field0010;
        public IntPtr field0014;
        public IntPtr field0018;
        public IntPtr field001C;
        public IntPtr field0020;
        public IntPtr field0024;
        public IntPtr field0028;
        public IntPtr field002C;
        public IntPtr field0030;
        public IntPtr field0034;
        public IntPtr field0038;
        public IntPtr field003C;
        public IntPtr field0040;
        public IntPtr field0044;
        public IntPtr field0048;
        public IntPtr field004C;
        public IntPtr field0050;
        public IntPtr field0054;
        public IntPtr field0058;
        public IntPtr field005C;
        public IntPtr field0060;
        public IntPtr field0064;
        public IntPtr field0068;
        public IntPtr field006C;
        public IntPtr field0070;
        public IntPtr field0074;
        public IntPtr field0078;
        public IntPtr field007C;
        public IntPtr field0080;
        public IntPtr field0084;

        public CDestructablePtr AsSafe()
        {
            fixed (CDestructable* pointer = &this)
                return new CDestructablePtr(pointer);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CDestructablePtr
    {
        public static CDestructablePtr FromHandle(IntPtr destructableJassHandle)
        {
            return GameFunctions.GetDestructableFromHandle(destructableJassHandle);
        }



        private IntPtr pointer;

        unsafe public CDestructablePtr(CDestructable* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public CDestructablePtr(IntPtr pointer)
        {
            this.pointer = pointer;
        }

        unsafe public CDestructable* AsUnsafe()
        {
            return (CDestructable*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }

    unsafe public struct CDestructableVTable
    {
        public IntPtr* Functions;
    }
}
