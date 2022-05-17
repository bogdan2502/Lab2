using System.Windows.Controls;
using Lab2.ViewModels;

namespace Lab2.Views
{
    /// <summary>
    /// Interaction logic for ViewControl.xaml
    /// </summary>
    public partial class ViewControl : UserControl
    {
        public ViewControl()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }
    }
}
