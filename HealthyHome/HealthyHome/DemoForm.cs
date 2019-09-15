using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthyHome.Data;

namespace HealthyHome
{
    public partial class DemoForm : MetroFramework.Forms.MetroForm
    {
        Thread T { get; set; }
        string Id { get; set; }
        string Time { get; set; }
        public DemoForm()
        {
            InitializeComponent();
        }
        public DemoForm(int i,string id,DataSet ds,Thread t)
        {
            this.T = t;
            this.Id = id;
            InitializeComponent();
            DataAccess Da= new DataAccess();            
            if (i == 1)
            {
                this.Time = "morningAlarm";

                DataSet dsMorning = Da.ExecuteQuery("select * from [HealthyHome].[dbo].[Medicines] where userId='" + id + "' and morningAlarm='Yes' ;");
                MessageBox.Show(dsMorning.Tables[0].Rows.Count.ToString());
                this.MTRgrdMedicineInfo.AutoGenerateColumns = false;                
                this.MTRgrdMedicineInfo.DataSource = ds.Tables[0];
            }
            if (i == 2)
            {
                this.Time = "dayAlarm";
                DataSet dsDay = Da.ExecuteQuery("select * from [HealthyHome].[dbo].[Medicines] where userId='" + id + "' and dayAlarm='Yes' ;");
                MessageBox.Show(dsDay.Tables[0].Rows.Count.ToString());
                this.MTRgrdMedicineInfo.AutoGenerateColumns = false;                
                this.MTRgrdMedicineInfo.DataSource = ds.Tables[0];

            }
            if (i == 3)
            {

                this.Time = "nightAlarm";
                DataSet dsNight = Da.ExecuteQuery("select * from [HealthyHome].[dbo].[Medicines] where userId='" + id + "' and nightAlarm='Yes' ;");
                MessageBox.Show(dsNight.Tables[0].Rows.Count.ToString());
                this.MTRgrdMedicineInfo.AutoGenerateColumns = false;                
                this.MTRgrdMedicineInfo.DataSource = ds.Tables[0];

            }
        }

        private void MTRbtnOk_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string sql = "update [HealthyHome].[dbo].[Medicines] set count = count -1 where userId = '"+this.Id+"' and "+this.Time+"='Yes' and count>0;";
            try
            {
                da.ExecuteUpdateQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message+"Maybe out of medicine");
            }
            //this.T.Abort();
            this.Hide();
        }

        private void MTRbtnTerminate_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.T.Abort();
        }

        private void DemoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.T.Abort();
        }
    }
}
