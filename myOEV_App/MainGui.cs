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
        public MainGui()
        {
            InitializeComponent();
        }

        private void MainGui_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
            tabPage1.Text = "Fahrplan";
            tabPage2.Text = "Abfahrtstafel";
            tabPage2.BackColor = Color.LightYellow;

            lst_Fahrplan.View = View.Details;
            lst_Fahrplan.Columns.Add("Gleis", lst_Fahrplan.Size.Width / 4);
            lst_Fahrplan.Columns.Add("Abfahrt um", lst_Fahrplan.Size.Width / 4);
            lst_Fahrplan.Columns.Add("Reisedauer", lst_Fahrplan.Size.Width / 4);
            lst_Fahrplan.Columns.Add("Ankunft", lst_Fahrplan.Size.Width / 4);
            


        }

        private void cmb_Abfahrt_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode != Keys.Enter)
                return;

            var input = cmb_Abfahrt.Text;
            Vorschlag vorschlag = new Vorschlag();
            List<Station> stations = vorschlag.Searchstation((string)input);

            foreach(Station element in stations)
            {
                cmb_Abfahrt.Items.Add(element.Name);
            }

            
        }

        private void cmb_Ankunft_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            var input = cmb_Ankunft.Text;
            Vorschlag vorschlag = new Vorschlag();
            List<Station> stations = vorschlag.Searchstation((string)input);

            foreach(Station element in stations)
            {
                cmb_Ankunft.Items.Add(element.Name);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            lst_Fahrplan.Items.Clear();
            Station depstation = new Station();
            Station arrstation = new Station();
            Vorschlag vorschlag = new Vorschlag();
            ITransport transport = new Transport();
            Connections connections;

            if(!vorschlag.Stationavailable(cmb_Abfahrt.Text))
            {
                cmb_Abfahrt.Text = "Station nicht gefunden!";
                cmb_Abfahrt.ForeColor = Color.Red;
            }
            else
            {
                cmb_Abfahrt.ForeColor = Color.Black;
            }
            if (!vorschlag.Stationavailable(cmb_Ankunft.Text))
            {
                cmb_Ankunft.Text = "Station nicht gefunden!";
                cmb_Ankunft.ForeColor = Color.Red;
            }
            else
            {
                cmb_Ankunft.ForeColor = Color.Black;
            }
            connections = transport.GetConnections(cmb_Abfahrt.Text, cmb_Ankunft.Text);

            foreach(Connection item in connections.ConnectionList)
            {
                
                string[] items = { item.To.Platform, item.From.Departure, item.Duration, item.To.Arrival};
                lst_Fahrplan.Items.Add(new ListViewItem(items));                
            }

        }

       
        
       
    }
}
