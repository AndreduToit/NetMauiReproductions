
namespace MauiApp1;

public class ViewModelAppShell : ObservableObject
{
    private bool mainPageIsVisible = true;
    private bool infoPageIsVisible = true;
    private bool backPageIsVisible = true;
    private bool signOutPageIsVisible = true;

    public bool MainPageIsVisible
    {
        get => mainPageIsVisible;
        set => SetProperty(ref mainPageIsVisible, value);
    }
    public bool InfoPageIsVisible
    {
        get => infoPageIsVisible;
        set => SetProperty(ref infoPageIsVisible, value);
    }
    public bool BackPageIsVisible
    {
        get => backPageIsVisible;
        set => SetProperty(ref backPageIsVisible, value);
    }
    public bool SignOutPageIsVisible
    {
        get => signOutPageIsVisible;
        set => SetProperty(ref signOutPageIsVisible, value);
    }
    public string IconFontInfo => IconFont.Info;

    public ViewModelAppShell()
    {
        MessagingCenter.Subscribe<ViewModelMessengerPage, int>(this, "commandSendClicked", (viewModel, _Int) =>
        {
            switch (_Int)
            {
                case 1:
                    {
                        MainPageIsVisible = !mainPageIsVisible;
                        break;
                    }
                case 2:
                    {
                        InfoPageIsVisible = !infoPageIsVisible;
                        break;
                    }
                case 3:
                    {
                        BackPageIsVisible = !backPageIsVisible;
                        break;
                    }
                case 4:
                    {
                        SignOutPageIsVisible = !signOutPageIsVisible;
                        break;
                    }
                default: { break; }
            }
        }); ;
    }
}
