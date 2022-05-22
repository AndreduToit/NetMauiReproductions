using System.Windows.Input;

namespace MauiApp1;

public class ViewModelMessengerPage
{
    public ICommand CommandSendClicked { get; }

    public ViewModelMessengerPage()
    {
        CommandSendClicked = new Command(OnClicked);
    }

    private void OnClicked(object commandParameter)
    {
        if (int.TryParse(commandParameter.ToString(), out var _Int))
            MessagingCenter.Send<ViewModelMessengerPage, int>(this, "commandSendClicked", _Int);
    }

}
