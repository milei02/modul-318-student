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
            this.txt_Abfahrt = new System.Windows.Forms.TextBox();
            this.txt_Ankunft = new System.Windows.Forms.TextBox();
            this.lst_Fahrplan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_Abfahrt
            // 
            this.lbl_Abfahrt.AutoSize = true;
            this.lbl_Abfahrt.Location = new System.Drawing.Point(12, 33);
            this.lbl_Abfahrt.Name = "lbl_Abfahrt";
            this.lbl_Abfahrt.Size = new System.Drawing.Size(93, 20);
            this.lbl_Abfahrt.TabIndex = 0;
            this.lbl_Abfahrt.Text = "Abfahrtsort:";
            // 
            // lbl_Ankunft
            // 
            this.lbl_Ankunft.AutoSize = true;
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
            // txt_Abfahrt
            // 
            this.txt_Abfahrt.Location = new System.Drawing.Point(16, 68);
            this.txt_Abfahrt.Name = "txt_Abfahrt";
            this.txt_Abfahrt.Size = new System.Drawing.Size(212, 26);
            this.txt_Abfahrt.TabIndex = 3;
            this.txt_Abfahrt.TextChanged += new System.EventHandler(this.txt_abfahrt_TextChanged);
            // 
            // txt_Ankunft
            // 
            this.txt_Ankunft.Location = new System.Drawing.Point(332, 68);
            this.txt_Ankunft.Name = "txt_Ankunft";
            this.txt_Ankunft.Size = new System.Drawing.Size(212, 26);
            this.txt_Ankunft.TabIndex = 4;
            // 
            // lst_Fahrplan
            // 
            this.lst_Fahrplan.FormattingEnabled = true;
            this.lst_Fahrplan.ItemHeight = 20;
            this.lst_Fahrplan.Location = new System.Drawing.Point(16, 125);
            this.lst_Fahrplan.Name = "lst_Fahrplan";
            this.lst_Fahrplan.Size = new System.Drawing.Size(533, 344);
            this.lst_Fahrplan.TabIndex = 5;
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 503);
            this.Controls.Add(this.lst_Fahrplan);
            this.Controls.Add(this.txt_Ankunft);
            this.Controls.Add(this.txt_Abfahrt);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_Ankunft);
            this.Controls.Add(this.lbl_Abfahrt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGui";
            this.Text = "myÖV";
            this.Load += new System.EventHandler(this.MainGui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Abfahrt;
        private System.Windows.Forms.Label lbl_Ankunft;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Abfahrt;
        private System.Windows.Forms.TextBox txt_Ankunft;
        private System.Windows.Forms.ListBox lst_Fahrplan;
    }
}

