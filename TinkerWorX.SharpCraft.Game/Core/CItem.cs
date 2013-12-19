using System;
using System.Runtime.InteropServices;
using TinkerWorX.SharpCraft.Game.Jass;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential, Size = 0xF8)]
    unsafe public struct CItem
    {
        public IntPtr VTable;
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
                return new CItemPtr(new IntPtr(pointer));
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CItemPtr
    {
        // The first function in GetItemX, GetItemY.
        // int __fastcall sub_6F3BEB50(int a1)
        // We use __thiscall as a cheat for doing a fastcall with only one argument.
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        [return: MarshalAs(UnmanagedType.LPStruct)]
        private delegate CItemPtr sub_6F3BEB50Prototype(JassItem item);

        private static sub_6F3BEB50Prototype sub_6F3BEB50 = (sub_6F3BEB50Prototype)Marshal.GetDelegateForFunctionPointer(WarcraftIII.Module + 0x3BEB50, typeof(sub_6F3BEB50Prototype));

        public static CItemPtr FromHandle(JassItem item)
        {
            return sub_6F3BEB50(item);
        }



        private IntPtr pointer;

        public CItemPtr(IntPtr pointer)
        {
            this.pointer = pointer;
        }

        unsafe public CItem* AsUnsafe()
        {
            return (CItem*)this.pointer;
        }
    }
}
