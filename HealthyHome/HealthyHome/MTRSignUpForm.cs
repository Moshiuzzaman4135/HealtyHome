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
using System.Globalization;
using HealthyHome.Repo;

namespace HealthyHome
{
    public partial class MTRSignUpForm : MetroFramework.Forms.MetroForm
    {
        public MTRSignUpForm()
        {
            InitializeComponent();
        }
        string Id { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string PhoneNo { get; set; }
        string Gender { get; set; }
        string DateOfBirth { get; set; }
        private void MTRbtnCancel_Click(object sender, EventArgs e)
        {

            
            MTRLogin mtrL = new MTRLogin();
            mtrL.Visible = true;
            this.Hide();

        }

        private void MTRSignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MTRbtnSave_Click(object sender, EventArgs e)
        {
            bool valid=true;
            Validation v = new Validation(this);
            if (v.IsIdValid(this.MTRtxtFirstId.Text) == true)
            {
                DataAccess da = new DataAccess();
                DataSet ds = new DataSet();
                string sql = "select * from [HealthyHome].[dbo].[Health] where userId='" + this.MTRtxtFirstId.Text + "'";
                try
                {
                    ds = da.ExecuteQuery(sql);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                if (ds.Tables[0].Rows.Count < 1)
                {
                    this.Id = this.MTRtxtFirstId.Text;
                }
                else
                {
                    valid = false;
                }
            }
            
            else if (MTRtxtFirstId.Text.Length == 0 || v.IsIdValid(this.MTRtxtFirstId.Text) == false)
            {                               
                MessageBox.Show("Please Fill ID ");
                valid = false;
            }


            if (MTRtxtName.Text.Length > 0|| this.MTRtxtName.Text.Any(c => char.IsDigit(c)) == false)
            {
                

                this.Name = this.MTRtxtName.Text;
                
            }



            else
            {
                MessageBox.Show("Please Fill Name ");
                valid = false;
            }


            if (v.IsPasswordValid(this.MTRtxtPassword.Text) == true)
            {
                
                this.Password = this.MTRtxtPassword.Text;
            }
            else if (MTRtxtPassword.Text.Length == 0 || v.IsPasswordValid(this.MTRtxtPassword.Text) == false)
            {
                MessageBox.Show("Please Fill Password ");
                valid = false;
            }


            if (this.MTRtxtEmail.Text.Length > 0)
            {
                this.Email = this.MTRtxtEmail.Text;
            }
            else
            {
                MessageBox.Show("Please Fill Email ");
                valid = false;
            }


            if (v.IsPhoneNoValid(this.MTRtxtPhoneNo.Text) == true)
            {
                this.PhoneNo = this.MTRtxtPhoneNo.Text;
            }
            else if (this.MTRtxtPhoneNo.Text.Length == 0 || v.IsPhoneNoValid(this.MTRtxtPhoneNo.Text) == false)
            {
                MessageBox.Show("Please Fill Phone Number ");
                valid = false;
            }



            if (MTRrbMale.Checked == true)
            {
                this.Gender = MTRrbMale.Text.ToString();
            }
            else if (MTRrbFemale.Checked == true)
            {
                this.Gender = MTRrbFemale.Text.ToString();
            }
            else
            {
                MessageBox.Show("Please Select Gender ");
                valid = false;
            }
            this.DateOfBirth = this.MTRdtmDateOfBirth.Text;
               
            User u1 = new User();
            u1.Name = this.Name;
            u1.Id = this.Id;
            
            u1.Password = this.Password;
            u1.Email = this.Email;
            u1.PhoneNo = this.PhoneNo;
            u1.Gender = this.Gender;
            u1.DateOfBirth = DateOfBirth;
            MessageBox.Show(DateOfBirth);
            if (valid == true)
            {
                UserRepo UR=new UserRepo();
                UR.AddUser(u1);
                MTRLogin mtrL = new MTRLogin();
                mtrL.Visible = true;
                this.Hide();
                
            }
            else if(valid == false)
            {
                MessageBox.Show("Invalid Data Entrty");
            }


        }
    }
}
