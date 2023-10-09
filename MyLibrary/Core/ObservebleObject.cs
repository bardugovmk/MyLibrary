using myLibrary.Core;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace myLibrary.Core
{
    class ObservebleObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void onPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private RelayCommand showTablesViewCommand;

        public ICommand ShowTablesViewCommand
        {
            get
            {
                if (showTablesViewCommand == null)
                {
                    showTablesViewCommand = new RelayCommand(ShowTablesView);
                }

                return showTablesViewCommand;
            }
        }

        private void ShowTablesView(object commandParameter)
        {
        }
    }
}
