using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using EasyHook;
using Microsoft.Win32;
using System.Windows;

namespace TinkerWorX.SharpCraft.Launcher
{
    internal static class Common
    {
        public static bool IsInitialized { get; private set; }

        public static string InstallPath { get; private set; }

        public static string GamePath { get; private set; }

        public static string EditorPath { get; private set; }

        public static string Version { get { return FileVersionInfo.GetVersionInfo(typeof(SharpCraftApplication).Assembly.Location).FileVersion; } }

        public static bool Initialize()
        {
            if (!Common.IsInitialized)
            {
                Console.WriteLine("Locating InstallPath . . . ");
                if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"..\war3.exe")))
                {
                    Console.WriteLine("Found war3.exe in parent folder, using local InstallPath.");
                    Common.InstallPath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.LastIndexOf("\\") + 1);
                }
                else
                {
                    Console.WriteLine("Using registry to locate InstallPath.");
                    var key = Registry.CurrentUser.OpenSubKey(@"Software\Blizzard Entertainment\Warcraft III");
                    if (key != null && key.GetValue("InstallPath") != null)
                        Common.InstallPath = (key.GetValue("InstallPath") as String);
                    if (String.IsNullOrEmpty(Common.InstallPath))
                    {
                        key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Blizzard Entertainment\Warcraft III");
                        if (key != null && key.GetValue("InstallPath") != null)
                            Common.InstallPath = (key.GetValue("InstallPath") as String);
                    }
                    if (String.IsNullOrEmpty(Common.InstallPath))
                    {
                        var dialog = new OpenFileDialog();
                        dialog.Filter = "Warcraft III|war3.exe";
                        var result = dialog.ShowDialog();
                        if (result.HasValue && result.Value)
                        {
                            Common.InstallPath = Path.GetDirectoryName(dialog.FileName);

                            var doInstall = MessageBox.Show("Install path into registry?", "SharpCraft", MessageBoxButton.YesNo);
                            if (doInstall == MessageBoxResult.Yes)
                            {
                                key = Registry.CurrentConfig.CreateSubKey(@"Software\Blizzard Entertainment\Warcraft III");
                                key.SetValue("InstallPath", Common.InstallPath);
                            }
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
                Common.GamePath = Path.Combine(InstallPath, "war3.exe");
                Common.EditorPath = Path.Combine(InstallPath, "worldedit.exe");

                Common.IsInitialized = true;
            }

            return true;
        }

        public static void StartGame(string[] args)
        {
            if (!Common.Initialize())
                return;

            if (!File.Exists(Common.GamePath))
                throw new FileNotFoundException("Could not find war3.exe!" + Environment.NewLine + "You may need to verify your registry settings are correct.", "war3.exe");
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "SharpCraft.dll")))
                throw new FileNotFoundException("Could not find SharpCraft.dll!" + Environment.NewLine + "You may need to redownload SharpCraft.", "SharpCraft.dll");

            var kill = false;
            var debug = false;
            var valid = true;
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
                else
                    throw new InvalidOperationException("Warcraft III is already running!" + Environment.NewLine + "You may need to check Task Manager for \"war3.exe\", and kill it.");
            }

            Console.Write("Creating and injecting into Warcraft III . . . ");
            string cmd = String.Empty;
            if (args.Length > 0)
                cmd = args.Aggregate((a, b) => a + ' ' + b);

            int processId;
            RemoteHooking.CreateAndInject(Common.GamePath, cmd, 0, "SharpCraft.dll", "SharpCraft.dll", out processId, PluginContext.Game, debug, Environment.CurrentDirectory, Common.InstallPath);
            Console.WriteLine("Done!");
        }

        public static void StartEditor(string[] args)
        {
            if (!Common.Initialize())
                return;

            if (!File.Exists(Common.EditorPath))
                throw new FileNotFoundException("Could not find worldedit.exe!" + Environment.NewLine + "You may need to verify your registry settings are correct.", "worldedit.exe");
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "SharpCraft.dll")))
                throw new FileNotFoundException("Could not find SharpCraft.dll!" + Environment.NewLine + "You may need to redownload SharpCraft.", "SharpCraft.dll");

            bool kill = false;
            bool debug = false;
            bool valid = true;
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
                else
                    throw new InvalidOperationException("World Editor is already running!" + Environment.NewLine + "You may need to check Task Manager for \"worldedit.exe\", and kill it.");
            }

            Console.Write("Creating and injecting into World Editor . . . ");
            string cmd = String.Empty;
            if (args.Length > 0)
                cmd = args.Aggregate((a, b) => a + ' ' + b);

            int processId;
            RemoteHooking.CreateAndInject(Common.EditorPath, cmd, 0, "SharpCraft.dll", "SharpCraft.dll", out processId, PluginContext.Editor, debug, Environment.CurrentDirectory, Common.InstallPath);
            Console.WriteLine("Done!");
        }
    }
}
