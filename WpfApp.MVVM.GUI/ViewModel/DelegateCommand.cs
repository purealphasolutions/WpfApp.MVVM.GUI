using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.MVVM.GUI.ViewModel
{
	public class DelegateCommand(Action<object> executeAction, Func<object, bool> canExecuteAction) : ICommand
	{
		private readonly Action<object> ExecuteAction = executeAction;

		private readonly Func<object, bool> CanExecuteAction = canExecuteAction;

		public void Execute(object? parameter) => ExecuteAction(parameter!);

		public bool CanExecute(object? parameter) => CanExecuteAction?.Invoke(parameter!) ?? true;

		public event EventHandler? CanExecuteChanged;

		public void InvokeCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
	}
}
