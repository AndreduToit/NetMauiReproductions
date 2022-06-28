namespace MauiApp1
{
    public class ViewModelMainPage : ObservableObject
    {
        int count = 0;
        int buttonNumber = 0;
        string counterBtnText = "Click me";
        public string ButtonText
        {
            get => counterBtnText;
            set => SetProperty(ref counterBtnText, value);
        }
        public int ButtonNumber
        {
            get => buttonNumber;
            set => SetProperty(ref buttonNumber, value);
        }

        public Command CounterClick { get; }
        public ViewModelMainPage()
        {
            CounterClick = new Command(OnCounterClicked);

        }
        private void OnCounterClicked(object? sender)
        {
            count++;

            ButtonNumber = count % 4;

            if (count == 1)
                ButtonText = $"Clicked {count} time";
            else
                ButtonText = $"Clicked {count} times";

        }


    }
}
