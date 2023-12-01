namespace iOSFillTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTestClicked(object sender, EventArgs e)
        {
            colDone.Width = new GridLength(1, GridUnitType.Star);
            colLeft.Width = new GridLength(0, GridUnitType.Star);
        }
    }
}
