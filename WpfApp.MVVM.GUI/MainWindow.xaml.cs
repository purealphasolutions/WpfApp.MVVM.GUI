using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WpfApp.MVVM.GUI.ViewModel;

namespace WpfApp.MVVM.GUI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			var viewModel = new ViewModel.ViewModel
			{
				FirstName = "Kevin"
			};

			DataContext = viewModel;

			InitializeComponent();

			viewModel.FirstName = "Mark";
			//viewModel.OnPropertyChanged(nameof(viewModel.FirstName));
		}
	}
}