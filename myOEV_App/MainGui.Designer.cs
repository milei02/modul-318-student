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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lst_Fahrplan = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lst_Station = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Station = new System.Windows.Forms.ComboBox();
            this.btn_Search2 = new System.Windows.Forms.Button();
            this.dtp_DatePicker = new System.Windows.Forms.DateTimePicker();
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
            this.btn_Search.Location = new System.Drawing.Point(537, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(79, 40);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_Abfahrt
            // 
            this.cmb_Abfahrt.AllowDrop = true;
            this.cmb_Abfahrt.BackColor = System.Drawing.Color.White;
            this.cmb_Abfahrt.FormattingEnabled = true;
            this.cmb_Abfahrt.Location = new System.Drawing.Point(19, 43);
            this.cmb_Abfahrt.Name = "cmb_Abfahrt";
            this.cmb_Abfahrt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Abfahrt.Size = new System.Drawing.Size(215, 28);
            this.cmb_Abfahrt.TabIndex = 6;
            this.cmb_Abfahrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Abfahrt_KeyDown);
            // 
            // cmb_Ankunft
            // 
            this.cmb_Ankunft.FormattingEnabled = true;
            this.cmb_Ankunft.Location = new System.Drawing.Point(298, 43);
            this.cmb_Ankunft.Name = "cmb_Ankunft";
            this.cmb_Ankunft.Size = new System.Drawing.Size(215, 28);
            this.cmb_Ankunft.TabIndex = 7;
            this.cmb_Ankunft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Ankunft_KeyDown);
            // 
            // tab_Panel
            // 
            this.tab_Panel.Controls.Add(this.tabPage1);
            this.tab_Panel.Controls.Add(this.tabPage2);
            this.tab_Panel.Location = new System.Drawing.Point(16, 12);
            this.tab_Panel.Name = "tab_Panel";
            this.tab_Panel.SelectedIndex = 0;
            this.tab_Panel.Size = new System.Drawing.Size(1237, 468);
            this.tab_Panel.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.dtp_DatePicker);
            this.tabPage1.Controls.Add(this.webBrowser1);
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
            this.tabPage1.Size = new System.Drawing.Size(1229, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(638, 43);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(574, 362);
            this.webBrowser1.TabIndex = 8;
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
            this.tabPage2.Controls.Add(this.lst_Station);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmb_Station);
            this.tabPage2.Controls.Add(this.btn_Search2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1229, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.cmb_Station.TabIndex = 7;
            this.cmb_Station.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Station_KeyDown);
            // 
            // btn_Search2
            // 
            this.btn_Search2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search2.BackgroundImage")));
            this.btn_Search2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search2.Location = new System.Drawing.Point(263, 35);
            this.btn_Search2.Name = "btn_Search2";
            this.btn_Search2.Size = new System.Drawing.Size(79, 40);
            this.btn_Search2.TabIndex = 3;
            this.btn_Search2.UseVisualStyleBackColor = true;
            this.btn_Search2.Click += new System.EventHandler(this.btn_Search2_Click);
            // 
            // dtp_DatePicker
            // 
            this.dtp_DatePicker.Location = new System.Drawing.Point(19, 78);
            this.dtp_DatePicker.Name = "dtp_DatePicker";
            this.dtp_DatePicker.Size = new System.Drawing.Size(215, 26);
            this.dtp_DatePicker.TabIndex = 9;
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 481);
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
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Station;
        private System.Windows.Forms.Button btn_Search2;
        private System.Windows.Forms.ListView lst_Station;
        private System.Windows.Forms.ComboBox cmb_Abfahrt;
        private System.Windows.Forms.DateTimePicker dtp_DatePicker;
    }
}

