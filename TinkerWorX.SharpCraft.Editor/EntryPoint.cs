using EasyHook;
using TinkerWorX.SharpCraft.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TinkerWorX.SharpCraft.Editor
{
    public class EntryPoint : IEntryPoint
    {
        public EntryPoint(RemoteHooking.IContext context, String hackPath, String installPath)
        {
            try
            {
                WorldEditor.HackPath = hackPath;
                WorldEditor.InstallPath = installPath;
                Settings.Load(Path.Combine(WorldEditor.HackPath, "settings.xml"));

                if (Settings.Current.IsDebugging)
                {
                    Kernel32.AllocConsole();
                }

                Console.WriteLine("Settings loaded!");
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

        public void Run(RemoteHooking.IContext context, String directory, String installPath)
        {
            try
            {
                WorldEditor.Initialize();
                Console.WriteLine("WorldEditor intialized!");

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
