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
 
        

            /// <summary>
            /// Hier wird eine List mit de Stationen erstellt, welche gesucht werden.
            /// </summary>
            /// <param name="input"></param>
            /// <returns></returns>
        public List<Station> Searchstation (string input)
        {
            ITransport transport = new Transport();
            return transport.GetStations(input).StationList;
        }

        /// <summary>
        /// Hier wird überprüft ob die Station verfügbar ist. 
        /// </summary>
        /// <param name="station"></param>
        /// <returns></returns>
        public bool Stationavailable (string station)
        {
            
            List<Station> stations = this.Searchstation(station);

            if(stations.Count > 0)
                return true;

            return false;           
        }


        /// <summary>
        /// Hier wird die Station gesucht und in den string "name" gespeichert.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Station Findstation(string name)
        {            
            
                return Searchstation(name).First<Station>();
            

           
        
         
        }



        
    }
}
