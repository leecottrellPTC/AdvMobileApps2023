namespace CustomControlPlan.Controls;

public partial class MildredStepper : ContentView
{
    //create the bindable value
    //must be named VarnameProperty
    public static readonly BindableProperty ValueProperty = BindableProperty.Create(
        nameof(Value),
        typeof(int),
        typeof(MildredStepper));

    public int Value
    {
        get => (int)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
        /*get
        {
            return (int)GetValue(ValueProperty);
        }
        set
        {
            SetValue(ValueProperty, value);
        }*/
    }
	public MildredStepper()
	{
		InitializeComponent();
        Value = 0;
        ValueEntry.Text = "0";
	}

    private void ValueEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(e.NewTextValue.StartsWith("-")) {
            ValueEntry.Text = Value.ToString();
            //block negative
        }
        if(int.TryParse(e.NewTextValue, out var value))
        {
            Value = value;
        }
    }
    private void MinusButton_Clicked(object sender, EventArgs e)
    {
        if (Value > 0)
        {
            Value--;
            ValueEntry.Text = Value.ToString();
        }
    }

    private void PlusButton_Clicked(object sender, EventArgs e)
    {
        Value++;
        ValueEntry.Text = Value.ToString();
    }
}