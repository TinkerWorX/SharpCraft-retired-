using System;
using System.Runtime.InteropServices;
using TinkerWorX.SharpCraft.Game.Jass;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CGameUI
    {
        private readonly IntPtr ptr;

        public CWorldFrame Message
        {
            get { return (CWorldFrame)Marshal.PtrToStructure(this.ptr + 0x3E4, typeof(CWorldFrame)); } // TODO: Add this offset to settings.
        }

        public CWorldFrame UnitMessage
        {
            get { return (CWorldFrame)Marshal.PtrToStructure(this.ptr + 0x3E8, typeof(CWorldFrame)); } // TODO: Add this offset to settings.
        }

        public CWorldFrame ChatMessage
        {
            get { return (CWorldFrame)Marshal.PtrToStructure(this.ptr + 0x3EC, typeof(CWorldFrame)); } // TODO: Add this offset to settings.
        }

        public CWorldFrame TopMessage
        {
            get { return (CWorldFrame)Marshal.PtrToStructure(this.ptr + 0x3F0, typeof(CWorldFrame)); } // TODO: Add this offset to settings.
        }

        public void WriteChatMessage(Int32 sender, String message, ChatRecipients recipients, Single duration)
        {
            WarcraftIII.Interface.CGameUI__DisplayChatMessage(this, sender, message, recipients, duration);
        }

        public void WriteChatMessage(JassPlayer sender, String message, ChatRecipients recipients, Single duration)
        {
            this.WriteChatMessage(sender.Index, message, recipients, duration);
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
