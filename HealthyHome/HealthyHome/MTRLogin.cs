using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthyHome.Entity;
using HealthyHome.Data;
using System.Threading;

namespace HealthyHome
{
    public partial class MTRLogin : MetroFramework.Forms.MetroForm
    {
        Thread AlarmThread { get; set; }
        DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataSet DM { get; set; }
        private DataSet DD { get; set; }
        private DataSet DN { get; set; }
        public string Id{get;set;} 
        public  MTRLogin()
        {
            InitializeComponent();
            this.MTRTxtId.Text = "";
            this.MTRTxtPassword.Text = "";
            this.Da = new DataAccess();

        }    


        private void MTRBtnSignUp_Click(object sender, EventArgs e)
        {
            MTRSignUpForm SF = new MTRSignUpForm();
            this.Visible = false;
            SF.Visible = true;
           

        }

        private void MTRBtnLogin_Click(object sender, EventArgs e)
        {   
            string id = this.MTRTxtId.Text;
            string password = this.MTRTxtPassword.Text;
            string sql = "select * from login where userId='"+id+"' and password='"+password+"';";
            this.Ds = Da.ExecuteQuery(sql);
            
            if (this.Ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                UserHomeDashboard UHD = new UserHomeDashboard(id);
                UHD.Visible = true;
                this.Visible = false;
                this.Id = this.MTRTxtId.Text;
                Thread OutOfMedicineThread = new Thread(this.CheckOutOfMedicineList);
                OutOfMedicineThread.IsBackground = true;
                OutOfMedicineThread.Start();
                DataSet dsMorning = Da.ExecuteQuery("select * from [HealthyHome].[dbo].[Medicines] where userId='" + id + "' and morningAlarm='Yes' ;");
                DataSet dsDay = Da.ExecuteQuery("select * from [HealthyHome].[dbo].[Medicines] where userId='" + id + "' and dayAlarm='Yes' ;");
                DataSet dsNight = Da.ExecuteQuery("select * from [HealthyHome].[dbo].[Medicines] where userId='" + id + "' and nightAlarm='Yes' ;");
                this.DD = dsDay;this.DM = dsMorning;this.DN = dsNight;
                Thread alarm = new Thread(startAlarm);
                alarm.IsBackground = true;
                this.AlarmThread = alarm;
                alarm.Start();
            }
            else
            {
                MessageBox.Show("Invalid User Id or Password");
            }
            

        }
        void startAlarm()
        {
            //MessageBox.Show(" Inside Login Class ");

            Application.Run(new AlarmForm(this.Id,this.AlarmThread,DM,DD,DN));            

        }
        void CheckOutOfMedicineList()
        {
            Application.Run(new MTRoutOfMedicine(this.Id));

        }

        private void MTRLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
