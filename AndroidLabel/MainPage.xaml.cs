namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string[] LabelTexts = new string[] { "Short", "--Medium1--", "----Medium2----", "--------Long1--------", "-----------Long2-----------" };
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            TextLbl.Text = LabelTexts[count % 5];


            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

    }
}