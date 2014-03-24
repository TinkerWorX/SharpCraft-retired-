using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using EasyHook;
using Microsoft.Win32;

namespace TinkerWorX.SharpCraft.Launcher
{
    internal static class Common
    {
        public static Boolean IsInitialized { get; private set; }

        public static String InstallPath { get; private set; }

        public static String GamePath { get; private set; }

        public static String EditorPath { get; private set; }

        public static String Version { get { return FileVersionInfo.GetVersionInfo(typeof(SharpCraftApplication).Assembly.Location).FileVersion; } }

        public static void Initialize()
        {
            if (Common.IsInitialized)
                return;

            var key = Registry.CurrentUser.OpenSubKey(@"Software\Blizzard Entertainment\Warcraft III");
            if (key == null)
                throw new KeyNotFoundException("Could not find Warcraft III key in registry!" + Environment.NewLine + "To fix this, make sure you've launched Warcraft III at least once.");
            var value = key.GetValue("InstallPath");
            if (value == null)
            {
                key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Blizzard Entertainment\Warcraft III");
                value = key.GetValue("InstallPath");
            }
            Common.InstallPath = (value as String);
            if (String.IsNullOrEmpty(InstallPath))
                throw new KeyNotFoundException("Could not find InstallPath value in registry!" + Environment.NewLine + "To fix this, make sure you've launched Warcraft III at least once.");
            Common.GamePath = Path.Combine(InstallPath, "war3.exe");
            Common.EditorPath = Path.Combine(InstallPath, "worldedit.exe");

            Common.IsInitialized = true;
        }

        public static void StartGame(String[] args)
        {
            if (!Common.IsInitialized)
                Common.Initialize();

            if (!File.Exists(Common.GamePath))
                throw new FileNotFoundException("Could not find war3.exe!" + Environment.NewLine + "You may need to verify your registry settings are correct.", "war3.exe");
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "SharpCraft.dll")))
                throw new FileNotFoundException("Could not find SharpCraft.dll!" + Environment.NewLine + "You may need to redownload SharpCraft.", "SharpCraft.dll");

            Boolean kill = false;
            Boolean debug = false;
            Boolean valid = true;
            while (valid && args.Length > 0)
            {
                switch (args[0])
                {
                    case "-kill":
                        kill = true;
                        args = args.Skip(1).ToArray();
                        break;

                    case "-debug":
                        debug = true;
                        args = args.Skip(1).ToArray();
                        break;

                    default:
                        valid = false;
                        break;
                }
            }

            var war3s = Process.GetProcessesByName("war3");
            if (war3s.Count() > 0)
            {
                if (kill)
                {
                    foreach (var war3 in war3s)
                        war3.Kill();
                }
                else throw new InvalidOperationException("Warcraft III is already running!" + Environment.NewLine + "You may need to check Task Manager for \"war3.exe\", and kill it.");
            }

            Console.Write("Creating and injecting into Warcraft III . . . ");
            var cmd = '"' + Common.GamePath + '"';
            if (args.Length > 0)
                cmd += ' ' + args.Aggregate((a, b) => a + ' ' + b);

            Int32 processId;
            RemoteHooking.CreateAndInject(Common.GamePath, cmd, 0, "SharpCraft.dll", "SharpCraft.dll", out processId, PluginContext.Game, debug, Environment.CurrentDirectory, Common.InstallPath);
            Console.WriteLine("Done!");
        }

        public static void StartEditor(String[] args)
        {
            if (!Common.IsInitialized)
                Common.Initialize();

            if (!File.Exists(Common.EditorPath))
                throw new FileNotFoundException("Could not find worldedit.exe!" + Environment.NewLine + "You may need to verify your registry settings are correct.", "worldedit.exe");
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "SharpCraft.dll")))
                throw new FileNotFoundException("Could not find SharpCraft.dll!" + Environment.NewLine + "You may need to redownload SharpCraft.", "SharpCraft.dll");

            Boolean kill = false;
            Boolean debug = false;
            Boolean valid = true;
            while (valid && args.Length > 0)
            {
                switch (args[0])
                {
                    case "-kill":
                        kill = true;
                        args = args.Skip(1).ToArray();
                        break;

                    case "-debug":
                        debug = true;
                        args = args.Skip(1).ToArray();
                        break;

                    default:
                        valid = false;
                        break;
                }
            }

            var worldedits = Process.GetProcessesByName("worldedit");
            if (worldedits.Count() > 0)
            {
                if (kill)
                {
                    foreach (var worldedit in worldedits)
                        worldedit.Kill();
                }
                else throw new InvalidOperationException("World Editor is already running!" + Environment.NewLine + "You may need to check Task Manager for \"worldedit.exe\", and kill it.");
            }

            Console.Write("Creating and injecting into World Editor . . . ");
            var cmd = '"' + Common.EditorPath + '"';
            if (args.Length > 0)
                cmd += ' ' + args.Aggregate((a, b) => a + ' ' + b);

            Int32 processId;
            RemoteHooking.CreateAndInject(Common.EditorPath, cmd, 0, "SharpCraft.dll", "SharpCraft.dll", out processId, PluginContext.Editor, debug, Environment.CurrentDirectory, Common.InstallPath);
            Console.WriteLine("Done!");
        }
    }
}
