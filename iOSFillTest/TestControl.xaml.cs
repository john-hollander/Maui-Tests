namespace iOSFillTest;

public partial class TestControl : ContentView
{
    private double _progress = 0;

    public TestControl()
	{
		InitializeComponent();
	} 

    public double Progress
    {
        get => _progress;
        set
        {
            value = System.Math.Clamp(value, 0.0, 1.0);

            if (_progress != value)
            {
                _progress = value;
                colDone.Width = new GridLength(value, GridUnitType.Star);
                colLeft.Width = new GridLength(1 - value, GridUnitType.Star);
            }
        }
    }
}
