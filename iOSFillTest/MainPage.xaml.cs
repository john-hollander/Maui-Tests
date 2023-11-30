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
            Column1.Width = new(1, GridUnitType.Star);
            Column2.Width = new(0, GridUnitType.Star);
        }
    }

}
