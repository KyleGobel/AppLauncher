using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GPSLauncher.Annotations;

namespace GPSLauncher.ViewModels
{
    public class IndividualIconViewModel : IIconShortcut, INotifyPropertyChanged
    {
        public IndividualIconViewModel()
        {
            LaunchCommand = new RelayCommand(LaunchCommandExecute, CanExecuteLaunchCommand);
        }
        private object _image;
        private string _caption;
        private string _command;

        public object ImageSource
        {
            get
            {
                return _image;
            }
            set
            {
                if (_image == value)
                    return;
                _image = value;
                OnPropertyChanged();
            }
        }

        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                if (_caption == value)
                    return;
                _caption = value;
                OnPropertyChanged();
            }
        }
        public string Command
        {
            get
            {
                return _command;
            }
            set
            {
                if (_command == value)
                    return;
                _command = value;
                OnPropertyChanged();
            }
        }
        public ICommand LaunchCommand
        {
            get;
            internal set;
        }
        private bool CanExecuteLaunchCommand(object obj)
        {
            return true;
        }

  
        public void LaunchCommandExecute(object obj)
        {
            Process.Start(Command);
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