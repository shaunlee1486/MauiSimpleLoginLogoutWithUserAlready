using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleLoginLogout.ViewModels
{
	public class DashboardViewModel
	{
		public ICommand LogoutCommand { get; }

		public DashboardViewModel()
		{
			LogoutCommand = new Command(PerformLogoutOperation);
		}

		private async void PerformLogoutOperation(object obj)
		{
			Preferences.Clear("UserAlreadyloggedIn");

			await Shell.Current.GoToAsync("//Login");
		}
	}
}