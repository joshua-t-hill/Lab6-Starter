using Lab6_Starter.Model;

namespace Lab6_Starter;

public partial class RoutingStrategies : ContentPage
{
    public int MaxDist {get; set;}
    public bool Visited { get; set;}
    public Airport StartingAirport { get; set;}
    public RoutingStrategies()
    {
        InitializeComponent();
        //BindingContext = MauiProgram.BusinessLogic;
    }

    void MaxDist_OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }

    void StartingAirport_OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }

}

