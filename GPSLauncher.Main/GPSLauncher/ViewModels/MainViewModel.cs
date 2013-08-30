using System.ComponentModel;
using System.Runtime.CompilerServices;
using GPSLauncher.Annotations;

namespace GPSLauncher.ViewModels
{
    public class MainViewModel :INotifyPropertyChanged
    {
        public MainViewModel()
        {
            Item1x1 = new IndividualIconViewModel {Caption = "Foo!"};
            Item1x2 = new IndividualIconViewModel {Caption = "Hello App!", ImageSource = "Icons/menu.png"};
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