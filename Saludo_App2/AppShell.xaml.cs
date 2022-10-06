namespace Saludo_App2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(GreetingPage),typeof(GreetingPage));
	}
}
