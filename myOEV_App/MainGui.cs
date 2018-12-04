using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myOEV_App
{
    public partial class MainGui : Form
    {
        Vorschlag v = new Vorschlag();
        public string query;
        ITransport transport = new Transport();
        public MainGui()
        {
            InitializeComponent();
        }

        private void MainGui_Load(object sender, EventArgs e)
        {         
            //Die Tabpages werden benannt und die Hintergrundfarben gesetzt.
            tabPage1.Text = "Fahrplan";
            tabPage2.Text = "Abfahrtstafel";
            tabPage2.BackColor = Color.LightYellow;

            //Die erste Listview wird erstellt, damit die Fahrpläne sauber dargestellt werden können.
            lst_Fahrplan.View = View.Details;
            lst_Fahrplan.Columns.Add("Gleis", lst_Fahrplan.Size.Width / 4);
            lst_Fahrplan.Columns.Add("Abfahrt um", lst_Fahrplan.Size.Width / 4);
            lst_Fahrplan.Columns.Add("Reisedauer", lst_Fahrplan.Size.Width / 4);
            lst_Fahrplan.Columns.Add("Ankunft", lst_Fahrplan.Size.Width / 4);
            
            //Die zweite Listview wird erstellt damit das Stationboard sauber dargestellt werden kann.            
            lst_Station.View = View.Details;
            lst_Station.Columns.Add("Nach", lst_Station.Size.Width / 3);
            lst_Station.Columns.Add("Zug/Busnummer", lst_Station.Size.Width / 3);
            lst_Station.Columns.Add("Abfahrt", lst_Station.Size.Width / 3);
        }

        ///Die Automatische Suchfunktion welche in der Combobox die Vorschläge anzeigt. (Für die Abfahrtsstation)
        private void cmb_Abfahrt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)                
            return;
            cmb_Abfahrt.Items.Clear();
            var input = cmb_Abfahrt.Text;
            List<Station> stations = v.Searchstation((string)input);

            try
            {
                foreach (Station element in stations)
                {
                    cmb_Abfahrt.Items.Add(element.Name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Station nicht gefunden / Netzwerkfehler. Bitte versuchen Sie es erneut. Falls das Problem in ein paar Minuten immer noch besteht holen sie sich hilfe.");
            }
            cmb_Abfahrt.DroppedDown = true;
            e.Handled = true;
            
        }

        ///Die Automatische Suchfunktion welche in der Combobox die Vorschläge anzeigt. (Für die Ankunftsstation)
        private void cmb_Ankunft_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            cmb_Ankunft.Items.Clear();

            var input = cmb_Ankunft.Text;            
            List<Station> stations = v.Searchstation((string)input);
            try
            {
                foreach (Station element in stations)
                {
                    cmb_Ankunft.Items.Add(element.Name);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Station nicht gefunden / Netzwerkfehler. Bitte versuchen Sie es erneut. Falls das Problem in ein paar Minuten immer noch besteht holen sie sich hilfe.");
            }
            cmb_Ankunft.DroppedDown = true;
            e.Handled = true;
        }

        //Mit diesem Knopf werden die Stationen gesucht. 
        private void btn_Search_Click(object sender, EventArgs e)
        {  
            lst_Fahrplan.Items.Clear();
            Station depstation = new Station();
            Station arrstation = new Station();


            
                //Hier wird überprüft ob die einzelnen Stationen verfügbar sind
                if (!v.Stationavailable(cmb_Abfahrt.Text))
                {
                    cmb_Abfahrt.Text = "Station nicht gefunden!";

                }
                if (!v.Stationavailable(cmb_Ankunft.Text))
                {
                    cmb_Ankunft.Text = "Station nicht gefunden!";

                }
            
         

            
            Connections connections;
            
            DateTime dateTime = dtp_DatePicker.Value.Date;
            dateTime += dtp_DatePicker.Value.TimeOfDay;
            
            

            //Hier wird geschaut ob der Request von dre API ankommt und ein Resultat zurückliefert. Falls nicht wird eine Fehlermeldung angezeigt.
            try
            {
                //dateTime hinzufügen
                connections = transport.GetConnections(cmb_Abfahrt.Text, cmb_Ankunft.Text, dateTime);
                
                                
                foreach (Connection item in connections.ConnectionList)
                {

                    string[] items = { item.To.Platform, item.From.Departure.Remove(0, 11), item.Duration.Remove(0, 3), item.To.Arrival.Remove(0, 11) };
                    lst_Fahrplan.Items.Add(new ListViewItem(items));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Station nicht gefunden / Netzwerkfehler. Bitte versuchen Sie es erneut. Falls das Problem in ein paar Minuten immer noch besteht holen sie sich hilfe.");
            }

            

        }


        /////Die Automatische Suchfunktion welche in der Combobox die Vorschläge anzeigt. (Für die Station im Stationboard)
        private void cmb_Station_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            cmb_Station.Items.Clear();

            var input = cmb_Station.Text;
            List<Station> stations = v.Searchstation((string)input);

            foreach (Station element in stations)
            {                
                cmb_Station.Items.Add(element.Name);
            }
            
            cmb_Station.DroppedDown = true;
            e.Handled = true;
        }


        //Hier werden die Stationen gsucht und nachgeschaut ob sie verfügbar sind.
        private void btn_Search2_Click(object sender, EventArgs e)
        {
            lst_Station.Items.Clear();
            
            //Nachgeschaut ob die Station verfügbar ist. Ansonsten gibt es eine Fehlermeldung.
            if (!v.Stationavailable(cmb_Station.Text))
            {
                cmb_Station.Text = "Station nicht verfügbar!";
            }


            try
            {
                Station station = v.Findstation(cmb_Station.Text);
                string id = station.Id;

                foreach (StationBoard element in transport.GetStationBoard(cmb_Station.Text, id).Entries)
                {
                    string[] stationboard = { element.To, element.Number, Convert.ToString(element.Stop.Departure).Remove(0, 10) };
                    lst_Station.Items.Add(new ListViewItem(stationboard));
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("Bitte geben Sie eine gültige Station ein" + Convert.ToString(x));
            }

            
        }

        //Der Standort vom Zielbahnhof wird auf Google Maps angezeigt.
        private void btn_searchmap_Click(object sender, EventArgs e)
        {
            var stat = cmb_Ankunft.Text;
            Station station = v.Findstation(cmb_Ankunft.Text);

            if (!v.Stationavailable(cmb_Station.Text))
            {
                cmb_Abfahrt.Text = "Station nicht gefunden!";

            }
           

            System.Diagnostics.Process.Start("http://www.google.com/maps/place/" + station.Coordinate.XCoordinate.ToString().Replace(",", ".") + "," + station.Coordinate.YCoordinate.ToString().Replace(",","."));
        }

        //Der Standort vom gesuchten Bahnhof wird auf Google Maps angezeit.
        private void btn_searchmapstation_Click(object sender, EventArgs e)
        {
            var station = cmb_Station.Text;
            Station stat = v.Findstation(cmb_Station.Text);

            if (!v.Stationavailable(cmb_Station.Text))
            {
                cmb_Station.Text = "Station nicht gefundne";
            }

            System.Diagnostics.Process.Start("http://www.google.com/maps/place/" + stat.Coordinate.XCoordinate.ToString().Replace(",", ".") + "," + stat.Coordinate.YCoordinate.ToString().Replace(",", "."));
        }

        
    }
}
