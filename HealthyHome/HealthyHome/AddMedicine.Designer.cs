namespace HealthyHome
{
    partial class AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicine));
            this.MTRpnlMedicine = new MetroFramework.Controls.MetroPanel();
            this.MTRbtnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.MTRchkMorning = new MetroFramework.Controls.MetroCheckBox();
            this.MTRchkDay = new MetroFramework.Controls.MetroCheckBox();
            this.MTRchkNight = new MetroFramework.Controls.MetroCheckBox();
            this.MTRtxtMedName = new MetroFramework.Controls.MetroTextBox();
            this.MTRtxtMedPrice = new MetroFramework.Controls.MetroTextBox();
            this.MTRtxtMedCount = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MTRpnlMedicine.SuspendLayout();
            this.SuspendLayout();
            // 
            // MTRpnlMedicine
            // 
            this.MTRpnlMedicine.Controls.Add(this.panel1);
            this.MTRpnlMedicine.Controls.Add(this.MTRtxtMedCount);
            this.MTRpnlMedicine.Controls.Add(this.MTRtxtMedPrice);
            this.MTRpnlMedicine.Controls.Add(this.MTRtxtMedName);
            this.MTRpnlMedicine.Controls.Add(this.MTRchkNight);
            this.MTRpnlMedicine.Controls.Add(this.MTRchkDay);
            this.MTRpnlMedicine.Controls.Add(this.MTRchkMorning);
            this.MTRpnlMedicine.Controls.Add(this.metroLabel4);
            this.MTRpnlMedicine.Controls.Add(this.metroLabel3);
            this.MTRpnlMedicine.Controls.Add(this.metroLabel2);
            this.MTRpnlMedicine.Controls.Add(this.metroLabel1);
            this.MTRpnlMedicine.Controls.Add(this.MTRbtnSave);
            this.MTRpnlMedicine.HorizontalScrollbarBarColor = true;
            this.MTRpnlMedicine.HorizontalScrollbarHighlightOnWheel = false;
            this.MTRpnlMedicine.HorizontalScrollbarSize = 10;
            this.MTRpnlMedicine.Location = new System.Drawing.Point(9, 64);
            this.MTRpnlMedicine.Name = "MTRpnlMedicine";
            this.MTRpnlMedicine.Size = new System.Drawing.Size(396, 416);
            this.MTRpnlMedicine.TabIndex = 0;
            this.MTRpnlMedicine.VerticalScrollbarBarColor = true;
            this.MTRpnlMedicine.VerticalScrollbarHighlightOnWheel = false;
            this.MTRpnlMedicine.VerticalScrollbarSize = 10;
            // 
            // MTRbtnSave
            // 
            this.MTRbtnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.MTRbtnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MTRbtnSave.Location = new System.Drawing.Point(95, 280);
            this.MTRbtnSave.Name = "MTRbtnSave";
            this.MTRbtnSave.Size = new System.Drawing.Size(200, 89);
            this.MTRbtnSave.TabIndex = 2;
            this.MTRbtnSave.Text = "Save";
            this.MTRbtnSave.UseCustomBackColor = true;
            this.MTRbtnSave.UseSelectable = true;
            this.MTRbtnSave.Click += new System.EventHandler(this.MTRbtnSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Name :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Price :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 166);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Count :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 208);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Alarm : ";
            // 
            // MTRchkMorning
            // 
            this.MTRchkMorning.AutoSize = true;
            this.MTRchkMorning.Location = new System.Drawing.Point(106, 212);
            this.MTRchkMorning.Name = "MTRchkMorning";
            this.MTRchkMorning.Size = new System.Drawing.Size(62, 15);
            this.MTRchkMorning.TabIndex = 7;
            this.MTRchkMorning.Text = "Mornig";
            this.MTRchkMorning.UseSelectable = true;
            // 
            // MTRchkDay
            // 
            this.MTRchkDay.AutoSize = true;
            this.MTRchkDay.Location = new System.Drawing.Point(201, 212);
            this.MTRchkDay.Name = "MTRchkDay";
            this.MTRchkDay.Size = new System.Drawing.Size(43, 15);
            this.MTRchkDay.TabIndex = 8;
            this.MTRchkDay.Text = "Day";
            this.MTRchkDay.UseSelectable = true;
            // 
            // MTRchkNight
            // 
            this.MTRchkNight.AutoSize = true;
            this.MTRchkNight.Location = new System.Drawing.Point(269, 212);
            this.MTRchkNight.Name = "MTRchkNight";
            this.MTRchkNight.Size = new System.Drawing.Size(53, 15);
            this.MTRchkNight.TabIndex = 9;
            this.MTRchkNight.Text = "NIght";
            this.MTRchkNight.UseSelectable = true;
            // 
            // MTRtxtMedName
            // 
            // 
            // 
            // 
            this.MTRtxtMedName.CustomButton.Image = null;
            this.MTRtxtMedName.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.MTRtxtMedName.CustomButton.Name = "";
            this.MTRtxtMedName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MTRtxtMedName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTRtxtMedName.CustomButton.TabIndex = 1;
            this.MTRtxtMedName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTRtxtMedName.CustomButton.UseSelectable = true;
            this.MTRtxtMedName.CustomButton.Visible = false;
            this.MTRtxtMedName.Lines = new string[0];
            this.MTRtxtMedName.Location = new System.Drawing.Point(84, 93);
            this.MTRtxtMedName.MaxLength = 32767;
            this.MTRtxtMedName.Name = "MTRtxtMedName";
            this.MTRtxtMedName.PasswordChar = '\0';
            this.MTRtxtMedName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTRtxtMedName.SelectedText = "";
            this.MTRtxtMedName.SelectionLength = 0;
            this.MTRtxtMedName.SelectionStart = 0;
            this.MTRtxtMedName.ShortcutsEnabled = true;
            this.MTRtxtMedName.Size = new System.Drawing.Size(199, 23);
            this.MTRtxtMedName.TabIndex = 10;
            this.MTRtxtMedName.UseSelectable = true;
            this.MTRtxtMedName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTRtxtMedName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MTRtxtMedPrice
            // 
            // 
            // 
            // 
            this.MTRtxtMedPrice.CustomButton.Image = null;
            this.MTRtxtMedPrice.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.MTRtxtMedPrice.CustomButton.Name = "";
            this.MTRtxtMedPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MTRtxtMedPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTRtxtMedPrice.CustomButton.TabIndex = 1;
            this.MTRtxtMedPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTRtxtMedPrice.CustomButton.UseSelectable = true;
            this.MTRtxtMedPrice.CustomButton.Visible = false;
            this.MTRtxtMedPrice.Lines = new string[0];
            this.MTRtxtMedPrice.Location = new System.Drawing.Point(84, 130);
            this.MTRtxtMedPrice.MaxLength = 32767;
            this.MTRtxtMedPrice.Name = "MTRtxtMedPrice";
            this.MTRtxtMedPrice.PasswordChar = '\0';
            this.MTRtxtMedPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTRtxtMedPrice.SelectedText = "";
            this.MTRtxtMedPrice.SelectionLength = 0;
            this.MTRtxtMedPrice.SelectionStart = 0;
            this.MTRtxtMedPrice.ShortcutsEnabled = true;
            this.MTRtxtMedPrice.Size = new System.Drawing.Size(199, 23);
            this.MTRtxtMedPrice.TabIndex = 11;
            this.MTRtxtMedPrice.UseSelectable = true;
            this.MTRtxtMedPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTRtxtMedPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MTRtxtMedCount
            // 
            // 
            // 
            // 
            this.MTRtxtMedCount.CustomButton.Image = null;
            this.MTRtxtMedCount.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.MTRtxtMedCount.CustomButton.Name = "";
            this.MTRtxtMedCount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MTRtxtMedCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTRtxtMedCount.CustomButton.TabIndex = 1;
            this.MTRtxtMedCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTRtxtMedCount.CustomButton.UseSelectable = true;
            this.MTRtxtMedCount.CustomButton.Visible = false;
            this.MTRtxtMedCount.Lines = new string[0];
            this.MTRtxtMedCount.Location = new System.Drawing.Point(84, 166);
            this.MTRtxtMedCount.MaxLength = 32767;
            this.MTRtxtMedCount.Name = "MTRtxtMedCount";
            this.MTRtxtMedCount.PasswordChar = '\0';
            this.MTRtxtMedCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTRtxtMedCount.SelectedText = "";
            this.MTRtxtMedCount.SelectionLength = 0;
            this.MTRtxtMedCount.SelectionStart = 0;
            this.MTRtxtMedCount.ShortcutsEnabled = true;
            this.MTRtxtMedCount.Size = new System.Drawing.Size(199, 23);
            this.MTRtxtMedCount.TabIndex = 12;
            this.MTRtxtMedCount.UseSelectable = true;
            this.MTRtxtMedCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTRtxtMedCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(25, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 55);
            this.panel1.TabIndex = 13;
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 494);
            this.Controls.Add(this.MTRpnlMedicine);
            this.Name = "AddMedicine";
            this.Text = "Medicine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMedicine_FormClosing);
            this.MTRpnlMedicine.ResumeLayout(false);
            this.MTRpnlMedicine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel MTRpnlMedicine;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton MTRbtnSave;
        private MetroFramework.Controls.MetroCheckBox MTRchkNight;
        private MetroFramework.Controls.MetroCheckBox MTRchkDay;
        private MetroFramework.Controls.MetroCheckBox MTRchkMorning;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox MTRtxtMedName;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox MTRtxtMedCount;
        private MetroFramework.Controls.MetroTextBox MTRtxtMedPrice;
    }
}