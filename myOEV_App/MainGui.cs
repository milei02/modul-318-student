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
            tabPage1.Text = "Fahrplan";
            tabPage2.Text = "Abfahrtstafel";
            tabPage2.BackColor = Color.LightYellow;
            lst_Fahrplan.View = View.Details;
            lst_Fahrplan.Columns.Add("Gleis", lst_Fahrplan.Size.Width / 4);
            lst_Fahrplan.Columns.Add("Abfahrt um", lst_Fahrplan.Size.Width / 4);
            lst_Fahrplan.Columns.Add("Reisedauer", lst_Fahrplan.Size.Width / 4);
            lst_Fahrplan.Columns.Add("Ankunft", lst_Fahrplan.Size.Width / 4);
            lst_Station.BackColor = Color.LightYellow;
            lst_Station.View = View.Details;
            lst_Station.Columns.Add("Nach", lst_Station.Size.Width / 3);
            lst_Station.Columns.Add("Zug/Busnummer", lst_Station.Size.Width / 3);
            lst_Station.Columns.Add("Abfahrt", lst_Station.Size.Width / 3);
        }

        private void cmb_Abfahrt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            cmb_Abfahrt.Items.Clear();

            var input = cmb_Abfahrt.Text;
            
            List<Station> stations = v.Searchstation((string)input);
            

           
            foreach(Station element in stations)
            {
                    cmb_Abfahrt.Items.Add(element.Name);
                
                
            }
            cmb_Abfahrt.DroppedDown = true;        
        }

        private void cmb_Ankunft_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            cmb_Ankunft.Items.Clear();

            var input = cmb_Ankunft.Text;
            
            List<Station> stations = v.Searchstation((string)input);

            foreach (Station element in stations)
            {
               
                cmb_Ankunft.Items.Add(element.Name);
            }
            cmb_Ankunft.DroppedDown = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {  
            lst_Fahrplan.Items.Clear();
            Station depstation = new Station();
            Station arrstation = new Station();         
            
            

            if(!v.Stationavailable(cmb_Abfahrt.Text))
            {
                cmb_Abfahrt.Text = "Station nicht gefunden!";
                cmb_Abfahrt.ForeColor = Color.Red;
            }
            else
            {
                cmb_Abfahrt.ForeColor = Color.Black;
            }
            if (!v.Stationavailable(cmb_Ankunft.Text))
            {
                cmb_Ankunft.Text = "Station nicht gefunden!";
                cmb_Ankunft.ForeColor = Color.Red;
            }
            else
            {
                cmb_Ankunft.ForeColor = Color.Black;
            }

            Connections connections;

            try
            {
                connections = transport.GetConnections(cmb_Abfahrt.Text, cmb_Ankunft.Text);

                foreach (Connection item in connections.ConnectionList)
                {

                    string[] items = { item.To.Platform, item.From.Departure.Remove(0, 11), item.Duration.Remove(0, 3), item.To.Arrival.Remove(0, 11) };
                    lst_Fahrplan.Items.Add(new ListViewItem(items));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }


        }

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
        }

        private void btn_Search2_Click(object sender, EventArgs e)
        {
            lst_Station.Items.Clear();
            //Check if Station is available
            if (!v.Stationavailable(cmb_Station.Text))
            {
                cmb_Station.Text = "Station nicht verfügbar!";
                cmb_Station.ForeColor = Color.Red;
            }
            else
            {
                cmb_Station.ForeColor = Color.Black;
            }

            Station station = v.Findstation(cmb_Station.Text);
            string id = station.Id;

            foreach(StationBoard element in transport.GetStationBoard(cmb_Station.Text, id).Entries)
            {
                string[] stationboard = { element.To, element.Number, Convert.ToString(element.Stop.Departure).Remove(0, 10) };
                lst_Station.Items.Add(new ListViewItem(stationboard));
            }

            
        }
    }
}
