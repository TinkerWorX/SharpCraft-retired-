using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using EasyHook;
using Microsoft.Win32;
using TinkerWorX.SharpCraft.Windows;

namespace TinkerWorX.SharpCraft.Launcher
{
    public class SharpCraftApplication : Application
    {
        [STAThread]
        public static void Main(String[] args)
        {
            // This fixes the current directory in case it is run from outside the launcher path.
            Environment.CurrentDirectory = Path.GetDirectoryName(typeof(SharpCraftApplication).Assembly.Location);

            // Check for optional map specified to launch
            string mapFile = ""; // Is there a loadfile arg specified?
            for (var i = 0; i < args.Length; i++)
            {
                if (args[i] == "-loadfile")
                {
                    // check the argument immediately to the right... it should be a map file (w3x or w3m) or a replay (w3g)
                    if (args[i + 1].EndsWith(".w3x") || args[i + 1].EndsWith(".w3m") || args[i + 1].EndsWith(".w3g"))
                    {
                        mapFile = args[i + 1];
                        // clean string and wrap in quotes because path may contain spaces
                        // note: even when passing in the arg in quotes, those will "disappear", so quotes are re-applied
                        args[i] = "\"" + args[i].Trim() + "\"";
                    }
                    else
                    {
                        Console.WriteLine("The -loadfile param was specified, but was not immediately followed by a valid WarCraft map to open.");
                    }
                }
            }

            if (args.Contains("-game") || args.Contains("-editor"))
            {
                Debug.WriteLineIf(args.Contains("-game"), args.Aggregate((a, b) => a + ' ' + b));
                Debug.WriteLineIf(mapFile.Length > 0, "Starting game with map: " + mapFile);
                StartDirect(args);
            }
            else
            {
                StartLauncher(args);
            }
        }

        private static void StartLauncher(String[] args)
        {
            var application = new SharpCraftApplication();
            application.Resources.Add("args", args);
            application.StartupUri = new Uri("LauncherWindow.xaml", UriKind.Relative);
            application.Run();
        }

        private static void StartDirect(String[] args)
        {
            try
            {
                Common.Initialize();

                switch (args.First())
                {
                    case "-game": Common.StartGame(args.Skip(1).ToArray()); break;
                    case "-editor": Common.StartEditor(args.Skip(1).ToArray()); break;
                    default: throw new ArgumentException(@"Invalid start argument: """ + args[0] + @""", valid arguments are ""-game"" or ""-editor""");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), e.GetType().Name);
            }
        }
    }
}
