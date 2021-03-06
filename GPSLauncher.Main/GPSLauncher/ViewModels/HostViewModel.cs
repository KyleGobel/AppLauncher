﻿using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using GPSLauncher.Annotations;

namespace GPSLauncher.ViewModels
{
    public class HostViewModel : INotifyPropertyChanged
    {
        public HostViewModel()
        {
            SearchText = "Search";
            StartScreen = new StartScreenViewModel();
            ExitApplicationCommand = new RelayCommand(ExitApplication);
            SearchGotFocusCommand = new RelayCommand(SearchGotFocus);
            SearchLostFocusCommand = new RelayCommand(SearchLostFocus);
            ExecuteSearchCommand = new RelayCommand(ExecuteSearch);
        }

        public object StartScreen { get; set; }
        public void ExecuteSearch(object obj)
        {
            Process.Start("http://www.google.com/search?q=" + SearchText);
        }

        public void SearchLostFocus(object o)
        {
            if (SearchText == "")
                SearchText = "Search";
        }

        public void SearchGotFocus(object o)
        {
            //if (SearchText == "Search")
                SearchText = "";
        }

        public void ExitApplication(object obj)
        {
            #if !DEBUG
                Application.Current.Shutdown();
            #endif
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