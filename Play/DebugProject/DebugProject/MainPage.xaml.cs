namespace DebugProject;
using DebugProject.Models;
public partial class MainPage : ContentPage
{
	int count = 0;
    //create array
    Team[] sportsList = new Team[30];

    public MainPage()
	{
		InitializeComponent();
        CreateSports();
        DisplaySports();
    }
    private void CreateSports()
    {

        //american league central
        sportsList[0] = new Team("White Sox", "Chicago", "American League Central");
        sportsList[1] = new Team("Guardians", "Cleveland", "American League Central");
        sportsList[2] = new Team("Tigers", "Detroit", "American League Central");
        sportsList[3] = new Team("Royals", "Kansas City", "American League Central");
        sportsList[4] = new Team("Twins", "Minnesota", "American League Central");

        //national league cental
        sportsList[5] = new Team("Cubs", "Chicago", "National League Central");
        sportsList[6] = new Team("Reds", "Cincinnati", "National League Central");
        sportsList[7] = new Team("Brewers", "Milwaukee", "National League Central");
        sportsList[8] = new Team("Pirates", "Pittsburgh", "National League Central");
        sportsList[9] = new Team("Cardinals", "St. Louis", "National League Central");

        //amercian league east
        sportsList[10] = new Team("Orioles", "Baltimore", "American League East");
        sportsList[11] = new Team("Red Sox", "Boston", "American League East");
        sportsList[12] = new Team("Yankees", "New York", "American League East");
        sportsList[13] = new Team("Rays", "Tampa Bay", "American League East");
        sportsList[14] = new Team("Blue Jays", "Toronto", "American League East");

        //national league east
        sportsList[15] = new Team("Braves", "Atlanta", "National League East");
        sportsList[16] = new Team("Marlins", "Miami", "National League East");
        sportsList[17] = new Team("Mets", "New York", "National League East");
        sportsList[18] = new Team("Phillies", "Philadelphia", "National League East");
        sportsList[19] = new Team("Nationals", "Washington", "National League East");

        //american league west
        sportsList[20] = new Team("Astros", "Houston", "American League West");
        sportsList[21] = new Team("Angels", "Los Angeles", "American League West");
        sportsList[22] = new Team("Athletics", "Oakland", "American League West");
        sportsList[23] = new Team("Mariners", "Seattle", "American League West");
        sportsList[24] = new Team("Rangers", "Texas", "American League West");

        //national league west
        sportsList[25] = new Team("Diamondbacks", "Arizona", "National League West");
        sportsList[26] = new Team("Rockies", "Colorado", "National League West");
        sportsList[27] = new Team("Dodgers", "Los Angeles", "National League West");
        sportsList[28] = new Team("Padres", "San Diego", "National League West");
        sportsList[29] = new Team("Giants", "San Francisco", "National League West");
    }

    private void DisplaySports()
    {
        for (int i = 0; i < sportsList.Length; i++)
        {
            try
            {
                Label label = new Label();
                label.Text = sportsList[i].teamName + "; " + sportsList[i].cityName + "; " + sportsList[i].leagueName;
                label.Padding = new Thickness(0, 10, 0, 0);
                StackLayout.Add(label);
            }
            catch
            {
                Label label = new Label();
                label.Text = "Unknown";
                label.Padding = new Thickness(0, 10, 0, 0);
                StackLayout.Add(label);
            }
        }
    }

}

