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
    public partial class AddContact : MetroFramework.Forms.MetroForm
    {
        public string Id { get; set; }
        public AddContact()
        {
            InitializeComponent();
        }
        public AddContact(string id)
        {
            InitializeComponent();
            this.Id = id;
        }
        public AddContact(string id,string cId, string name,string phoneNo)
        {
            InitializeComponent();
            this.Id = id;
            this.txtContactID.Text = cId;
            this.txtName.Text = name;
            this.txtPhoneNo.Text = phoneNo;
        }

        private void MTRbtnSaveContact_Click(object sender, EventArgs e)
        {
            int v = 1;
            DataSet ds = new DataSet();
            DataAccess da = new DataAccess();
            if(this.txtContactID.Text.Equals("") || this.txtContactID.Text.Length>20)
            {
                MessageBox.Show("Invalid Contact Id");
                v = 0;
            }
            int x;
            if (this.txtName.Text.Equals("") || int.TryParse(this.txtName.Text, out x) == true|| this.txtName.Text.Any(c => char.IsDigit(c)) == true)
            {
                MessageBox.Show("Invalid Name");
                v = 0;
            }
            try
            {
                if (this.txtPhoneNo.Text[0] != '0' || this.txtPhoneNo.Text.Length == 10 || int.TryParse(this.txtPhoneNo.Text, out x) == false)
                {
                    MessageBox.Show("Invalid Phone Number");
                    v = 0;

                }
            }
            catch
                {
                MessageBox.Show("Invalid Phone Number");
                v = 0;

            }
            string sql;
            if (v == 1)
            {
                try
                {
                    sql = "select * from [HealthyHome].[dbo].[Contacts] where contactId='" + this.txtContactID.Text + "'  and userId='" + this.Id + "' ;";
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
                        sql = "insert into [HealthyHome].[dbo].[Contacts] values('" + this.Id + "' , '" + this.txtContactID.Text + "' , '" + this.txtName.Text + "' ,'" + this.txtPhoneNo.Text + "' );";
                        da.ExecuteQuery(sql);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    
                    UserHomeDashboard UHD = new UserHomeDashboard(this.Id);
                    UHD.Visible = true;
                    this.Hide();
                }
                else
                {
                    try
                    {
                        //MessageBox.Show("Here");
                        sql = "update [HealthyHome].[dbo].[Contacts] set name='" + this.txtName.Text + "',phoneNo='" + this.txtPhoneNo.Text + "' where userId='" + this.Id + "' and contactId='" + this.txtContactID.Text + "';";
                        //MessageBox.Show("Here 1");
                        da.ExecuteUpdateQuery(sql);
                        //MessageBox.Show("Here 2");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    
                    UserHomeDashboard UHD = new UserHomeDashboard(this.Id);
                    UHD.Visible = true;
                    this.Hide();
                    
                }
            }
        }

        private void AddContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
