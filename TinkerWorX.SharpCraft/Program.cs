using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using EasyHook;
using Microsoft.Win32;
using TinkerWorX.SharpCraft.Core;

namespace TinkerWorX.SharpCraft
{
    internal static class Program
    {
        private static Version version = new Version(0, 1, 0, 0);

        private static String installPath;

        private static String gamePath;

        private static String editorPath;

        private static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("Sharpcraft by MindWorX");
#if DEBUG
                Console.WriteLine("Version: {0} (debug)", Program.version);
#else
                Console.WriteLine("Version: {0} (release)", Program.version);
#endif

                if (args.Length == 0)
                    throw new StartupException(@"Missing start argument, valid arguments are ""-game"" or ""-editor""");

                Program.LoadSettings();
                Program.LocateExecutables();
                Program.CheckVersions();
                //Program.RegisterAssemblies(); - Obsolete as of EasyHook version 2.7.4761.0 beta.
                Program.Start(args);

                Console.WriteLine();
                Console.WriteLine("Sharpcraft injected successfully!");
            }
            catch (StartupException exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadKey(true);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                Console.ReadKey(true);
            }
        }

        private static void LoadSettings()
        {
            Console.Write("Loading settings . . . ");
            if (!File.Exists("settings.xml"))
                throw new StartupException("settings.xml missing.");
            Settings.Load("settings.xml");
            Console.WriteLine("Done!");
        }

        private static void LocateExecutables()
        {
            Console.Write("Locating executables . . . ");
            var key = Registry.CurrentUser.OpenSubKey(@"Software\Blizzard Entertainment\Warcraft III");
            if (key == null)
                throw new StartupException("Could not find Warcraft III key in registry!" + Environment.NewLine + "To fix this, make sure you've launched Warcraft III at least once.");
            var value = key.GetValue("InstallPath");
            if (value == null)
            {
                key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Blizzard Entertainment\Warcraft III");
                value = key.GetValue("InstallPath");
            }
            installPath = (value as String);
            if (String.IsNullOrEmpty(installPath))
                throw new StartupException("Could not find InstallPath value in registry!" + Environment.NewLine + "To fix this, make sure you've launched Warcraft III at least once.");
            gamePath = Path.Combine(installPath, "war3.exe");
            editorPath = Path.Combine(installPath, "worldedit.exe");
            Console.WriteLine("Done!");
        }

        private static void CheckVersions()
        {
            Console.Write("Checking versions . . . ");
            var version = new Version(
                FileVersionInfo.GetVersionInfo(gamePath).FileMajorPart,
                FileVersionInfo.GetVersionInfo(gamePath).FileMinorPart,
                FileVersionInfo.GetVersionInfo(gamePath).FileBuildPart,
                FileVersionInfo.GetVersionInfo(gamePath).FilePrivatePart);
            if (version == Settings.Current.Version)
                Console.WriteLine("Done!");
            else if (version > Settings.Current.Version)
                throw new StartupException("Mismatch!" + Environment.NewLine + "To fix this, you need to update your addresses to version " + version + ".");
            else if (version < Settings.Current.Version)
                throw new StartupException("Mismatch!" + Environment.NewLine + "To fix this, you need to update Warcraft III to version " + Settings.Current.Version + ".");
        }

        [Obsolete("Obsolete as of EasyHook version 2.7.4761.0 beta.")]
        private static void RegisterAssemblies()
        {
            Console.Write("Registerring assemblies . . . ");
            Config.Register(
                "Sharpcraft by MindWorX",
                "Sharpcraft.exe",
                "Sharpcraft.Core.dll",
                "Sharpcraft.Editor.dll",
                "Sharpcraft.Game.dll");
            Console.WriteLine("Done!");
        }

        private static void Start(String[] args)
        {
            switch (args[0])
            {
                case "-game": StartGame(args.Skip(1).ToArray()); break;
                case "-editor": StartEditor(args.Skip(1).ToArray()); break;
                default: throw new StartupException(@"Invalid start argument: """ + args[0] + @""", valid arguments are ""-game"" or ""-editor""");
            }
        }

        private static void StartGame(String[] args)
        {
            var kill = (args.Length > 0 && args[0] == "-kill");
            if (kill)
                args = args.Skip(1).ToArray();

            var war3s = Process.GetProcessesByName("war3");
            if (war3s.Count() > 0)
            {
                if (kill)
                {
                    foreach (var war3 in war3s)
                        war3.Kill();
                }
                else throw new StartupException("Warcraft III is already running!" + Environment.NewLine + "You may need to check Task Manager for \"war3.exe\", and kill it.");
            }

            Console.Write("Creating and injecting into Warcraft III . . . ");
            var process = new Process { StartInfo = new ProcessStartInfo(gamePath, String.Empty) };
            foreach (var arg in args)
                if (arg == args.Last())
                    process.StartInfo.Arguments += arg;
                else
                    process.StartInfo.Arguments += arg + " ";
            process.Start();
            RemoteHooking.Inject(process.Id, "Sharpcraft.Game.dll", "Sharpcraft.Game.dll", Environment.CurrentDirectory, installPath);
            Console.WriteLine("Done!");
        }

        private static void StartEditor(String[] args)
        {
            var kill = (args.Length > 0 && args[0] == "-kill");
            if (kill)
                args = args.Skip(1).ToArray();

            var worldedits = Process.GetProcessesByName("worldedit");
            if (worldedits.Count() > 0)
            {
                if (kill)
                {
                    foreach (var worldedit in worldedits)
                        worldedit.Kill();
                }
                else throw new StartupException("World Editor is already running!" + Environment.NewLine + "You may need to check Task Manager for \"worldedit.exe\", and kill it.");
            }

            Console.Write("Creating and injecting into World Editor . . . ");
            var process = new Process { StartInfo = new ProcessStartInfo(editorPath, String.Empty) };
            foreach (var arg in args)
                if (arg == args.Last())
                    process.StartInfo.Arguments += arg;
                else
                    process.StartInfo.Arguments += arg + " ";
            process.Start();
            RemoteHooking.Inject(process.Id, "Sharpcraft.Editor.dll", "Sharpcraft.Editor.dll", Environment.CurrentDirectory, installPath);
            Console.WriteLine("Done!");
        }
    }

    internal class StartupException : Exception
    {
        public StartupException(String message) : base(message) { }
    }
}
