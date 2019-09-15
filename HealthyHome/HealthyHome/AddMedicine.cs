using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthyHome.Data;
namespace HealthyHome
{
    public partial class AddMedicine : MetroFramework.Forms.MetroForm
    {
        public string Id { get; set; } 
        public AddMedicine()
        {
            InitializeComponent();
        }
        public AddMedicine(string id)
        {
            InitializeComponent();
            this.Id = id;
        }
        public AddMedicine(string id,string name,string price,string count,string morningAlarm,string dayAlarm,string nightAlarm)
        {
            InitializeComponent();
            this.Id = id;
            this.MTRtxtMedName.Text = name;
            this.MTRtxtMedName.ReadOnly = true;
            this.MTRtxtMedPrice.Text = price;
            this.MTRtxtMedCount.Text = count;
            if (morningAlarm.Equals("Yes"))
            {
                this.MTRchkMorning.Checked=true;
            }
            if (dayAlarm.Equals("Yes"))
            {
                this.MTRchkDay.Checked = true;
            }
            if (nightAlarm.Equals("Yes"))
            {
                this.MTRchkNight.Checked = true;
            }
        }

        private void MTRbtnSave_Click(object sender, EventArgs e)
        {
            string userId = this.Id;
            string name=null;
            float price = 0;
            int count = 0;
            int validation = 1;
            int x;
            if (this.MTRtxtMedName.Text.Length == 0 || Int32.TryParse(this.MTRtxtMedName.Text, out x) == true)
            {
                MessageBox.Show("Invalid Name");
                validation = 0;
            }
            else
            {
                name = this.MTRtxtMedName.Text;
            }
            float y;
            if (this.MTRtxtMedPrice.Text.Equals("") || float.TryParse(this.MTRtxtMedPrice.Text, out y) == false)
            {
                MessageBox.Show("Invalid Price");
                validation = 0;
            }
            else
            {
                price = float.Parse(this.MTRtxtMedPrice.Text);

            }
            if (this.MTRtxtMedCount.Text.Equals("") || Int32.TryParse(this.MTRtxtMedCount.Text, out x) == false)
            {
                MessageBox.Show("Invalid Count");
                validation = 0;
            }
            else
            {
                count = Int32.Parse(this.MTRtxtMedCount.Text);

            }

            
                
                
                
                
           
                string morningAlarm, dayAlarm, nightAlarm;
                if (MTRchkMorning.Checked)
                {
                    morningAlarm = "Yes";
                }
                else
                {
                    morningAlarm = "No";
                }
                if (MTRchkDay.Checked)
                {
                    dayAlarm = "Yes";
                }
                else
                {
                    dayAlarm = "No";
                }
                if (MTRchkNight.Checked)
                {
                    nightAlarm = "Yes";
                }
                else
                {
                    nightAlarm = "No";
                }
            if (validation == 1)
            {
                MessageBox.Show("Valid Inputs");
                DataSet ds = new DataSet();
                DataAccess da = new DataAccess();
                string sql;
                try
                {
                    sql = "select * from [HealthyHome].[dbo].[Medicines] where userId='" + this.Id + "' and medName='" + name + "'";
                    ds = da.ExecuteQuery(sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                if (ds.Tables[0].Rows.Count < 1)
                {
                    try
                    {
                        sql = "insert into [HealthyHome].[dbo].[Medicines] values('" + userId + "','" + name + "'," + price + "," + count + ",'" + morningAlarm + "','" + dayAlarm + "','" + nightAlarm + "') ;";
                        da.ExecuteQuery(sql);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                    this.Hide();
                    UserHomeDashboard UHD = new UserHomeDashboard(this.Id);
                    UHD.Visible = true;
                }
                else
                {
                    try
                    {
                        sql = "update [HealthyHome].[dbo].[Medicines] set price=" + price + ", count =" + count + ",morningAlarm='" + morningAlarm + "',dayAlarm='" + dayAlarm + "',nightAlarm='" + nightAlarm + "' where userId ='" + userId + "' and medName = '" + name + "' ;";
                        da.ExecuteQuery(sql);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                    this.Hide();
                    UserHomeDashboard UHD = new UserHomeDashboard(this.Id);
                    UHD.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid Inputs");
            }
        }

        private void AddMedicine_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            UserHomeDashboard UHD = new UserHomeDashboard(this.Id);
            UHD.Visible=true;
            this.Hide();
        }
    }
}
