namespace PayrollPractice;
using System.Windows;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	/*private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	*/

	private void OnClear(object sender, EventArgs e)
	{
		hoursEntry.Text = "";
		rateEntry.Text = "";
		payrollLabel.Text = "";
		hoursEntry.Focus();
	}

	private void OnCalc(object sender, EventArgs e)
	{
		//DisplayAlert("Clicked", "It works", "cancel");
		double hours;
		double rate;
		double pay = 0;

		//strip from screen

		try
		{
			hours = Convert.ToDouble(hoursEntry.Text);
		}
		catch (Exception)
		{
			hours = 0;
			DisplayAlert("Error", "Numbers only", "OK");
			hoursEntry.Focus();	//put cursor in box
			return;
        }
		try
		{
			rate = Convert.ToDouble(rateEntry.Text);
		}
		catch (Exception)
		{
            rate = 0;
            DisplayAlert("Error", "Numbers only", "OK");
            rateEntry.Focus(); //put cursor in box
            return;
        }

		//do something
		pay = hours * rate;

		//output
		payrollLabel.Text = pay.ToString("$0.##");//string formatting
		SemanticScreenReader.Announce(payrollLabel.Text);
    }
}

