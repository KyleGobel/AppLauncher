using System.Drawing;
using System.Windows.Media;

namespace GPSLauncher
{
    public interface IIconShortcut
    {
        object ImageSource { get; set; }
        string Caption { get; set; }
        string Command { get; set; }
    }
}