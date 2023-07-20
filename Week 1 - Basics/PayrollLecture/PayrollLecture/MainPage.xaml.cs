namespace PayrollLecture;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
	private void OnResetClick(object sender, EventArgs e)
	{
		hoursEntry.Text = string.Empty;
		rateEntry.Text = string.Empty;
		payrollLabel.Text = string.Empty;
		hoursEntry.Focus();
	}
	private void OnPayrollClick(object sender, EventArgs e)
	{
		/*
		 * read the data from the screen objects (strip the data)
		 * do something with the data - logic
		 * output to object on screen
		 */

		//strip the data
		double hours=0, rate=0, pay=0;

		try
		{
			hours = Convert.ToDouble(hoursEntry.Text);
		}
		catch (Exception)
		{
			hours = 0;//set hours to a default
			DisplayAlert("Error in hours", "Numbers only please", "OK");
			//yell at the user
			hoursEntry.Focus(); //put cursor in the box
			return;//stop calc
		}

		try
		{
			rate = Convert.ToDouble(rateEntry.Text);
		}
		catch (Exception)
		{
            rate = 0;//set hours to a default
            DisplayAlert("Error in rate", "Numbers only please", "OK");
            //yell at the user
            rateEntry.Focus(); //put cursor in the box
            return;//stop calc
        }

		//do the math

		pay = hours * rate;

		//show the answer

		payrollLabel.Text = pay.ToString("$0.##");


		//DisplayAlert("Button clicked", "Iţ works", "Done");
				//title, message, cancel button text
	}
	
}

