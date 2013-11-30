using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CGameUI
    {
        private readonly IntPtr ptr;

        public CWorldFrame WorldFrameMessage
        {
            get { return (CWorldFrame)Marshal.PtrToStructure(this.ptr + 0x3E4, typeof(CWorldFrame)); } // TODO: Add this offset to settings.
        }

        public CWorldFrame WorldFrameUnitMessage
        {
            get { return (CWorldFrame)Marshal.PtrToStructure(this.ptr + 0x3E8, typeof(CWorldFrame)); } // TODO: Add this offset to settings.
        }

        public CWorldFrame WorldFrameChatMessage
        {
            get { return (CWorldFrame)Marshal.PtrToStructure(this.ptr + 0x3EC, typeof(CWorldFrame)); } // TODO: Add this offset to settings.
        }

        public CWorldFrame WorldFrameTopMessage
        {
            get { return (CWorldFrame)Marshal.PtrToStructure(this.ptr + 0x3F0, typeof(CWorldFrame)); } // TODO: Add this offset to settings.
        }

        public void WriteChatMessage(Int32 senderId, String message, ChatRecipients recipients, Single duration)
        {
            //sub_6F2FB480(this.ptr, player_id, message, recipients, duration);
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
