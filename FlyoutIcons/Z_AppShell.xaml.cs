namespace MauiApp1;

public partial class Z_AppShell : Shell
{
    public Z_AppShell()
    {
        InitializeComponent();
        BindingContext = new ViewModelAppShell();
    }
}