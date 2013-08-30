using System.ComponentModel;
using System.Runtime.CompilerServices;
using GPSLauncher.Annotations;

namespace GPSLauncher.ViewModels
{
    public class ScreenControllerViewModel : INotifyPropertyChanged
    {
        public ScreenControllerViewModel()
        {
            CurrentScreen = new MainViewModel();
        }
        private object _currentScreen;
        public object CurrentScreen
        {
            get
            {
                return _currentScreen;

            }
            set
            {
                if (_currentScreen == value)
                    return;
                _currentScreen = value;
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