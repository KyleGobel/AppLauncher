using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media.Imaging;
using GPSLauncher.Annotations;

namespace GPSLauncher.ViewModels
{
    public class StartScreenViewModel :INotifyPropertyChanged
    {
        public StartScreenViewModel()
        {
            Item1x1 = new IndividualIconViewModel
                {
                    Caption = "GitHub",
                    Command = @"C:\Users\Kyle\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\GitHub, Inc\GitHub.appref-ms",
                    ImageSource = new BitmapImage(new Uri(@"/GPSLauncher;component/Icons/ShortcutIcons/github-icon.png", UriKind.Relative)),
                };
      
            Item1x2 = new IndividualIconViewModel
                {
                    Caption = "VS 2012", 
                    ImageSource = new BitmapImage(new Uri(@"/GPSLauncher;component/Icons/ShortcutIcons/VS2012.png", UriKind.Relative)),
                    Command = @"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\devenv.exe"
                };
            Item1x3 = new IndividualIconViewModel
                {
                    Caption = "Sublime",
                    ImageSource = new BitmapImage(new Uri(@"/GPSLauncher;component/Icons/ShortcutIcons/sublime_text.png", UriKind.Relative)),
                    Command = @"D:\Applications\Sublime Text 2\sublime_text.exe"
                };
            Item1x4 = new IndividualIconViewModel
                {
                    Caption = "GMusic",
                    ImageSource = new BitmapImage(new Uri(@"/GPSLauncher;component/Icons/ShortcutIcons/gmusic.png", UriKind.Relative)),
                    Command = "http://music.google.com/"
                };
        }

        #region Items
        private IndividualIconViewModel _item1x1;
        public IndividualIconViewModel Item1x1
        {
            get
            {
                return _item1x1;
            }
            set
            {
                _item1x1 = value;
                OnPropertyChanged();
            }
        }

        private IndividualIconViewModel _item1x2;
        public IndividualIconViewModel Item1x2
        {
            get
            {
                return _item1x2;
            }
            set
            {
                _item1x2 = value;
                OnPropertyChanged();
            }
        }

        private IndividualIconViewModel _item1x3;
        public IndividualIconViewModel Item1x3
        {
            get
            {
                return _item1x3;
            }
            set
            {
                _item1x3 = value;
                OnPropertyChanged();
            }
        }
        private IndividualIconViewModel _item1x4;
        public IndividualIconViewModel Item1x4
        {
            get
            {
                return _item1x4;
            }
            set
            {
                _item1x4 = value;
                OnPropertyChanged();
            }
        }
        #endregion //Items

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion //INotifyPropertyChanged
    }
}