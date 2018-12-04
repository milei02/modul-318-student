using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, DateTime dateTime, string toStattion);

        //Connections GetConnections(string fromStation, DateTime dateTime, string toStattion);

    }
}