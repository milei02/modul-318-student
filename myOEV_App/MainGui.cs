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
            txt_Abfahrt.AutoCompleteCustomSource = allowedTypes;
            txt_Abfahrt.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Abfahrt.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void txt_abfahrt_TextChanged(object sender, EventArgs e)
        {
            //textbox als sender
           TextBox akttxt = new TextBox();
            //Autocomplete mit Funtktion
            akttxt.AutoCompleteCustomSource = v.GetStation(txt_Abfahrt.Text); 
        }

    }
}
