using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using EasyHook;
using Microsoft.Win32;
using TinkerWorX.Windows;

namespace TinkerWorX.SharpCraft.Launcher
{
    public class SharpCraftApplication : Application
    {
        [STAThread]
        public static void Main(String[] args)
        {
            // This fixes the current directory in case it is run from outside the launcher path.
            Environment.CurrentDirectory = Path.GetDirectoryName(typeof(SharpCraftApplication).Assembly.Location);

            if (args.Contains("-game") || args.Contains("-editor"))
                StartDirect(args);
            else
                StartLauncher(args);
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
