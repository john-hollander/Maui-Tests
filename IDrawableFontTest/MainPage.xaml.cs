namespace IDrawableFontTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            view.Drawable = new DrawableTest();
        }
    }

}
