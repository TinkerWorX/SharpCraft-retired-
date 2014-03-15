using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using EasyHook;
using TinkerWorX.SharpCraft.Blizzard.GameModule;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.Windows;

namespace TinkerWorX.SharpCraft
{
    unsafe public class EntryPoint : IEntryPoint
    {
        public EntryPoint(RemoteHooking.IContext hookingContext, String context, Boolean isDebugging, String hackPath, String installPath)
        {
            try
            {
                // I'm sure I used to do something useful here...
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

        public void Run(RemoteHooking.IContext hookingContext, String context, Boolean isDebugging, String hackPath, String installPath)
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

                var sw = (Stopwatch)null; 
                
                sw = new Stopwatch();
                Trace.WriteLine("Initializing plugin system . . .");
                Trace.Indent();
                sw.Start();
                PluginSystem.Initialize(context, hackPath);
                sw.Stop();
                Trace.Unindent();
                Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");

                switch (context)
                {
                    case "game":
                        sw = new Stopwatch();
                        Trace.WriteLine("Initializing game hacks . . .");
                        Trace.Indent();
                        sw.Start();
                        War3Hack.Ready += delegate() { RemoteHooking.WakeUpProcess(); };
                        War3Hack.Initialize();
                        sw.Stop();
                        Trace.Unindent();
                        Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");
                        break;

                    case "editor":
                        sw = new Stopwatch();
                        Trace.WriteLine("Initializing editor hacks . . .");
                        Trace.Indent();
                        sw.Start();
                        WorldEditHack.Ready += delegate() { RemoteHooking.WakeUpProcess(); };
                        WorldEditHack.Initialize();
                        sw.Stop();
                        Trace.Unindent();
                        Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");
                        break;
                }

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
    }
}
