using System.Diagnostics;

namespace IDrawableFontTest
{
    public partial class MainPage : ContentPage
    {
        public Point? Extent { get; set; }

        public MainPage()
        {
            InitializeComponent();

            view.Drawable = new DrawableTest(this);
        }

        private void HandleTapped(object sender, TappedEventArgs e)
        {
            Extent = e.GetPosition(view);
            view.Invalidate();
            Debug.Print($"Pointer: {Extent}");
        }
    }
}
