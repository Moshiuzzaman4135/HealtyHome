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
    public partial class AlarmForm : MetroFramework.Forms.MetroForm
    {
        Thread T { get; set; }
        string Id { get; set; }
        DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataSet DM { get; set; }
        private DataSet DD { get; set; }
        private DataSet DN { get; set; }
        public AlarmForm()
        {
            InitializeComponent();
        }
        public AlarmForm(string id, Thread t,DataSet dm, DataSet dd, DataSet dn)
        {
            //MessageBox.Show(" Inside Alarm Class");
            this.DD = dd; this.DM = dm; this.DN = dn;
            InitializeComponent();
            this.Da = new DataAccess();
            this.Ds = new DataSet();
            this.T = t;
            this.Id = id;
            
            while (true)
            {
                string sql = "select * from [HealthyHome].[dbo].[Alarm] where userId='" + this.Id + "';";
                try
                {
                    this.Ds = Da.ExecuteQuery(sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                string morning = Ds.Tables[0].Rows[0]["morning"].ToString();
                string day = Ds.Tables[0].Rows[0]["day"].ToString();
                string night = Ds.Tables[0].Rows[0]["night"].ToString();
                //MessageBox.Show("Current time : " + DateTime.Now.ToString("HH:mm:ss") + "\nMorning : " + morning + "\nDay : " + day + "\nNight : " + night);
                string currenTtiME = DateTime.Now.ToString("HH:mm:ss");
                int time=0;
                if (currenTtiME.Equals(morning))
                {
                    MessageBox.Show(" Alert Morning Medicine Time ");
                    time = 1;
                    //Application.Run(new DemoForm(this.Id,"morningAlarm"));
                    Application.Run(new DemoForm(time,this.Id,this.DM,this.T));
                    Thread.Sleep(2000);


                }
                if (currenTtiME.Equals(day))
                {
                    time = 2;
                    MessageBox.Show(" Alert Day Medicine Time ");
                    
                    //Application.Run(new DemoForm( this.Id, "dayAlarm"));
                    Application.Run(new DemoForm(time, this.Id,this.DD, this.T));
                    Thread.Sleep(2000);


                }
                if (currenTtiME.Equals(night))
                {
                    time = 3;
                    MessageBox.Show(" Alert Night Medicine Time ");                   
                    
                    //Application.Run(new DemoForm( this.Id, "nightAlarm"));
                    Application.Run(new DemoForm(time, this.Id,this.DN, this.T));
                    Thread.Sleep(2000);

                }
            }
        }

        private void AlarmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.T.Abort();
        }
    }
}
