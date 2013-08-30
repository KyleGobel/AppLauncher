using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using GPSLauncher.Annotations;

namespace GPSLauncher.ViewModels
{
    public class IndividualIconViewModel : IIconShortcut, INotifyPropertyChanged
    {
        public IndividualIconViewModel()
        {
            
        }
        private string _image;
        private string _caption;
        private string _command;

        public string ImageSource
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
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}