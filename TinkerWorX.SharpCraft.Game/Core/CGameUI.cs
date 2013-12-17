using System;
using System.Runtime.InteropServices;
using TinkerWorX.SharpCraft.Game.Jass;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential, Size = 0x454)]
    unsafe public struct CGameUI
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
        public Boolean IsUserInterfaceEnabled; //field01B0
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
        public IntPtr field029C;
        public IntPtr field02A0;
        public IntPtr field02A4;
        public IntPtr field02A8;
        public IntPtr field02AC;
        public IntPtr field02B0;
        public IntPtr field02B4;
        public IntPtr field02B8;
        public IntPtr field02BC;
        public IntPtr field02C0;
        public IntPtr field02C4;
        public IntPtr field02C8;
        public IntPtr field02CC;
        public IntPtr field02D0;
        public IntPtr field02D4;
        public IntPtr field02D8;
        public IntPtr field02DC;
        public IntPtr field02E0;
        public IntPtr field02E4;
        public IntPtr field02E8;
        public IntPtr field02EC;
        public IntPtr field02F0;
        public IntPtr field02F4;
        public IntPtr field02F8;
        public IntPtr field02FC;
        public IntPtr field0300;
        public IntPtr field0304;
        public IntPtr field0308;
        public IntPtr field030C;
        public IntPtr field0310;
        public IntPtr field0314;
        public IntPtr field0318;
        public IntPtr field031C;
        public IntPtr field0320;
        public IntPtr field0324;
        public IntPtr field0328;
        public IntPtr field032C;
        public IntPtr field0330;
        public IntPtr field0334;
        public IntPtr field0338;
        public IntPtr field033C;
        public IntPtr field0340;
        public IntPtr field0344;
        public IntPtr field0348;
        public IntPtr field034C;
        public IntPtr field0350;
        public IntPtr field0354;
        public IntPtr field0358;
        public IntPtr field035C;
        public IntPtr field0360;
        public IntPtr field0364;
        public IntPtr field0368;
        public IntPtr field036C;
        public IntPtr field0370;
        public IntPtr field0374;
        public IntPtr field0378;
        public IntPtr field037C;
        public IntPtr field0380;
        public IntPtr field0384;
        public IntPtr field0388;
        public IntPtr field038C;
        public IntPtr field0390;
        public IntPtr field0394;
        public IntPtr field0398;
        public IntPtr field039C;
        public IntPtr field03A0;
        public IntPtr field03A4;
        public IntPtr field03A8;
        public IntPtr field03AC;
        public IntPtr field03B0;
        public IntPtr field03B4;
        public IntPtr field03B8;
        public IntPtr field03BC;
        public IntPtr field03C0;
        public IntPtr field03C4;
        public IntPtr field03C8;
        public IntPtr field03CC;
        public IntPtr field03D0;
        public IntPtr field03D4;
        public IntPtr field03D8;
        public IntPtr field03DC;
        public IntPtr field03E0;
        public CSimpleMessageFrame* Message;     //field03E4
        public CSimpleMessageFrame* UnitMessage; //field03E8
        public CSimpleMessageFrame* ChatMessage; //field03EC
        public CSimpleMessageFrame* TopMessage;  //field03F0
        public IntPtr field03F4;
        public IntPtr field03F8;
        public IntPtr field03FC;
        public IntPtr field0400;
        public IntPtr field0404;
        public IntPtr field0408;
        public IntPtr field040C;
        public IntPtr field0410;
        public IntPtr field0414;
        public IntPtr field0418;
        public IntPtr field041C;
        public IntPtr field0420;
        public IntPtr field0424;
        public IntPtr field0428;
        public IntPtr field042C;
        public IntPtr field0430;
        public IntPtr field0434;
        public IntPtr field0438;
        public IntPtr field043C;
        public IntPtr field0440;
        public IntPtr field0444;
        public IntPtr field0448;
        public IntPtr field044C;
        public IntPtr field0450;

        public CGameUIPtr AsSafe()
        {
            fixed (CGameUI* pointer = &this)
                return new CGameUIPtr(new IntPtr(pointer));
        }

        public void WriteChatMessage(Int32 sender, String message, ChatRecipients recipients, Single duration)
        {
            this.AsSafe().WriteChatMessage(sender, message, recipients, duration);
        }

        public void WriteChatMessage(JassPlayer sender, String message, ChatRecipients recipients, Single duration)
        {
            this.AsSafe().WriteChatMessage(sender.Index, message, recipients, duration);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CGameUIPtr
    {
        private IntPtr pointer;

        public CGameUIPtr(IntPtr pointer)
        {
            this.pointer = pointer;
        }

        public CSimpleMessageFramePtr Message
        {
            get { unsafe { return this.AsUnsafe()->Message->AsSafe(); } }
        }

        public CSimpleMessageFramePtr UnitMessage
        {
            get { unsafe { return this.AsUnsafe()->UnitMessage->AsSafe(); } }
        }

        public CSimpleMessageFramePtr ChatMessage
        {
            get { unsafe { return this.AsUnsafe()->ChatMessage->AsSafe(); } }
        }

        public CSimpleMessageFramePtr TopMessage
        {
            get { unsafe { return this.AsUnsafe()->TopMessage->AsSafe(); } }
        }

        unsafe public CGameUI* AsUnsafe()
        {
            return (CGameUI*)this.pointer;
        }

        public void WriteChatMessage(Int32 sender, String message, ChatRecipients recipients, Single duration)
        {
            WarcraftIII.Interface.CGameUI__DisplayChatMessage(this, sender, message, recipients, duration);
        }

        public void WriteChatMessage(JassPlayer sender, String message, ChatRecipients recipients, Single duration)
        {
            WarcraftIII.Interface.CGameUI__DisplayChatMessage(this, sender.Index, message, recipients, duration);
        }
    }

    public enum ChatRecipients : int
    {
        All = 0,
        Allies = 1,
        ObserversReferees = 2,
        Private = 3
    }
}
