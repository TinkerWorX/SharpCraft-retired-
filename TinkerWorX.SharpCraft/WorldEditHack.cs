using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Windows;

namespace TinkerWorX.SharpCraft
{
    internal static class WorldEditHack
    {
        public static Boolean IsReady { get; private set; }

        public static event Action Ready;

        public static void Initialize()
        {
            if (Kernel32.GetModuleHandle("worldedit.exe") == IntPtr.Zero)
                throw new Exception("Attempted to initialize " + typeof(WorldEditHack).Name + " before 'worldedit.exe' has been loaded.");

            WorldEditHack.IsReady = true;
            WorldEditHack.OnReady();
        }

        private static void OnReady()
        {
            if (WorldEditHack.Ready != null)
                WorldEditHack.Ready();
        }
    }
}
