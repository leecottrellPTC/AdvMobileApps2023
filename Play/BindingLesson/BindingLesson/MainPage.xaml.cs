using System.Collections;
using System.Collections.ObjectModel;
using UnitsNet;
using BindingLesson.Data;
using BindingLesson.Models;
namespace BindingLesson;

public partial class MainPage : ContentPage
{
	public double kgConvert = 0;
	public DataClass database = new DataClass();
	public List<Conversion> DataList { get; set; } = new();
   // public Conversion[] convRay = new Conversion[4];

   /* public void FillRay()
    {
        //this will get better when we get to MVVM
        convRay[0] = new Conversion("Kg to Lb", 2.205);
        convRay[1] = new Conversion("G to Oz", .0353);
        convRay[2] = new Conversion("Oz to g", 28.349);
        convRay[3] = new Conversion("Lb to Kg", .4536);

    }
   */

    public MainPage()
	{
		InitializeComponent();
		//FillRay();
		foreach(Conversion conv in database.DataConvRay)
		{
			DataList.Add(conv);
		}

	}

	private void OnValueChanged(object sender, EventArgs e)
	{
		double sliderValue = WeightSlider.Value;
		Mass pounds= new Mass(sliderValue,UnitsNet.Units.MassUnit.Pound); //from UNitsnet
		double kg = pounds.Kilograms;   //CONVERTS THE VALUE	
        //https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
        KgLabel.Text = kg.ToString("F1");
	}

}

