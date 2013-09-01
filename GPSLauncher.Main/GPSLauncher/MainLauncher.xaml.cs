using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace GPSLauncher
{
    /// <summary>
    /// Interaction logic for MainLauncher.xaml
    /// </summary>
    public partial class MainLauncher : Window
    {
        public MainLauncher()
        {
            InitializeComponent();
            this.LostFocus += OnLostFocus;
            this.Deactivated += MainLauncherDeactivated;
            this.Topmost = true;
            this.Top = System.Windows.SystemParameters.PrimaryScreenHeight - this.Height - GetTaskbarHeight();
            this.Left = System.Windows.Forms.Cursor.Position.X - (this.Width / 2);
        }

        void MainLauncherDeactivated(object sender, EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void OnLostFocus(object sender, RoutedEventArgs routedEventArgs)
        {
            System.Windows.Application.Current.Shutdown();
        }

        public static int GetTaskbarHeight()
        {
            return Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void SearchBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text == "Search")
                SearchBox.Text = "";
        }

        private void SearchBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text == "")
                SearchBox.Text = "Search";
        }

        private void SearchBox_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Process.Start("http://www.google.com/search?q=" + SearchBox.Text);
            }
        }
    }
}
