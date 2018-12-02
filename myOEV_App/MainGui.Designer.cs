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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Abfahrt
            // 
            this.lbl_Abfahrt.AutoSize = true;
            this.lbl_Abfahrt.ForeColor = System.Drawing.Color.Black;
            this.lbl_Abfahrt.Location = new System.Drawing.Point(12, 33);
            this.lbl_Abfahrt.Name = "lbl_Abfahrt";
            this.lbl_Abfahrt.Size = new System.Drawing.Size(93, 20);
            this.lbl_Abfahrt.TabIndex = 0;
            this.lbl_Abfahrt.Text = "Abfahrtsort:";
            // 
            // lbl_Ankunft
            // 
            this.lbl_Ankunft.AutoSize = true;
            this.lbl_Ankunft.ForeColor = System.Drawing.Color.Black;
            this.lbl_Ankunft.Location = new System.Drawing.Point(328, 33);
            this.lbl_Ankunft.Name = "lbl_Ankunft";
            this.lbl_Ankunft.Size = new System.Drawing.Size(96, 20);
            this.lbl_Ankunft.TabIndex = 1;
            this.lbl_Ankunft.Text = "Ankunftsort:";
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Location = new System.Drawing.Point(563, 61);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(79, 40);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // cmb_Abfahrt
            // 
            this.cmb_Abfahrt.BackColor = System.Drawing.Color.White;
            this.cmb_Abfahrt.FormattingEnabled = true;
            this.cmb_Abfahrt.Location = new System.Drawing.Point(16, 73);
            this.cmb_Abfahrt.Name = "cmb_Abfahrt";
            this.cmb_Abfahrt.Size = new System.Drawing.Size(215, 28);
            this.cmb_Abfahrt.TabIndex = 6;
            this.cmb_Abfahrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Abfahrt_KeyDown);
            // 
            // cmb_Ankunft
            // 
            this.cmb_Ankunft.FormattingEnabled = true;
            this.cmb_Ankunft.Location = new System.Drawing.Point(332, 73);
            this.cmb_Ankunft.Name = "cmb_Ankunft";
            this.cmb_Ankunft.Size = new System.Drawing.Size(215, 28);
            this.cmb_Ankunft.TabIndex = 7;
            this.cmb_Ankunft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Ankunft_KeyDown);
            // 
            // tab_Panel
            // 
            this.tab_Panel.Controls.Add(this.tabPage1);
            this.tab_Panel.Controls.Add(this.tabPage2);
            this.tab_Panel.Location = new System.Drawing.Point(16, 117);
            this.tab_Panel.Name = "tab_Panel";
            this.tab_Panel.SelectedIndex = 0;
            this.tab_Panel.Size = new System.Drawing.Size(540, 339);
            this.tab_Panel.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 503);
            this.Controls.Add(this.tab_Panel);
            this.Controls.Add(this.cmb_Ankunft);
            this.Controls.Add(this.cmb_Abfahrt);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_Ankunft);
            this.Controls.Add(this.lbl_Abfahrt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGui";
            this.Text = "myÖV";
            this.Load += new System.EventHandler(this.MainGui_Load);
            this.tab_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Abfahrt;
        private System.Windows.Forms.Label lbl_Ankunft;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_Abfahrt;
        private System.Windows.Forms.ComboBox cmb_Ankunft;
        private System.Windows.Forms.TabControl tab_Panel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

