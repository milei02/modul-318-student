using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);

        //Hier wurde das DateTime dateTime hinzugefügt, dass dieser Parameter auch mitübergeben wird.
        Connections GetConnections(string fromStation, string toStattion, DateTime dateTime);
        
    }
}