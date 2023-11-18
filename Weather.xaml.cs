using Lab2_Solution.Model;

namespace Lab6_Starter;

public partial class Weather : ContentPage
{
    private readonly Meteorologist meteorologist = new("KATW"); //passing KATW as airport ID for testing
    public Weather()
    {
        InitializeComponent();

        Console.WriteLine(meteorologist.MetarReport);
        Console.WriteLine(meteorologist.TafReport);
    }

   
}


