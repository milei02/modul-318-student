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
    }
}
