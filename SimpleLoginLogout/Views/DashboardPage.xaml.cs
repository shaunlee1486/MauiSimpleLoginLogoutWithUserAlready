using SimpleLoginLogout.ViewModels;

namespace SimpleLoginLogout.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
		BindingContext = new DashboardViewModel();
	}
}