using System.Windows.Controls;
using System.Windows.Input;

namespace MyLibrary.MVVM.View
{
    public partial class TablesView : UserControl
    {
        public TablesView()
        {
            InitializeComponent();
        }
        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainButton.IsChecked = false;
        }

        private void TableArea_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}