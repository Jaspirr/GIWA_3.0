namespace GIWA;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void UpdateBackgroundColor(int steps)
    {
        if (steps < 1000)
        {
            this.BackgroundColor = Color.Red;
        }
        else if (steps < 5000)
        {
            this.BackgroundColor = Color.Yellow;
        }
        else
        {
            this.BackgroundColor = Color.Green;
        }
    }
    private void UpdateSteps(int steps)
    {
        StepsLabel.Text = steps.ToString();
        UpdateBackgroundColor(steps);
    }
}

