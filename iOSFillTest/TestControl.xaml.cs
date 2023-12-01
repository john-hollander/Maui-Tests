namespace iOSFillTest;

public partial class TestControl : ContentView
{
    public TestControl()
	{
		InitializeComponent();
	} 

    public void SetFull()
    {
        colDone.Width = new GridLength(1, GridUnitType.Star);
        colLeft.Width = new GridLength(0, GridUnitType.Star);
    }
}
