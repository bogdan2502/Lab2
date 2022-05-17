using System.Windows;
using Lab2.ViewModels;

namespace Lab2
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }
    }
}
