using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Utilities;
using TinkerWorX.SharpCraft.Windows;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    unsafe internal static class InternalInterface
    {
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate IntPtr CGameUI__ConstructorPrototype(CGameUI @this);

        private static CGameUI__ConstructorPrototype CGameUI__Constructor;

        public static CGameUIInternal* GameUI { get; private set; }

        public static Single FPS { get { return Memory.Read<Single>(GameAddresses.ValueFPS); } }

        public static void Initialize()
        {
            if (Kernel32.GetModuleHandle("game.dll") == IntPtr.Zero)
                throw new Exception("Attempted to initialize " + typeof(InternalInterface).Name + " before 'game.dll' has been loaded.");

            if (!GameAddresses.IsReady)
                throw new Exception("Attempted to initialize " + typeof(InternalInterface).Name + " before " + typeof(GameAddresses).Name + " was ready.");

            var address = IntPtr.Zero;

            address = GameAddresses.CGameUI__Constructor;
            Trace.Write("CGameUI__Constructor: 0x" + address.ToString("X8") + " . ");
            InternalInterface.CGameUI__Constructor = Memory.InstallHook(address, new CGameUI__ConstructorPrototype(InternalInterface.CGameUI__ConstructorHook), true, false);
            Trace.WriteLine("installed!");
        }

        private static IntPtr CGameUI__ConstructorHook(CGameUI @this)
        {
            var result = CGameUI__Constructor(@this);

            try
            {
                InternalInterface.GameUI = @this.AsUnsafe();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalInterface.CGameUI__ConstructorHook!");
                Trace.WriteLine(e.ToString());
            }

            return result;
        }
    }
}
