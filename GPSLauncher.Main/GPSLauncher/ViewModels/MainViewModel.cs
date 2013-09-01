using System.ComponentModel;
using System.Runtime.CompilerServices;
using GPSLauncher.Annotations;

namespace GPSLauncher.ViewModels
{
    public class MainViewModel :INotifyPropertyChanged
    {
        public MainViewModel()
        {
            Item1x1 = new IndividualIconViewModel
                {
                    Caption = "GitHub",
                    Command = @"C:\Users\Kyle\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\GitHub, Inc\GitHub.appref-ms",
                    ImageSource = "http://files.softicons.com/download/social-media-icons/glowing-social-network-icons-by-aaron-nichols/png/600/GitHub_Icon.png"
                };
            Item1x2 = new IndividualIconViewModel
                {
                    Caption = "VS 2012", 
                    ImageSource = "http://fc06.deviantart.net/fs70/i/2012/344/9/1/flurry_ios_visual_studio_2012_replacement_icon_by_flakshack-d5nnelp.png",
                    Command = @"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\devenv.exe"
                };
            Item1x3 = new IndividualIconViewModel
                {
                    Caption = "Sublime",
                    ImageSource = "http://c758482.r82.cf2.rackcdn.com/sublime_text_icon_2181.png",
                    Command = @"D:\Applications\Sublime Text 2\sublime_text.exe"
                };
            Item1x4 = new IndividualIconViewModel
                {
                    Caption = "GMusic",
                    ImageSource = "http://wcdn4.dataknet.com/static/resources/icons/set31/7e819aff.png",
                    Command = "http://music.google.com/"
                };
        }
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
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}