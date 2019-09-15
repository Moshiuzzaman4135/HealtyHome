namespace HealthyHome
{
    partial class SetAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetAlarm));
            this.MTRpnlSetAlamr = new MetroFramework.Controls.MetroPanel();
            this.MTRdtmNight = new MetroFramework.Controls.MetroDateTime();
            this.MTRdtmDay = new MetroFramework.Controls.MetroDateTime();
            this.MTRdtmMorning = new MetroFramework.Controls.MetroDateTime();
            this.MTRbtnSaveAlarm = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MTRpnlSetAlamr.SuspendLayout();
            this.SuspendLayout();
            // 
            // MTRpnlSetAlamr
            // 
            this.MTRpnlSetAlamr.Controls.Add(this.MTRdtmNight);
            this.MTRpnlSetAlamr.Controls.Add(this.MTRdtmDay);
            this.MTRpnlSetAlamr.Controls.Add(this.MTRdtmMorning);
            this.MTRpnlSetAlamr.Controls.Add(this.MTRbtnSaveAlarm);
            this.MTRpnlSetAlamr.Controls.Add(this.metroLabel3);
            this.MTRpnlSetAlamr.Controls.Add(this.metroLabel2);
            this.MTRpnlSetAlamr.Controls.Add(this.metroLabel1);
            this.MTRpnlSetAlamr.HorizontalScrollbarBarColor = true;
            this.MTRpnlSetAlamr.HorizontalScrollbarHighlightOnWheel = false;
            this.MTRpnlSetAlamr.HorizontalScrollbarSize = 10;
            this.MTRpnlSetAlamr.Location = new System.Drawing.Point(24, 141);
            this.MTRpnlSetAlamr.Name = "MTRpnlSetAlamr";
            this.MTRpnlSetAlamr.Size = new System.Drawing.Size(314, 247);
            this.MTRpnlSetAlamr.TabIndex = 0;
            this.MTRpnlSetAlamr.VerticalScrollbarBarColor = true;
            this.MTRpnlSetAlamr.VerticalScrollbarHighlightOnWheel = false;
            this.MTRpnlSetAlamr.VerticalScrollbarSize = 10;
            // 
            // MTRdtmNight
            // 
            this.MTRdtmNight.CustomFormat = "HH:mm:ss";
            this.MTRdtmNight.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MTRdtmNight.Location = new System.Drawing.Point(170, 120);
            this.MTRdtmNight.MinimumSize = new System.Drawing.Size(0, 29);
            this.MTRdtmNight.Name = "MTRdtmNight";
            this.MTRdtmNight.Size = new System.Drawing.Size(94, 29);
            this.MTRdtmNight.TabIndex = 8;
            // 
            // MTRdtmDay
            // 
            this.MTRdtmDay.CustomFormat = "HH:mm:ss";
            this.MTRdtmDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MTRdtmDay.Location = new System.Drawing.Point(170, 72);
            this.MTRdtmDay.MinimumSize = new System.Drawing.Size(0, 29);
            this.MTRdtmDay.Name = "MTRdtmDay";
            this.MTRdtmDay.Size = new System.Drawing.Size(94, 29);
            this.MTRdtmDay.TabIndex = 7;
            // 
            // MTRdtmMorning
            // 
            this.MTRdtmMorning.CustomFormat = "HH:mm:ss";
            this.MTRdtmMorning.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MTRdtmMorning.Location = new System.Drawing.Point(170, 22);
            this.MTRdtmMorning.MinimumSize = new System.Drawing.Size(0, 29);
            this.MTRdtmMorning.Name = "MTRdtmMorning";
            this.MTRdtmMorning.Size = new System.Drawing.Size(94, 29);
            this.MTRdtmMorning.TabIndex = 6;
            // 
            // MTRbtnSaveAlarm
            // 
            this.MTRbtnSaveAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MTRbtnSaveAlarm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MTRbtnSaveAlarm.BackgroundImage")));
            this.MTRbtnSaveAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MTRbtnSaveAlarm.Location = new System.Drawing.Point(83, 187);
            this.MTRbtnSaveAlarm.Name = "MTRbtnSaveAlarm";
            this.MTRbtnSaveAlarm.Size = new System.Drawing.Size(132, 48);
            this.MTRbtnSaveAlarm.TabIndex = 5;
            this.MTRbtnSaveAlarm.Text = "Save";
            this.MTRbtnSaveAlarm.UseCustomBackColor = true;
            this.MTRbtnSaveAlarm.UseSelectable = true;
            this.MTRbtnSaveAlarm.Click += new System.EventHandler(this.MTRbtnSaveAlarm_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(42, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Morning Alarm : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(110, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Morning Alarm : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Morning Alarm : ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(229, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 97);
            this.panel1.TabIndex = 1;
            // 
            // SetAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MTRpnlSetAlamr);
            this.Name = "SetAlarm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Set Alarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetAlarm_FormClosing);
            this.MTRpnlSetAlamr.ResumeLayout(false);
            this.MTRpnlSetAlamr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel MTRpnlSetAlamr;
        private MetroFramework.Controls.MetroDateTime MTRdtmNight;
        private MetroFramework.Controls.MetroDateTime MTRdtmDay;
        private MetroFramework.Controls.MetroDateTime MTRdtmMorning;
        private MetroFramework.Controls.MetroButton MTRbtnSaveAlarm;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}