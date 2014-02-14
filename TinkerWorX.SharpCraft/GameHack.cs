using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using TinkerWorX.SharpCraft.Blizzard.GameModule;
using TinkerWorX.Windows;

namespace TinkerWorX.SharpCraft
{
    internal static class GameHack
    {
        public static Boolean IsReady { get; private set; }

        public static event Action Ready;

        public static void Initialize()
        {
            try
            {
                if (Kernel32.GetModuleHandle("game.dll") == IntPtr.Zero)
                    throw new Exception("Attempted to initialize " + typeof(GameHack).Name + " before 'game.dll' has been loaded.");

                var sw = (Stopwatch)null;

                sw = new Stopwatch();
                Trace.WriteLine("Initializing addresses . . .");
                Trace.Indent();
                sw.Start();
                GameAddresses.Initialize();
                sw.Stop();
                Trace.Unindent();
                Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");

                sw = new Stopwatch();
                Trace.WriteLine("Initializing functions . . .");
                Trace.Indent();
                sw.Start();
                GameFunctions.Initialize();
                sw.Stop();
                Trace.Unindent();
                Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");

                sw = new Stopwatch();
                Trace.WriteLine("Initializing Game api . . .");
                Trace.Indent();
                sw.Start();
                Game.Initialize();
                sw.Stop();
                Trace.Unindent();
                Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");

                sw = new Stopwatch();
                Trace.WriteLine("Initializing JassMachine api . . .");
                Trace.Indent();
                sw.Start();
                JassMachine.Initialize();
                sw.Stop();
                Trace.Unindent();
                Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");

                sw = new Stopwatch();
                Trace.WriteLine("Initializing Interface api . . .");
                Trace.Indent();
                sw.Start();
                Interface.Initialize();
                sw.Stop();
                Trace.Unindent();
                Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");

                sw = new Stopwatch();
                Trace.WriteLine("Initializing Input api . . .");
                Trace.Indent();
                sw.Start();
                Input.Initialize();
                sw.Stop();
                Trace.Unindent();
                Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");

                sw = new Stopwatch();
                Trace.WriteLine("Initializing Natives api . . .");
                Trace.Indent();
                sw.Start();
                Natives.Initialize();
                sw.Stop();
                Trace.Unindent();
                Trace.WriteLine(" - Done! (" + sw.ElapsedMilliseconds + " ms)");

                GameHack.IsReady = true;
                GameHack.OnReady();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Fatal exception!" + Environment.NewLine +
                    exception + Environment.NewLine +
                    "Aborting execution!",
                    typeof(GameHack) + ".Initialize()", MessageBoxButton.OK, MessageBoxImage.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        private static void OnReady()
        {
            if (GameHack.Ready != null)
                GameHack.Ready();
        }
    }
}
