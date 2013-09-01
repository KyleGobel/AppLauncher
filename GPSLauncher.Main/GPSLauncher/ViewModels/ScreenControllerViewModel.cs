using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using GPSLauncher.Annotations;

namespace GPSLauncher.ViewModels
{
    public class ScreenControllerViewModel : INotifyPropertyChanged
    {
        public ScreenControllerViewModel()
        {
            CurrentScreen = new MainViewModel();
            SearchText = "Search";
            ExitApplicationCommand = new RelayCommand(ExitApplication);
            SearchGotFocusCommand = new RelayCommand(SearchGotFocus);
            SearchLostFocusCommand = new RelayCommand(SearchLostFocus);
            ExecuteSearchCommand = new RelayCommand(ExecuteSearch);
        }

        private void ExecuteSearch(object obj)
        {
            Process.Start("http://www.google.com/search?q=" + SearchText);
        }

        private void SearchLostFocus(object o)
        {
            if (SearchText == "")
                SearchText = "Search";
        }

        private void SearchGotFocus(object o)
        {
            if (SearchText == "Search")
                SearchText = "";
        }

        private void ExitApplication(object obj)
        {
            Application.Current.Shutdown();
        }

        private string _searchText;
        public string SearchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                if (_searchText == value)
                    return;
                _searchText = value;
                OnPropertyChanged();
            }
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

        #region Commands Declaration
        public ICommand ExitApplicationCommand { get; set; }
        public ICommand SearchLostFocusCommand { get; set; }
        public ICommand SearchGotFocusCommand { get; set; }
        public ICommand ExecuteSearchCommand { get; set; }
        #endregion //Command Declaration

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}