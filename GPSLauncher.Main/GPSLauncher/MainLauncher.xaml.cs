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
            this.Top = System.Windows.SystemParameters.PrimaryScreenHeight - this.Height - GetTaskbarHeight();
            this.Left = System.Windows.Forms.Cursor.Position.X - (this.Width / 2);
        }

   



        public static int GetTaskbarHeight()
        {
            return Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
        }

  
    }
}
