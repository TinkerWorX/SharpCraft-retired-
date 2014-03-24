using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using EasyHook;
using TinkerWorX.SharpCraft.Utilities;
using TinkerWorX.SharpCraft.Windows;

namespace TinkerWorX.SharpCraft
{
    unsafe public class EntryPoint : IEntryPoint
    {
        private Kernel32.LoadLibraryAPrototype LoadLibraryA;

        private PluginContext context;

        public EntryPoint(RemoteHooking.IContext hookingContext, PluginContext context, Boolean isDebugging, String hackPath, String installPath)
        {
            try
            {
                this.context = context;
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Fatal exception!" + Environment.NewLine +
                    exception + Environment.NewLine +
                    "Aborting execution!",
                    this.GetType() + ".ctor(...)", MessageBoxButton.OK, MessageBoxImage.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        public void Run(RemoteHooking.IContext hookingContext, PluginContext context, Boolean isDebugging, String hackPath, String installPath)
        {
            try
            {
                if (isDebugging)
                {
                    DebuggerApplication.Start(context, hackPath);
                    while (!DebuggerApplication.IsReady)
                        Thread.Sleep(1); // Sleep(0) is a nono.
                }
                Trace.IndentSize = 2;

                // We autoflush our trace, so we get everything immediately. This 
                // makes tracing a bit more expensive, but means we still get a log
                // even if there's a fatal crash.
                Trace.AutoFlush = true;

                // Everything traced will be written to "debug.log".
                Trace.Listeners.Add(new TextWriterTraceListener(Path.Combine(hackPath, "debug.log")));

                Trace.WriteLine("-------------------");
                Trace.WriteLine(DateTime.Now);
                Trace.WriteLine("-------------------");
                Trace.WriteLine(String.Empty);

                var sw = new Stopwatch();

                Trace.WriteLine("Initializing plugin system . . .");
                Trace.Indent();
                sw.Restart();
                PluginSystem.LoadPlugins(hackPath);
                Trace.Unindent();
                Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");

                Trace.WriteLine("Initializing plugins . . .");
                Trace.Indent();
                sw.Restart();
                PluginSystem.Initialize(PluginContext.Common);
                PluginSystem.Initialize(context);
                Trace.Unindent();
                Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");

                // Prepare the OnGameLoad hook.
                var address = LocalHook.GetProcAddress("kernel32.dll", "LoadLibraryA");
                Trace.Write("Installing LoadLibraryA hook @ 0x" + address.ToString("X8") + " . ");
                this.LoadLibraryA = Memory.InstallHook(address, new Kernel32.LoadLibraryAPrototype(this.LoadLibraryAHook), false, true);
                Trace.WriteLine("installed!");

                // Everyone has had their chance to inject stuff,
                // time to wake up the process.
                RemoteHooking.WakeUpProcess();

                // Let the thread stay alive, so all hooks stay alive as well.
                // This might need to be shutdown properly on exit.
                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Fatal exception!" + Environment.NewLine +
                    exception + Environment.NewLine +
                    "Aborting execution!",
                    this.GetType() + ".Run(...)", MessageBoxButton.OK, MessageBoxImage.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        private IntPtr LoadLibraryAHook(String fileName)
        {
            var module = this.LoadLibraryA(fileName);

            switch (fileName.ToLower())
            {
                case "game.dll":
                    var sw = new Stopwatch();

                    Trace.WriteLine("OnGameLoad plugins . . .");
                    Trace.Indent();
                    sw = Stopwatch.StartNew();
                    PluginSystem.OnGameLoad(PluginContext.Common);
                    PluginSystem.OnGameLoad(this.context);
                    Trace.Unindent();
                    Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");

                    break;
            }

            return module;
        }
    }
}
