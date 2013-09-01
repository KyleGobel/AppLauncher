using System.ComponentModel;
using System.Runtime.CompilerServices;
using GPSLauncher.Annotations;

namespace GPSLauncher.ViewModels
{
    public class MainViewModel :INotifyPropertyChanged
    {
        public MainViewModel()
        {
            Item1x1 = new IndividualIconViewModel {Caption = "Foo Bar!"};
            Item1x2 = new IndividualIconViewModel
                {
                    Caption = "VS 2012", 
                    ImageSource = "http://fc06.deviantart.net/fs70/i/2012/344/9/1/flurry_ios_visual_studio_2012_replacement_icon_by_flakshack-d5nnelp.png",
                    Command = "http://visualstudio.com"
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

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}