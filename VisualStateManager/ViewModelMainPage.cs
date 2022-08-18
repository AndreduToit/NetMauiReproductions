namespace MauiApp1
{
    public class ViewModelMainPage : ObservableObject
    {
        int count = 0;
        bool button1IsEnabled = true;
        bool button2IsEnabled = true;
        string counterBtnText = "Click me";
        public string ButtonText
        {
            get => counterBtnText;
            set => SetProperty(ref counterBtnText, value);
        }
        public bool Button1IsEnabled
        {
            get => button1IsEnabled;
            set => SetProperty(ref button1IsEnabled, value);
        }
        public bool Button2IsEnabled
        {
            get => button2IsEnabled;
            set => SetProperty(ref button2IsEnabled, value);
        }

        public Command CounterClick { get; }
        public Command Enabled1Click { get; }
        public Command Enabled2Click { get; }
        public ViewModelMainPage()
        {
            CounterClick = new Command(OnCounterClicked);
            Enabled1Click = new Command(OnEnabled1Clicked);
            Enabled2Click = new Command(OnEnabled2Clicked);

        }
        private void OnCounterClicked(object? sender)
        {
            count++;

            if (count == 1)
                ButtonText = $"Clicked {count} time";
            else
                ButtonText = $"Clicked {count} times";
            Button2IsEnabled = !Button2IsEnabled;
            Button1IsEnabled = !Button1IsEnabled;
        }

        private void OnEnabled1Clicked(object? sender)
        {
            Button2IsEnabled = !Button2IsEnabled;
        }
        private void OnEnabled2Clicked(object? sender)
        {
            Button1IsEnabled = !Button1IsEnabled;
        }

    }
}
