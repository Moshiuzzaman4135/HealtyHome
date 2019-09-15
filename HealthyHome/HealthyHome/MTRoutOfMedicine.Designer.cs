namespace HealthyHome
{
    partial class MTRoutOfMedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MTRoutOfMedicine));
            this.MTRpnlOutOfMed = new MetroFramework.Controls.MetroPanel();
            this.MTRgrdMedicineInfo = new MetroFramework.Controls.MetroGrid();
            this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.morningAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nightAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTRbtnClose = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.MTRpnlOutOfMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MTRgrdMedicineInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // MTRpnlOutOfMed
            // 
            this.MTRpnlOutOfMed.Controls.Add(this.MTRgrdMedicineInfo);
            this.MTRpnlOutOfMed.Controls.Add(this.MTRbtnClose);
            this.MTRpnlOutOfMed.Controls.Add(this.metroPanel1);
            this.MTRpnlOutOfMed.HorizontalScrollbarBarColor = true;
            this.MTRpnlOutOfMed.HorizontalScrollbarHighlightOnWheel = false;
            this.MTRpnlOutOfMed.HorizontalScrollbarSize = 10;
            this.MTRpnlOutOfMed.Location = new System.Drawing.Point(15, 64);
            this.MTRpnlOutOfMed.Name = "MTRpnlOutOfMed";
            this.MTRpnlOutOfMed.Size = new System.Drawing.Size(536, 568);
            this.MTRpnlOutOfMed.TabIndex = 0;
            this.MTRpnlOutOfMed.VerticalScrollbarBarColor = true;
            this.MTRpnlOutOfMed.VerticalScrollbarHighlightOnWheel = false;
            this.MTRpnlOutOfMed.VerticalScrollbarSize = 10;
            this.MTRpnlOutOfMed.Paint += new System.Windows.Forms.PaintEventHandler(this.MTRpnlOutOfMed_Paint);
            // 
            // MTRgrdMedicineInfo
            // 
            this.MTRgrdMedicineInfo.AllowUserToAddRows = false;
            this.MTRgrdMedicineInfo.AllowUserToDeleteRows = false;
            this.MTRgrdMedicineInfo.AllowUserToResizeRows = false;
            this.MTRgrdMedicineInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MTRgrdMedicineInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTRgrdMedicineInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MTRgrdMedicineInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MTRgrdMedicineInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MTRgrdMedicineInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MTRgrdMedicineInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medName,
            this.price,
            this.count,
            this.morningAlarm,
            this.dayAlarm,
            this.nightAlarm});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MTRgrdMedicineInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.MTRgrdMedicineInfo.EnableHeadersVisualStyles = false;
            this.MTRgrdMedicineInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTRgrdMedicineInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MTRgrdMedicineInfo.Location = new System.Drawing.Point(34, 137);
            this.MTRgrdMedicineInfo.Name = "MTRgrdMedicineInfo";
            this.MTRgrdMedicineInfo.ReadOnly = true;
            this.MTRgrdMedicineInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MTRgrdMedicineInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MTRgrdMedicineInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MTRgrdMedicineInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MTRgrdMedicineInfo.Size = new System.Drawing.Size(453, 320);
            this.MTRgrdMedicineInfo.Style = MetroFramework.MetroColorStyle.Green;
            this.MTRgrdMedicineInfo.TabIndex = 11;
            this.MTRgrdMedicineInfo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // medName
            // 
            this.medName.DataPropertyName = "medName";
            this.medName.HeaderText = "Name";
            this.medName.MinimumWidth = 10;
            this.medName.Name = "medName";
            this.medName.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 50;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "Count";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 50;
            // 
            // morningAlarm
            // 
            this.morningAlarm.DataPropertyName = "morningAlarm";
            this.morningAlarm.HeaderText = "Morning";
            this.morningAlarm.Name = "morningAlarm";
            this.morningAlarm.ReadOnly = true;
            this.morningAlarm.Width = 70;
            // 
            // dayAlarm
            // 
            this.dayAlarm.DataPropertyName = "dayAlarm";
            this.dayAlarm.HeaderText = "Day";
            this.dayAlarm.Name = "dayAlarm";
            this.dayAlarm.ReadOnly = true;
            this.dayAlarm.Width = 70;
            // 
            // nightAlarm
            // 
            this.nightAlarm.DataPropertyName = "nightAlarm";
            this.nightAlarm.HeaderText = "Night";
            this.nightAlarm.Name = "nightAlarm";
            this.nightAlarm.ReadOnly = true;
            this.nightAlarm.Width = 70;
            // 
            // MTRbtnClose
            // 
            this.MTRbtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MTRbtnClose.BackgroundImage")));
            this.MTRbtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MTRbtnClose.Location = new System.Drawing.Point(218, 478);
            this.MTRbtnClose.Name = "MTRbtnClose";
            this.MTRbtnClose.Size = new System.Drawing.Size(56, 53);
            this.MTRbtnClose.TabIndex = 10;
            this.MTRbtnClose.UseSelectable = true;
            this.MTRbtnClose.Click += new System.EventHandler(this.MTRbtnClose_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 22);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(101, 100);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // MTRoutOfMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 646);
            this.Controls.Add(this.MTRpnlOutOfMed);
            this.Name = "MTRoutOfMedicine";
            this.Text = "Out Of Medicine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MTRoutOfMedicine_FormClosing);
            this.MTRpnlOutOfMed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MTRgrdMedicineInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel MTRpnlOutOfMed;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton MTRbtnClose;
        private MetroFramework.Controls.MetroGrid MTRgrdMedicineInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn medName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn morningAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nightAlarm;
    }
}