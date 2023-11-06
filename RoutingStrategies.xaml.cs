﻿using Lab6_Starter.Model;
using System.Collections.ObjectModel;

namespace Lab6_Starter;

public partial class RoutingStrategies : ContentPage
{
    ObservableCollection<ObservableCollection<Airport>> routes;
    int maxDist = 60;
    bool visited = true;
    Airport startingAirport = new Airport();
    public ObservableCollection<ObservableCollection<Airport>> Routes { 
        get { return routes; } 
    }
    public RoutingStrategies()
    {
        InitializeComponent();
        //BindingContext = MauiProgram.BusinessLogic;
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

}

