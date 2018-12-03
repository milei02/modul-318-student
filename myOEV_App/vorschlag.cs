using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;


namespace myOEV_App
{
    class Vorschlag
    {
 
        /*Create a List of with the Stations an search with a value named input*/
        public List<Station> Searchstation (string input)
        {
            ITransport transport = new Transport();
            return transport.GetStations(input).StationList;
        }


        public bool Stationavailable (string station)
        {
            
            List<Station> stations = this.Searchstation(station);

            if(stations.Count > 0)
                return true;

            return false;           
        }

        public Station Findstation (string name)
        {
            return Searchstation(name).First<Station>();
        }


        
    }
}
