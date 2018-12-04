namespace myOEV_App
{
    partial class MainGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGui));
            this.lbl_Abfahrt = new System.Windows.Forms.Label();
            this.lbl_Ankunft = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Abfahrt = new System.Windows.Forms.ComboBox();
            this.cmb_Ankunft = new System.Windows.Forms.ComboBox();
            this.tab_Panel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_searchmap = new System.Windows.Forms.Button();
            this.dtp_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.lst_Fahrplan = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_searchmapstation = new System.Windows.Forms.Button();
            this.lst_Station = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Station = new System.Windows.Forms.ComboBox();
            this.btn_Search2 = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.tab_Panel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Abfahrt
            // 
            this.lbl_Abfahrt.AutoSize = true;
            this.lbl_Abfahrt.ForeColor = System.Drawing.Color.Black;
            this.lbl_Abfahrt.Location = new System.Drawing.Point(15, 9);
            this.lbl_Abfahrt.Name = "lbl_Abfahrt";
            this.lbl_Abfahrt.Size = new System.Drawing.Size(93, 20);
            this.lbl_Abfahrt.TabIndex = 0;
            this.lbl_Abfahrt.Text = "Abfahrtsort:";
            // 
            // lbl_Ankunft
            // 
            this.lbl_Ankunft.AutoSize = true;
            this.lbl_Ankunft.ForeColor = System.Drawing.Color.Black;
            this.lbl_Ankunft.Location = new System.Drawing.Point(306, 9);
            this.lbl_Ankunft.Name = "lbl_Ankunft";
            this.lbl_Ankunft.Size = new System.Drawing.Size(96, 20);
            this.lbl_Ankunft.TabIndex = 1;
            this.lbl_Ankunft.Text = "Ankunftsort:";
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Location = new System.Drawing.Point(537, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(79, 40);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_Abfahrt
            // 
            this.cmb_Abfahrt.BackColor = System.Drawing.Color.White;
            this.cmb_Abfahrt.FormattingEnabled = true;
            this.cmb_Abfahrt.Location = new System.Drawing.Point(19, 43);
            this.cmb_Abfahrt.Name = "cmb_Abfahrt";
            this.cmb_Abfahrt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Abfahrt.Size = new System.Drawing.Size(215, 28);
            this.cmb_Abfahrt.TabIndex = 1;
            this.cmb_Abfahrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Abfahrt_KeyDown);
            // 
            // cmb_Ankunft
            // 
            this.cmb_Ankunft.FormattingEnabled = true;
            this.cmb_Ankunft.Location = new System.Drawing.Point(298, 43);
            this.cmb_Ankunft.Name = "cmb_Ankunft";
            this.cmb_Ankunft.Size = new System.Drawing.Size(215, 28);
            this.cmb_Ankunft.TabIndex = 2;
            this.cmb_Ankunft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Ankunft_KeyDown);
            // 
            // tab_Panel
            // 
            this.tab_Panel.Controls.Add(this.tabPage1);
            this.tab_Panel.Controls.Add(this.tabPage2);
            this.tab_Panel.Location = new System.Drawing.Point(12, 12);
            this.tab_Panel.Name = "tab_Panel";
            this.tab_Panel.SelectedIndex = 0;
            this.tab_Panel.Size = new System.Drawing.Size(634, 468);
            this.tab_Panel.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btn_searchmap);
            this.tabPage1.Controls.Add(this.dtp_DatePicker);
            this.tabPage1.Controls.Add(this.lst_Fahrplan);
            this.tabPage1.Controls.Add(this.btn_Search);
            this.tabPage1.Controls.Add(this.cmb_Abfahrt);
            this.tabPage1.Controls.Add(this.lbl_Ankunft);
            this.tabPage1.Controls.Add(this.cmb_Ankunft);
            this.tabPage1.Controls.Add(this.lbl_Abfahrt);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btn_searchmap
            // 
            this.btn_searchmap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_searchmap.BackgroundImage")));
            this.btn_searchmap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_searchmap.Location = new System.Drawing.Point(537, 55);
            this.btn_searchmap.Name = "btn_searchmap";
            this.btn_searchmap.Size = new System.Drawing.Size(79, 40);
            this.btn_searchmap.TabIndex = 5;
            this.btn_searchmap.UseVisualStyleBackColor = true;
            this.btn_searchmap.Click += new System.EventHandler(this.btn_searchmap_Click);
            // 
            // dtp_DatePicker
            // 
            this.dtp_DatePicker.Location = new System.Drawing.Point(19, 78);
            this.dtp_DatePicker.Name = "dtp_DatePicker";
            this.dtp_DatePicker.Size = new System.Drawing.Size(215, 26);
            this.dtp_DatePicker.TabIndex = 3;
            // 
            // lst_Fahrplan
            // 
            this.lst_Fahrplan.Location = new System.Drawing.Point(19, 110);
            this.lst_Fahrplan.Name = "lst_Fahrplan";
            this.lst_Fahrplan.Size = new System.Drawing.Size(597, 295);
            this.lst_Fahrplan.TabIndex = 0;
            this.lst_Fahrplan.UseCompatibleStateImageBehavior = false;
            this.lst_Fahrplan.View = System.Windows.Forms.View.Details;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_searchmapstation);
            this.tabPage2.Controls.Add(this.lst_Station);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmb_Station);
            this.tabPage2.Controls.Add(this.btn_Search2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_searchmapstation
            // 
            this.btn_searchmapstation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_searchmapstation.BackgroundImage")));
            this.btn_searchmapstation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_searchmapstation.Location = new System.Drawing.Point(357, 35);
            this.btn_searchmapstation.Name = "btn_searchmapstation";
            this.btn_searchmapstation.Size = new System.Drawing.Size(79, 40);
            this.btn_searchmapstation.TabIndex = 3;
            this.btn_searchmapstation.UseVisualStyleBackColor = true;
            this.btn_searchmapstation.Click += new System.EventHandler(this.btn_searchmapstation_Click);
            // 
            // lst_Station
            // 
            this.lst_Station.BackColor = System.Drawing.Color.LightYellow;
            this.lst_Station.Location = new System.Drawing.Point(18, 81);
            this.lst_Station.Name = "lst_Station";
            this.lst_Station.Size = new System.Drawing.Size(597, 332);
            this.lst_Station.TabIndex = 9;
            this.lst_Station.UseCompatibleStateImageBehavior = false;
            this.lst_Station.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Station:";
            // 
            // cmb_Station
            // 
            this.cmb_Station.AllowDrop = true;
            this.cmb_Station.BackColor = System.Drawing.Color.White;
            this.cmb_Station.FormattingEnabled = true;
            this.cmb_Station.Location = new System.Drawing.Point(18, 42);
            this.cmb_Station.Name = "cmb_Station";
            this.cmb_Station.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Station.Size = new System.Drawing.Size(215, 28);
            this.cmb_Station.TabIndex = 1;
            this.cmb_Station.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Station_KeyDown);
            // 
            // btn_Search2
            // 
            this.btn_Search2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search2.BackgroundImage")));
            this.btn_Search2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search2.Location = new System.Drawing.Point(263, 35);
            this.btn_Search2.Name = "btn_Search2";
            this.btn_Search2.Size = new System.Drawing.Size(79, 40);
            this.btn_Search2.TabIndex = 2;
            this.btn_Search2.UseVisualStyleBackColor = true;
            this.btn_Search2.Click += new System.EventHandler(this.btn_Search2_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Location = new System.Drawing.Point(543, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(96, 32);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Beenden";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 495);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tab_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGui";
            this.Text = "myÖV";
            this.Load += new System.EventHandler(this.MainGui_Load);
            this.tab_Panel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Abfahrt;
        private System.Windows.Forms.Label lbl_Ankunft;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_Ankunft;
        private System.Windows.Forms.TabControl tab_Panel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lst_Fahrplan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Station;
        private System.Windows.Forms.Button btn_Search2;
        private System.Windows.Forms.ListView lst_Station;
        private System.Windows.Forms.ComboBox cmb_Abfahrt;
        private System.Windows.Forms.DateTimePicker dtp_DatePicker;
        private System.Windows.Forms.Button btn_searchmap;
        private System.Windows.Forms.Button btn_searchmapstation;
        private System.Windows.Forms.Button btn_close;
    }
}

