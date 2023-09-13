namespace CottrellLibrary2;

public partial class Likert : ContentView
{
    public string Question
	{
		get =>(string)GetValue(QuestionProperty);
		set => SetValue(QuestionProperty, value);
	}
	public static readonly BindableProperty QuestionProperty = BindableProperty.Create(
		nameof(Question),
		typeof(string),
		typeof(Likert));

    public int Value
    {
        get => (int)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }
    public static readonly BindableProperty ValueProperty = BindableProperty.Create(
        nameof(Value),
        typeof(int),
        typeof(Likert));

    public void ChoiceChange(object sender, EventArgs e)
    {
        RadioButton rad = (RadioButton)sender;
        if (rad.IsChecked == true)
        {
            Value = Convert.ToInt16(rad.Value.ToString());
        }
    }

    public Likert()
	{
		InitializeComponent();
		
	}
}