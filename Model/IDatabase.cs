using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lab6_Starter.Model
{
    public interface IDatabase
    {
        ObservableCollection<Airport> SelectAllAirports();
        Airport SelectAirport(String id);
        AirportAdditionError InsertAirport(Airport airport);
        AirportDeletionError DeleteAirport(Airport airport);
        AirportEditError UpdateAirport(Airport replacementAirport);

        //***changes from group 5***
        ObservableCollection<Airport> GetAllWisconsinAirports();
        //***changes from group 5***
    }
}