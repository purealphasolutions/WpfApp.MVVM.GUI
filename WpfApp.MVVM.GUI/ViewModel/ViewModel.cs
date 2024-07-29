using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.MVVM.GUI.ViewModel
{
	public class ViewModel : ViewModelBase//: INotifyPropertyChanged
	{
		//public event PropertyChangedEventHandler? PropertyChanged;

		/*public string? FirstName 
		{ 
			get; 
			set; 
		}*/

		private readonly DelegateCommand _changeNameCommand;
		
		public ICommand ChangeNameCommand => _changeNameCommand;

		public ViewModel()
		{
			_changeNameCommand = new DelegateCommand(OnChangeName, CanChangeName);
		}

		private void OnChangeName(object commandParameter)
		{
			FirstName = "Dean";
			_changeNameCommand.InvokeCanExecuteChanged();
		}

		private string? firstName = string.Empty;

		private bool CanChangeName(object commandParameter)
		{
			return FirstName != "Dean";
		}

		public string FirstName
		{
			get => firstName!;
			set => SetProperty(ref firstName, value);
		}

		/*public void OnPropertyChanged(string propertyName) 
			=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));*/
	}
}
