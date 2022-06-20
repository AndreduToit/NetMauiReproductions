namespace MauiClient
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {

            var devSslHelper = new DevHttpsConnectionHelper(sslPort: 7331);
            var http = devSslHelper.HttpClient;
            var response = await http.GetStringAsync($"{devSslHelper.DevServerRootUrl }/Home/TestMe");

            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";
            if (!string.IsNullOrEmpty(response))
                WebAPIBtn.Text = $"Response from WebAPI: {response}";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}