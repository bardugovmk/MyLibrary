using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace myLibrary.Core
{
    class ObservebleObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void onPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
