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
    public partial class SetAlarm : MetroFramework.Forms.MetroForm
    {
        public string Id { get; set; }
        public string Morning { get; set; }
        public string Day { get; set; }
        public string Night { get; set; }
        public DataSet Ds { get;set ;} 
        public DataAccess Da { get; set; }
        public SetAlarm()
        {
            InitializeComponent();
        }
        public SetAlarm(string id)
        {
            InitializeComponent();
            this.Id = id;
            this.Ds = new DataSet();
            this.Da = new DataAccess();
            string sql = "select * from [HealthyHome].[dbo].[Alarm] where userId='" + this.Id + "';";
            this.Ds = this.Da.ExecuteQuery(sql);
            if (this.Ds.Tables[0].Rows.Count >= 1)
            {
                this.MTRdtmMorning.Value = DateTime.Parse(Ds.Tables[0].Rows[0]["morning"].ToString());
                this.MTRdtmDay.Value = DateTime.Parse(Ds.Tables[0].Rows[0]["day"].ToString());
                this.MTRdtmNight.Value = DateTime.Parse(Ds.Tables[0].Rows[0]["night"].ToString());
            }

        }

        private void MTRbtnSaveAlarm_Click(object sender, EventArgs e)
        {
            string sql = "select * from [HealthyHome].[dbo].[Alarm] where userId='"+this.Id+"';";
            this.Ds = this.Da.ExecuteQuery(sql);
            if (this.Ds.Tables[0].Rows.Count < 1)
            {
                sql = "insert into [HealthyHome].[dbo].[Alarm] values('" + this.Id + "','" + this.MTRdtmMorning.Text + "','" + this.MTRdtmDay.Text + "','" + this.MTRdtmNight.Text + "');";
                Da.ExecuteQuery(sql);
                MessageBox.Show("Insert Completed");
            }
            else
            {
                
                sql = "update [HealthyHome].[dbo].[Alarm] set morning='"+this.MTRdtmMorning.Text+"',day='"+this.MTRdtmDay.Text+"',night='"+this.MTRdtmNight.Text+"'";
                Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Update Completed");
            }
            this.Hide();
            UserHomeDashboard UHD = new UserHomeDashboard(this.Id);
            UHD.Visible = true;

        }

        private void SetAlarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserHomeDashboard UHD = new UserHomeDashboard(this.Id);
            UHD.Visible = true;
            this.Hide();
        }
    }
}
