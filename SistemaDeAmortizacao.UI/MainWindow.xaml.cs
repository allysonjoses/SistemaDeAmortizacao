using MahApps.Metro.Controls;
using SistemaDeAmortizacao.UI.ViewModel;
using System.Windows.Controls;

namespace SistemaDeAmortizacao.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        MainWindowsViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainWindowsViewModel(this);
            this.DataContext = viewModel;
        }
    }
}
