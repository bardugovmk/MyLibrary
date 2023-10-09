using myLibrary.Core;
using System.Windows.Input;

namespace MyLibrary.MVVM.ViewModel.TableViewModel
{
    internal class TableMainViewModel : ObservebleObject
    {

        public ICommand ActiveReadersViewCommand { get; private set; }
        public ICommand AuthorsTableViewCommand { get; private set; }
        public ICommand BooksInLibraryViewCommand { get; private set; }
        public ICommand BooksOnHandViewCommand { get; private set; }
        public ICommand BookTableViewCommand { get; private set; }
        public ICommand DebtorsTableViewCommand { get; private set; }
        public ICommand FormatsTableViewCommand { get; private set; }
        public ICommand GenresTableViewCommand { get; private set; }
        public ICommand Issuance_ReturnViewCommand { get; private set; }
        public ICommand IssuanceTableViewCommand { get; private set; }
        public ICommand PublishingHousesTableViewCommand { get; private set; }
        public ICommand ReaderTableViewCommand { get; private set; }
        public ICommand ReturnTableViewCommand { get; private set; }
        public ICommand SeriesTableViewCommand { get; private set; }
        public ICommand WorksTableViewCommand { get; private set; }


        private object _currentTableView;

        public object CurrentTableView
        {
            get { return _currentTableView; }
            set { _currentTableView = value; onPropertyChanged(); }
        }

        public TableMainViewModel()
        {
            ActiveReadersViewCommand = new RelayCommand(ShowActiveReadersView);
            AuthorsTableViewCommand = new RelayCommand(ShowAuthorsTableView);
            BooksInLibraryViewCommand = new RelayCommand(ShowBooksInLibraryView);
            BooksOnHandViewCommand = new RelayCommand(ShowBooksOnHandView);
            BookTableViewCommand = new RelayCommand(ShowBookTableView);
            DebtorsTableViewCommand = new RelayCommand(ShowDebtorsTableView);
            FormatsTableViewCommand = new RelayCommand(ShowFormatsTableView);
            GenresTableViewCommand = new RelayCommand(ShowGenresTableView);
            Issuance_ReturnViewCommand = new RelayCommand(ShowIssuance_ReturnView);
            IssuanceTableViewCommand = new RelayCommand(ShowIssuanceTableView);
            PublishingHousesTableViewCommand = new RelayCommand(ShowPublishingHousesTableView);
            ReaderTableViewCommand = new RelayCommand(ShowReaderTableView);
            ReturnTableViewCommand = new RelayCommand(ShowReturnTableView);
            SeriesTableViewCommand = new RelayCommand(ShowSeriesTableView);
            WorksTableViewCommand = new RelayCommand(ShowWorksTableView);

            CurrentTableView = new AuthorsTableViewModel();
        }
        private void ShowActiveReadersView(object parameter)
        {
            CurrentTableView = new ActiveReadersViewModel();
        }
        private void ShowAuthorsTableView(object parameter)
        {
            CurrentTableView = new AuthorsTableViewModel();
        }
        private void ShowBooksInLibraryView(object parameter)
        {
            CurrentTableView = new BooksInLibraryViewModel();
        }
        private void ShowBooksOnHandView(object parameter)
        {
            CurrentTableView = new BooksOnHandViewModel();
        }
        private void ShowBookTableView(object parameter)
        {
            CurrentTableView = new BookTableViewModel();
        }
        private void ShowDebtorsTableView(object parameter)
        {
            CurrentTableView = new DebtorsTableViewModel();
        }
        private void ShowFormatsTableView(object parameter)
        {
            CurrentTableView = new FormatsTableViewModel();
        }
        private void ShowGenresTableView(object parameter)
        {
            CurrentTableView = new GenresTableViewModel();
        }
        private void ShowIssuance_ReturnView(object parameter)
        {
            CurrentTableView = new Issuance_ReturnViewModel();
        }
        private void ShowIssuanceTableView(object parameter)
        {
            CurrentTableView = new IssuanceTableViewModel();
        }
        private void ShowPublishingHousesTableView(object parameter)
        {
            CurrentTableView = new PublishingHousesTableViewModel();
        }
        private void ShowReaderTableView(object parameter)
        {
            CurrentTableView = new ReaderTableViewModel();
        }
        private void ShowReturnTableView(object parameter)
        {
            CurrentTableView = new ReturnTableViewModel();
        }
        private void ShowSeriesTableView(object parameter)
        {
            CurrentTableView = new SeriesTableViewModel();
        }
        private void ShowWorksTableView(object parameter)
        {
            CurrentTableView = new WorksTableViewModel();
        }
    }
}
