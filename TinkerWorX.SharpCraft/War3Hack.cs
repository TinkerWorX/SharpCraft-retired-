using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using EasyHook;
using TinkerWorX.SharpCraft.Utilities;
using TinkerWorX.SharpCraft.Windows;

namespace TinkerWorX.SharpCraft
{
    internal static class War3Hack
    {
        private static Kernel32.LoadLibraryAPrototype LoadLibraryA;

        public static Boolean IsReady { get; private set; }

        public static event Action Ready;

        public static void Initialize()
        {
            try
            {
                if (Kernel32.GetModuleHandle("war3.exe") == IntPtr.Zero)
                    throw new Exception("Attempted to initialize " + typeof(War3Hack).Name + " before 'war3.exe' has been loaded.");

                var address = LocalHook.GetProcAddress("kernel32.dll", "LoadLibraryA");
                Trace.Write("LoadLibraryA: 0x" + address.ToString("X8") + " . ");
                War3Hack.LoadLibraryA = Memory.InstallHook(address, new Kernel32.LoadLibraryAPrototype(War3Hack.LoadLibraryAHook), false, true);

                War3Hack.IsReady = true;
                War3Hack.OnReady();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Fatal exception!" + Environment.NewLine +
                    exception + Environment.NewLine +
                    "Aborting execution!",
                    typeof(War3Hack) + ".Initialize()", MessageBoxButton.OK, MessageBoxImage.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        private static void OnReady()
        {
            if (War3Hack.Ready != null)
                War3Hack.Ready();
        }

        private static IntPtr LoadLibraryAHook(String fileName)
        {
            IntPtr module;

            switch (fileName.ToLower())
            {
                case "game.dll":
                    module = War3Hack.LoadLibraryA(fileName);
                    GameHack.Initialize();
                    break;

                default:
                    module = War3Hack.LoadLibraryA(fileName);
                    break;
            }

            return module;
        }
    }
}
