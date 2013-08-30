using System.Drawing;
using System.Windows.Media;

namespace GPSLauncher
{
    public interface IIconShortcut
    {
        string ImageSource { get; set; }
        string Caption { get; set; }
        string Command { get; set; }
    }
}