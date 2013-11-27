using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EasyHook;
using TinkerWorX.SharpCraft.Core;
using Assembly = System.Reflection.Assembly;

namespace TinkerWorX.SharpCraft.Game
{
    public class EntryPoint : IEntryPoint
    {
        private PluginManager pluginManager;

        public EntryPoint(RemoteHooking.IContext context, String hackPath, String installPath)
        {
            try
            {
                // Settings passed from the launcher.
                WarcraftIII.HackPath = hackPath;
                WarcraftIII.InstallPath = installPath;

                Settings.Load(Path.Combine(WarcraftIII.HackPath, "settings.xml"));

                if (Settings.Current.IsDebugging)
                {
                    Kernel32.AllocConsole();
                    Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
                }
                Trace.AutoFlush = true;
                Trace.Listeners.Add(new TextWriterTraceListener(Path.Combine(WarcraftIII.HackPath, "debug.log")));
                Trace.WriteLine("-------------------");
                Trace.WriteLine(DateTime.Now);

                AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Low-Level exception!" + Environment.NewLine +
                    exception + Environment.NewLine +
                    "Aborting execution!",
                    this.GetType() + " (Constructor)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        public Assembly CurrentDomain_AssemblyResolve(Object sender, ResolveEventArgs args)
        {
            // Convert name to filename
            var file = args.Name.Split(',').First() + ".dll";

            // Search root directory
            if (File.Exists(Path.Combine(WarcraftIII.HackPath, file)))
                return Assembly.LoadFrom(Path.Combine(WarcraftIII.HackPath, file));

            // Search plugins directory
            if (File.Exists(Path.Combine(Path.Combine(WarcraftIII.HackPath, "plugins"), file)))
                return Assembly.LoadFrom(Path.Combine(Path.Combine(WarcraftIII.HackPath, "plugins"), file));

            return null;
        }

        public void Run(RemoteHooking.IContext context, String hackPath, String installPath)
        {
            try
            {
                this.pluginManager = new PluginManager();
                Trace.WriteLine("Loading plugins . . . ");
                this.pluginManager.LoadPlugins();
                Trace.WriteLine(" - Done!");
                Trace.WriteLine(String.Empty);

                Trace.WriteLine("Initializing WarcraftIII . . . ");
                WarcraftIII.Initialize();
                Trace.WriteLine(" - Done!");
                Trace.WriteLine(String.Empty);

                Trace.WriteLine("Initializing plugins . . . ");
                this.pluginManager.InitializePlugins();
                Trace.WriteLine(" - Done!");
                Trace.WriteLine(String.Empty);

                RemoteHooking.WakeUpProcess();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Low-Level exception!" + Environment.NewLine +
                    exception + Environment.NewLine +
                    "Aborting execution!",
                    this.GetType() + " (Run)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}
