using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using EasyHook;
using TinkerWorX.SharpCraft.Game.Core;

namespace TinkerWorX.SharpCraft.Game
{
    public delegate void PlayerChatEventHandler(Int32 sender, String message, ChatRecipients recipients);

    public class InterfaceSystem
    {
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate IntPtr CGameUIConstructorDelegate(CGameUI _this);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        internal delegate IntPtr CGameUI__DisplayChatMessageDelegate(CGameUI _this, Int32 sender, String message, ChatRecipients recipients, Single duration);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        internal delegate IntPtr CWorldFrame__WriteLineDelegate(CWorldFrame _this, String message, ref CColor color, Single duration, Int32 a5);

        private CGameUIConstructorDelegate CGameUIConstructor;

        internal CGameUI__DisplayChatMessageDelegate CGameUI__DisplayChatMessage;

        internal CWorldFrame__WriteLineDelegate CWorldFrame__WriteLine;

        private LocalHook CGameUIConstructorLocalHook;

        private LocalHook CGameUI__DisplayChatMessageLocalHook;

        private CGameUI gameUI;

        public Boolean BlockChat;

        public event PlayerChatEventHandler PlayerChat;

        public InterfaceSystem()
        {
            this.InstallCGameUIConstructorHook(WarcraftIII.Module + 0x002FE9F0); // TODO: Add this address to settings.
            this.InstallCGameUI__DisplayChatMessageHook(WarcraftIII.Module + 0x002FB480); // TODO: Add this address to settings.
            this.FetchCWorldFrame__WriteLine(WarcraftIII.Module + 0x006049B0); // TODO: Add this address to settings.
        }

        public CGameUI GameUI { get { return this.gameUI; } }

        public Single FPS { get { return (Single)Marshal.PtrToStructure(WarcraftIII.Module + 0x00A88BD0, typeof(Single)); } } // TODO: Add this address to settings.

        internal void OnPlayerChat(Int32 sender, String message, ChatRecipients recipients)
        {
            if (this.PlayerChat != null)
                this.PlayerChat(sender, message, recipients);
        }

        private void InstallCGameUIConstructorHook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - CGameUIConstructor: 0x" + address.ToString("X8") + " . ");

                this.CGameUIConstructor = (CGameUIConstructorDelegate)Marshal.GetDelegateForFunctionPointer(address, typeof(CGameUIConstructorDelegate));
                Trace.Write("fetched . ");

                this.CGameUIConstructorLocalHook = LocalHook.Create(address, new CGameUIConstructorDelegate(this.CGameUIConstructorHook), null);
                this.CGameUIConstructorLocalHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void InstallCGameUI__DisplayChatMessageHook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - CGameUI__DisplayChatMessage: 0x" + address.ToString("X8") + " . ");

                this.CGameUI__DisplayChatMessage = (CGameUI__DisplayChatMessageDelegate)Marshal.GetDelegateForFunctionPointer(address, typeof(CGameUI__DisplayChatMessageDelegate));
                Trace.Write("fetched . ");

                this.CGameUI__DisplayChatMessageLocalHook = LocalHook.Create(address, new CGameUI__DisplayChatMessageDelegate(this.CGameUI__DisplayChatMessageHook), null);
                this.CGameUI__DisplayChatMessageLocalHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void FetchCWorldFrame__WriteLine(IntPtr address)
        {
            try
            {
                Trace.Write(" - - CWorldFrame__WriteLine: 0x" + address.ToString("X8") + " . ");

                this.CWorldFrame__WriteLine = (CWorldFrame__WriteLineDelegate)Marshal.GetDelegateForFunctionPointer(address, typeof(CWorldFrame__WriteLineDelegate));
                Trace.WriteLine("fetched!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private IntPtr CGameUIConstructorHook(CGameUI _this)
        {
            var result = CGameUIConstructor(_this);

            this.gameUI = _this;

            return result;
        }

        private IntPtr CGameUI__DisplayChatMessageHook(CGameUI _this, Int32 sender, String message, ChatRecipients recipients, Single duration)
        {
            var result = IntPtr.Zero;

            if (!this.BlockChat)
                result = CGameUI__DisplayChatMessage(_this, sender, message, recipients, duration);

            this.OnPlayerChat(sender, message, recipients);

            return result;
        }
    }
}
