using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using TinkerWorX.SharpCraft.Utilities;

namespace TinkerWorX.SharpCraft
{
    public partial class DebuggerWindow : Window
    {
        private ConcurrentBagListener listener = new ConcurrentBagListener();

        public DebuggerWindow(PluginContext context, string hackPath)
        {
            this.InitializeComponent();

            Trace.Listeners.Add(this.listener);

            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        private void CompositionTarget_Rendering(Object sender, EventArgs e)
        {
            string message;
            while (this.listener.Messages.TryTake(out message))
            {
                this.OutputTextBox.Text += message;
                this.OutputTextBox.ScrollToEnd();
            }
        }

        private void InputTextBox_PreviewKeyDown(Object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;

                this.OutputTextBox.ScrollToEnd();
                this.InputTextBox.Clear();
            }
        }
    }
}
