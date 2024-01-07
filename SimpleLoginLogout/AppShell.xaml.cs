namespace SimpleLoginLogout
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
			var getuserSavedkey = Preferences.Get("UserAlreadyloggedIn", false);

			if (getuserSavedkey)
			{
				MyAppShell.CurrentItem = MyDashboardPage;

			}
			else
			{
				MyAppShell.CurrentItem = MyLoginPage;

			}
		}
	}
}
