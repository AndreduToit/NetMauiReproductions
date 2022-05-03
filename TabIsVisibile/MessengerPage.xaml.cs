namespace MauiApp1;

public partial class MessengerPage : ContentPage
{
	public MessengerPage()
	{
		InitializeComponent();
		BindingContext = new ViewModelMessengerPage();
	}

}