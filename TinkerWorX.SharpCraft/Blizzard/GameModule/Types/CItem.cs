using System;
using System.Runtime.InteropServices;
using TinkerWorX.Utilities;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0xF8)]
    unsafe public struct CItem
    {
        public static CItem* FromHandle(IntPtr itemJassHandle)
        {
            return GameFunctions.GetItemFromHandle(itemJassHandle).AsUnsafe();
        }



        public CItemVTable* Virtual;
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
        public IntPtr field0088;
        public IntPtr field008C;
        public IntPtr field0090;
        public IntPtr field0094;
        public IntPtr field0098;
        public IntPtr field009C;
        public IntPtr field00A0;
        public IntPtr field00A4;
        public IntPtr field00A8;
        public IntPtr field00AC;
        public IntPtr field00B0;
        public IntPtr field00B4;
        public IntPtr field00B8;
        public IntPtr field00BC;
        public IntPtr field00C0;
        public IntPtr field00C4;
        public IntPtr field00C8;
        public IntPtr field00CC;
        public IntPtr field00D0;
        public IntPtr field00D4;
        public IntPtr field00D8;
        public IntPtr field00DC;
        public IntPtr field00E0;
        public IntPtr field00E4;
        public IntPtr field00E8;
        public IntPtr field00EC;
        public IntPtr field00F0;
        public IntPtr field00F4;

        public CItemPtr AsSafe()
        {
            fixed (CItem* pointer = &this)
                return new CItemPtr(pointer);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CItemPtr
    {
        public static CItemPtr FromHandle(IntPtr itemJassHandle)
        {
            return GameFunctions.GetItemFromHandle(itemJassHandle);
        }



        private IntPtr pointer;

        unsafe public CItemPtr(CItem* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public CItem* AsUnsafe()
        {
            return (CItem*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }

    unsafe public struct CItemVTable
    {
        public IntPtr* Function;
    }
}
