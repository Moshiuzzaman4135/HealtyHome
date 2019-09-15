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
    public partial class MTRUpdateHealth : MetroFramework.Forms.MetroForm
    {   string Id { get; set; }
        DataSet DS = new DataSet();
        public MTRUpdateHealth(string id,DataSet ds)
        {
            InitializeComponent();
            this.Id = id;
            this.DS = ds;
            this.cmbBG.SelectedIndex = cmbBG.FindStringExact(DS.Tables[0].Rows[0]["bloodGroup"].ToString());
            this.MTRtxtHeight.Text = DS.Tables[0].Rows[0]["height"].ToString();
            this.MTRtxtWeight.Text = DS.Tables[0].Rows[0]["weight"].ToString();
            this.MTRtxtHeight.Text = DS.Tables[0].Rows[0]["height"].ToString();
            this.MTRtxtSugarLevel.Text = DS.Tables[0].Rows[0]["sugarLevel"].ToString();
            this.MTRtxtBPH.Text = DS.Tables[0].Rows[0]["bpHigh"].ToString();
            this.MTRtxtBPL.Text = DS.Tables[0].Rows[0]["bpLow"].ToString();


        }
        public bool ValidateHealthForm()
        {
            bool val = true;
            if (float.Parse(this.MTRtxtHeight.Text) < 0 || float.Parse(this.MTRtxtHeight.Text) > 3 || this.MTRtxtHeight.Text.ToString().Length<=0)
            {
                MessageBox.Show("Invalid Height Value");
                val = false;
            }
            if (float.Parse(this.MTRtxtWeight.Text) <0 || float.Parse(this.MTRtxtWeight.Text)>300 || this.MTRtxtWeight.Text.Length<=0)
            {
                MessageBox.Show("Invalid Weight Value");
                val = false;
            }
            

            return val;

        }
        private void MTRUpdateHealth_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit()
            UserHomeDashboard UHD = new UserHomeDashboard(this.Id);
            UHD.Visible = true;
            this.Hide(); ;
        }

        private void MTRbtnUpdateHealthSave_Click(object sender, EventArgs e)
        {
            int validation = 1;
            DataSet ds = new DataSet();
            DataAccess Da = new DataAccess();
            if (this.cmbBG.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Select Blood Group");
                validation = 0;
            }
            float x;
            if (this.MTRtxtHeight.Text.Equals("") || float.TryParse(this.MTRtxtHeight.Text, out x) == false|| float.Parse(this.MTRtxtHeight.Text) <0|| float.Parse(this.MTRtxtHeight.Text) > 2.5) 
            {
                MessageBox.Show("Invalid Height");
                validation = 0;
            }
            if (this.MTRtxtWeight.Text.Equals("") || float.TryParse(this.MTRtxtWeight.Text, out x) == false|| float.Parse(this.MTRtxtWeight.Text) < 0)
            {
                MessageBox.Show("Invalid Weight");
                validation = 0;
            }
            if (this.MTRtxtSugarLevel.Text.Equals("") || float.TryParse(this.MTRtxtSugarLevel.Text, out x) == false|| float.Parse(this.MTRtxtSugarLevel.Text)<0|| float.Parse(this.MTRtxtSugarLevel.Text) > 25)
            {
                MessageBox.Show("Invalid Sugar Level");
                validation = 0;
            }
            int y;
            if (this.MTRtxtBPH.Text.Equals("") || Int32.Parse(this.MTRtxtBPH.Text) < 0 || Int32.Parse(this.MTRtxtBPH.Text) > 300 || Int32.TryParse(this.MTRtxtBPH.Text, out y)==false|| Int32.Parse(this.MTRtxtBPH.Text)< Int32.Parse(this.MTRtxtBPL.Text))
            {
                MessageBox.Show("Invalid BP value");
                validation = 0;
            }
            if (this.MTRtxtBPL.Text.Equals("") || Int32.Parse(this.MTRtxtBPL.Text) < 0 || Int32.Parse(this.MTRtxtBPL.Text) > 300 || Int32.TryParse(this.MTRtxtBPL.Text, out y)==false|| Int32.Parse(this.MTRtxtBPH.Text) < Int32.Parse(this.MTRtxtBPL.Text))
            {
                MessageBox.Show("Invalid BP value");
                validation = 0;
            }





            if (validation == 1)
            {

                string sql = "select * from [HealthyHome].[dbo].[Health] where userId='" + this.Id + "';";
                ds = Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count < 1)
                {
                    sql = "insert into [HealthyHome].[dbo].[Health] values('" + this.Id + "','" + this.cmbBG.Text + "'," + float.Parse(this.MTRtxtHeight.Text) + ", " + float.Parse(this.MTRtxtWeight.Text) + " ," + float.Parse(this.MTRtxtSugarLevel.Text) + ", " + Int32.Parse(this.MTRtxtBPH.Text) + ", " + Int32.Parse(this.MTRtxtBPL.Text) + ");";
                    Da.ExecuteQuery(sql);
                    this.Close();
                }
                else
                {
                    sql = "update [HealthyHome].[dbo].[Health] set bloodGroup='" + this.cmbBG.Text + "',height = " + float.Parse(this.MTRtxtHeight.Text) + " , weight = " + float.Parse(this.MTRtxtWeight.Text) + ",sugarLevel=" + float.Parse(this.MTRtxtSugarLevel.Text) + " ,bpHigh = " + Int32.Parse(this.MTRtxtBPH.Text) + ",bpLow=" + Int32.Parse(this.MTRtxtBPL.Text) + " ;";
                    Da.ExecuteUpdateQuery(sql);
                    this.Hide();
                }
                UserHomeDashboard UHD = new UserHomeDashboard(this.Id);
                UHD.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Inputs");

            }



        }
    }
}
