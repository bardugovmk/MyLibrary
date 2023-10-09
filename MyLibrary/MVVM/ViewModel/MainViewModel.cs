using myLibrary.Core;
using MyLibrary.MVVM.ViewModel.TableViewModel;
using System.Windows.Input;

namespace MyLibrary.MVVM.ViewModel
{
    internal class MainViewModel: ObservebleObject
    {

        public ICommand HelpViewCommand { get; private set; }
        public ICommand ReportsViewCommand { get; private set; }
        public ICommand SettingsViewCommand { get; private set; }
        public ICommand TablesViewCommand { get; private set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; onPropertyChanged(); }
        }

        public MainViewModel()
        {
            TablesViewCommand = new RelayCommand(ShowTablesView);
            ReportsViewCommand = new RelayCommand(ShowReportsView);
            SettingsViewCommand = new RelayCommand(ShowSettingsView);
            HelpViewCommand = new RelayCommand(ShowHelpView);

            CurrentView = new TablesViewModel();
        }
        private void ShowTablesView(object parameter)
        {
            CurrentView = new TablesViewModel();
        }

        private void ShowReportsView(object parameter)
        {
            CurrentView = new ReportsViewModel();
        }

        private void ShowSettingsView(object parameter)
        {
            CurrentView = new SettingsViewModel();
        }

        private void ShowHelpView(object parameter)
        {
            CurrentView = new HelpViewModel();
        }

    }
}