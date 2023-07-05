namespace Ch3FindMe;

public partial class MainPage : ContentPage
{
    string baseUrl = "https://bing.com/maps/default.aspx?cp=";
	public string UserName { get; set; }

	public MainPage()
	{
		InitializeComponent();
	}
    private async Task ShareLocation()
    {
        UserName = UsernameEntry.Text;

        var locationRequest = new GeolocationRequest(GeolocationAccuracy.Best);
        var location = await Geolocation.GetLocationAsync(locationRequest);

        await Share.RequestAsync(new ShareTextRequest
        {
            Subject = "Find me!",
            Title = "Find me!",
            Text = $"{UserName} is sharing their location with you",
            Uri = $"{baseUrl}{location.Latitude}~{location.Longitude}"
        });
    }
    private async void OnFindMeClicked(object sender, EventArgs e)
    {
        var permissions = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

        if (permissions == PermissionStatus.Granted)
        {
            await ShareLocation();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Permissions Error", "You have not granted the app permission to access your location.", "OK");

            var requested = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

            if (requested == PermissionStatus.Granted)
            {
                await ShareLocation();
            }
            else
            {

                if (DeviceInfo.Platform == DevicePlatform.iOS || DeviceInfo.Platform == DevicePlatform.MacCatalyst)
                {
                    await App.Current.MainPage.DisplayAlert("Location  Required", "Location is required to share it.  Please enable location for this app in Settings.", "OK");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Location  Required", "Location is required to share it.  We'll ask again next time.", "OK");
                }
            }
        }
    }

}

