using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0x29C)]
    unsafe public struct Jass
    {
        public IntPtr VTable;
        public IntPtr field0004;
        public IntPtr field0008;
        public VirtualMachine** VirtualMachine;
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
        public IntPtr field00F8;
        public IntPtr field00FC;
        public IntPtr field0100;
        public IntPtr field0104;
        public IntPtr field0108;
        public IntPtr field010C;
        public IntPtr field0110;
        public IntPtr field0114;
        public IntPtr field0118;
        public IntPtr field011C;
        public IntPtr field0120;
        public IntPtr field0124;
        public IntPtr field0128;
        public IntPtr field012C;
        public IntPtr field0130;
        public IntPtr field0134;
        public IntPtr field0138;
        public IntPtr field013C;
        public IntPtr field0140;
        public IntPtr field0144;
        public IntPtr field0148;
        public IntPtr field014C;
        public IntPtr field0150;
        public IntPtr field0154;
        public IntPtr field0158;
        public IntPtr field015C;
        public IntPtr field0160;
        public IntPtr field0164;
        public IntPtr field0168;
        public IntPtr field016C;
        public IntPtr field0170;
        public IntPtr field0174;
        public IntPtr field0178;
        public IntPtr field017C;
        public IntPtr field0180;
        public IntPtr field0184;
        public IntPtr field0188;
        public IntPtr field018C;
        public IntPtr field0190;
        public IntPtr field0194;
        public IntPtr field0198;
        public IntPtr field019C;
        public IntPtr field01A0;
        public IntPtr field01A4;
        public IntPtr field01A8;
        public IntPtr field01AC;
        public IntPtr field01B0;
        public IntPtr field01B4;
        public IntPtr field01B8;
        public IntPtr field01BC;
        public IntPtr field01C0;
        public IntPtr field01C4;
        public IntPtr field01C8;
        public IntPtr field01CC;
        public IntPtr field01D0;
        public IntPtr field01D4;
        public IntPtr field01D8;
        public IntPtr field01DC;
        public IntPtr field01E0;
        public IntPtr field01E4;
        public IntPtr field01E8;
        public IntPtr field01EC;
        public IntPtr field01F0;
        public IntPtr field01F4;
        public IntPtr field01F8;
        public IntPtr field01FC;
        public IntPtr field0200;
        public IntPtr field0204;
        public IntPtr field0208;
        public IntPtr field020C;
        public IntPtr field0210;
        public IntPtr field0214;
        public IntPtr field0218;
        public IntPtr field021C;
        public IntPtr field0220;
        public IntPtr field0224;
        public IntPtr field0228;
        public IntPtr field022C;
        public IntPtr field0230;
        public IntPtr field0234;
        public IntPtr field0238;
        public IntPtr field023C;
        public IntPtr field0240;
        public IntPtr field0244;
        public IntPtr field0248;
        public IntPtr field024C;
        public IntPtr field0250;
        public IntPtr field0254;
        public IntPtr field0258;
        public IntPtr field025C;
        public IntPtr field0260;
        public IntPtr field0264;
        public IntPtr field0268;
        public IntPtr field026C;
        public IntPtr field0270;
        public IntPtr field0274;
        public IntPtr field0278;
        public IntPtr field027C;
        public IntPtr field0280;
        public IntPtr field0284;
        public IntPtr field0288;
        public IntPtr field028C;
        public IntPtr field0290;
        public IntPtr field0294;
        public IntPtr field0298;

        public JassPtr AsSafe()
        {
            fixed (Jass* pointer = &this)
                return new JassPtr(pointer);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JassPtr
    {
        private IntPtr pointer;

        unsafe public JassPtr(Jass* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public Jass* AsUnsafe()
        {
            return (Jass*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }
}
