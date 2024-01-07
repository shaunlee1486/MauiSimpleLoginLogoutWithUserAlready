using SimpleLoginLogout.ViewModels;

namespace SimpleLoginLogout.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
	}
}