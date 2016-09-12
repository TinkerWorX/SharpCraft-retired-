using System;
using System.Diagnostics;
using System.IO;
using System.Text;
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

        private void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            string message;
            var messages = new StringBuilder();
            while (this.listener.Messages.TryTake(out message))
            {
                messages.Append(message);
            }
            if (messages.Length > 0)
            {
                this.OutputTextBox.Text += messages.ToString();
            }
            if (this.AutoScrollCheckBox.IsChecked ?? false)
                this.OutputTextBox.ScrollToEnd();
        }

        private void InputTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
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
