using Saludo_App2.ViewModel;

namespace Saludo_App2;

public partial class GreetingPage : ContentPage
{
	public GreetingPage(GreetingViewModel gvm)
	{
		InitializeComponent();
		BindingContext = gvm;
	}
}