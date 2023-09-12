namespace LikertPlan;

public partial class MainPage : ContentPage
{
    public int Value { get; set; }
    public void ChoiceChange(object sender, EventArgs e)
	{
		RadioButton rad = (RadioButton)sender;
		if (rad.IsChecked == true)
		{
			Value = Convert.ToInt16(rad.Value.ToString());
			DisplayAlert("Choice", Value.ToString(), "OK");
		}
    }


    public MainPage()
	{
		InitializeComponent();
	}

	
}

