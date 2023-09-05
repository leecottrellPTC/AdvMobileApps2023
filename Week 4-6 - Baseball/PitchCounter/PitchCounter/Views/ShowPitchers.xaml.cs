using PitchCounter.Models;

namespace PitchCounter.Views;

public partial class ShowPitchers : ContentPage
{
	public ShowPitchers()
	{
		InitializeComponent();
	}

	public void FillTheList(object sender, EventArgs e)
	{
		List<PlayerClass> pitchers = App.pitchDBase.GetPitchers();
		pitcherList.ItemsSource = pitchers;
	}
}