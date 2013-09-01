using System.Windows.Forms;

namespace GPSLauncher
{
    /// <summary>
    /// Interaction logic for MainLauncher.xaml
    /// </summary>
    public partial class HostView
    {
        public HostView()
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
