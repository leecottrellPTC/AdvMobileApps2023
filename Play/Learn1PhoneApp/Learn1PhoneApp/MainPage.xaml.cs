namespace Learn1PhoneApp;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}
    string translatedNumber;

    private void OnTranslate(object sender, EventArgs e)
    {
        string enteredNumber = PhoneNumberText.Text;
        translatedNumber = Core.PhonewordTranslator.ToNumber(enteredNumber);

        if (!string.IsNullOrEmpty(translatedNumber))
        {
            CallButton.IsEnabled = true;
            CallButton.Text = "Call " + translatedNumber;
        }
        else
        {
            CallButton.IsEnabled = true;
            CallButton.Text = "Call " + translatedNumber;
        }
    }//end OnTranslate

    async void OnCall(object sender, System.EventArgs e)
    {
        if (await this.DisplayAlert(
        "Dial a Number",
        "Would you like to call " + translatedNumber + "?",
        "Yes",
        "No"))
        {
            try
            {
                if (PhoneDialer.Default.IsSupported)
                    PhoneDialer.Default.Open(translatedNumber);
            }
            catch (ArgumentNullException)
            {
                await DisplayAlert("Unable to dial", "Phone number was not valid.", "OK");
            }
            catch (Exception)
            {
                // Other error has occurred.
                await DisplayAlert("Unable to dial", "Phone dialing failed.", "OK");
            }
        }
    }

}

