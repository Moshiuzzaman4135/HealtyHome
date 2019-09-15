namespace HealthyHome
{
    partial class DemoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MTRbtnOk = new MetroFramework.Controls.MetroButton();
            this.MTRbtnTerminate = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.MTRgrdMedicineInfo = new MetroFramework.Controls.MetroGrid();
            this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.morningAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nightAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MTRgrdMedicineInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // MTRbtnOk
            // 
            this.MTRbtnOk.Location = new System.Drawing.Point(119, 379);
            this.MTRbtnOk.Name = "MTRbtnOk";
            this.MTRbtnOk.Size = new System.Drawing.Size(75, 23);
            this.MTRbtnOk.TabIndex = 0;
            this.MTRbtnOk.Text = "CONFIRM";
            this.MTRbtnOk.UseSelectable = true;
            this.MTRbtnOk.Click += new System.EventHandler(this.MTRbtnOk_Click);
            // 
            // MTRbtnTerminate
            // 
            this.MTRbtnTerminate.Location = new System.Drawing.Point(270, 379);
            this.MTRbtnTerminate.Name = "MTRbtnTerminate";
            this.MTRbtnTerminate.Size = new System.Drawing.Size(75, 23);
            this.MTRbtnTerminate.TabIndex = 1;
            this.MTRbtnTerminate.Text = "TERMINATE";
            this.MTRbtnTerminate.UseSelectable = true;
            this.MTRbtnTerminate.Click += new System.EventHandler(this.MTRbtnTerminate_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.MTRgrdMedicineInfo);
            this.metroPanel1.Controls.Add(this.MTRbtnTerminate);
            this.metroPanel1.Controls.Add(this.MTRbtnOk);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(40, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(488, 447);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MTRgrdMedicineInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.MTRgrdMedicineInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MTRgrdMedicineInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medName,
            this.price,
            this.count,
            this.morningAlarm,
            this.dayAlarm,
            this.nightAlarm});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MTRgrdMedicineInfo.DefaultCellStyle = dataGridViewCellStyle8;
            this.MTRgrdMedicineInfo.EnableHeadersVisualStyles = false;
            this.MTRgrdMedicineInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTRgrdMedicineInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MTRgrdMedicineInfo.Location = new System.Drawing.Point(15, 16);
            this.MTRgrdMedicineInfo.Name = "MTRgrdMedicineInfo";
            this.MTRgrdMedicineInfo.ReadOnly = true;
            this.MTRgrdMedicineInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MTRgrdMedicineInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.MTRgrdMedicineInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MTRgrdMedicineInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MTRgrdMedicineInfo.Size = new System.Drawing.Size(453, 357);
            this.MTRgrdMedicineInfo.Style = MetroFramework.MetroColorStyle.Green;
            this.MTRgrdMedicineInfo.TabIndex = 9;
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
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 534);
            this.Controls.Add(this.metroPanel1);
            this.Name = "DemoForm";
            this.Text = "Alarm ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DemoForm_FormClosing);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MTRgrdMedicineInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton MTRbtnOk;
        private MetroFramework.Controls.MetroButton MTRbtnTerminate;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid MTRgrdMedicineInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn medName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn morningAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nightAlarm;
    }
}