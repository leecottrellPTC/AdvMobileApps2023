using UnitsNet;
using DataBindLecture_WeightConvert.Models;
using DataBindLecture_WeightConvert.Data;

namespace DataBindLecture_WeightConvert;

public partial class MainPage : ContentPage
{
    public DataClass database = new();
    public List<Conversion> DataList { get; set; } = new();
    //List, Collection, ObservableCollection


    private void OnSliderChange(object sender, EventArgs e)
    {
        double sliderValue = weightSlider.Value;
        Mass pounds = new Mass(sliderValue,
            UnitsNet.Units.MassUnit.Pound);
        double kg = pounds.Kilograms;
        kilogramLabel.Text = kg.ToString("F1");
    }

    public MainPage()
	{
		InitializeComponent();
        //fill the list
        foreach (Conversion conversion in database.DataConvRay)
        {
            DataList.Add(conversion);  
        }
	}

	
}

