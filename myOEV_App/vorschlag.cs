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
        public Transport t = new Transport();
        public AutoCompleteStringCollection GetStation(string query)
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            Stations stations = new Stations();
            stations = t.GetStations(query);

            foreach (Station s in stations.StationList)
            {
                acsc.Add(s.Name);               

            }
            return acsc;
        }
    }
}
