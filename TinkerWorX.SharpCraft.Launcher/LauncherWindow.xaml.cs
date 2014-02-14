using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TinkerWorX.SharpCraft.Launcher
{
    public partial class LauncherWindow : Window
    {
        private String[] args;

        public LauncherWindow()
        {
            try
            {
                this.InitializeComponent();
                Common.Initialize();

                this.args = (String[])Application.Current.Resources["args"];
                if (args == null)
                    throw new InvalidOperationException("The Application was launched improperly. Resources('args') are missing.");

                this.Title = this.args.Aggregate(this.Title, (a, b) => a + " " + b);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), e.GetType().Name);
            }
        }

        private void CommandBinding_Close_Executed(Object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void CommandBinding_Close_CanExecute(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
