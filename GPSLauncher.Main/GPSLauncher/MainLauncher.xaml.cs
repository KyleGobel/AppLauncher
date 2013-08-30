using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
         //   System.Windows.Application.Current.Shutdown();
        }

        private void OnLostFocus(object sender, RoutedEventArgs routedEventArgs)
        {

         //   System.Windows.Application.Current.Shutdown();
        }

        public static int GetTaskbarHeight()
        {
            return Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
        }
    }
}
