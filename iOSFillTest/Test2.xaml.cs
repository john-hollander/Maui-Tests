namespace iOSFillTest;

public partial class Test2 : ContentPage
{
	public Test2()
	{
		InitializeComponent();
	}

    private void OnTestClicked(object sender, EventArgs e)
    {
        AbsoluteLayout.SetLayoutBounds(RectTest, new(10, 10, 200, 30));
    }
}