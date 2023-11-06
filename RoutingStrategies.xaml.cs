using Lab6_Starter.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Lab6_Starter;

public partial class RoutingStrategies : ContentPage, INotifyPropertyChanged
{
    ObservableCollection<ObservableCollection<Airport>> routes;
    int maxDist = 60;
    bool visited = true;
    Airport startingAirport = new Airport();
    ObservableCollection<Airport> wisconsinAirports = MauiProgram.BusinessLogic.GetAllWisconsinAirports();
    public ObservableCollection<ObservableCollection<Airport>> Routes { 
        get { return routes; } set { 
            routes = value;
            OnPropertyChanged(nameof(Routes));
        }
    }
    public RoutingStrategies()
    {
        InitializeComponent();
    }

    /// <summary>
    /// finds possible routes and updates Routes
    /// from most airports visited to least
    /// </summary>
    void FindRoutes()
    {
        return;
    }
    /// <summary>
    /// sets max distance when finding routes
    /// </summary>
    void MaxDist_OnEntryCompleted(object sender, EventArgs e)
    {
        //string text = ((Entry)sender).Text;
    }
    /// <summary>
    /// sets starting airport when finding routes
    /// </summary>
    void StartingAirport_OnEntryCompleted(object sender, EventArgs e)
    {
        //string text = ((Entry)sender).Text;
    }
    /// <summary>
    /// sets if visited airports should appear in routes
    /// </summary>
    void Visited_OnToggled(object sender, ToggledEventArgs e)
    {
        // Perform an action after examining e.Value
    }
    void DisplayRoute_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //string previous = (e.PreviousSelection.FirstOrDefault() as Monkey)?.Name;
        //string current = (e.CurrentSelection.FirstOrDefault() as Monkey)?.Name;
    }
    public new event PropertyChangedEventHandler PropertyChanged;

    protected new virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}

