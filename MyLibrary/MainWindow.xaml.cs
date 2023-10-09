using System.Windows;
using System.Windows.Input;

namespace MyLibrary
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBoxResult Result = MessageBox.Show("Вы действительно хотите выйти?", "МояБиблиотека", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //if (Result == MessageBoxResult.Yes)
            //{
            //    this.Close();
            //}
            this.Close();
        }

        private void MaximizedButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void OverTheWindowsButton_Checked(object sender, RoutedEventArgs e)
        {
            Topmost = true;
        }

        private void OverTheWindowsButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Topmost = false;
        }
    }
}