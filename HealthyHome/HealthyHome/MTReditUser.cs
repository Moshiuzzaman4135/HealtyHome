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
using HealthyHome.Repo;
using System.Globalization;

namespace HealthyHome
{
    public partial class MTReditUser : MetroFramework.Forms.MetroForm
    {
        User U { get; set; }
        string Id { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string PhoneNo { get; set; }
        string Gender { get; set; }
        string DateOfBirth { get; set; }
        public MTReditUser()
        {
            InitializeComponent();
        }
        public MTReditUser(User u)
        {
            InitializeComponent();
            this.U = u;
            this.MTRtxtName.Text = u.Name;
            this.MTRtxtId.Text = u.Id;
            this.MTRtxtPassword.Text = u.Password;
            this.MTRtxtEmail.Text = u.Email;
            this.MTRtxtPhoneNo.Text = u.PhoneNo;
            if (u.Gender.Equals("Male"))
            {
                this.MTRrbMale.Checked = true;
            }
            else if (u.Gender.Equals("Female"))
            {
                this.MTRrbFemale.Checked = true;
            }
            DateTime dt = DateTime.Parse(u.DateOfBirth);
            MTRdtmDateOfBirth.Value = dt;

        }

        private void MTReditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserHomeDashboard UHD = new UserHomeDashboard(U.Id);
            UHD.U = this.U;
            UHD.Visible = true;
            this.Hide();
        }

        private void MTRbtnCancel_Click(object sender, EventArgs e)
        {
            UserHomeDashboard UHD = new UserHomeDashboard(U.Id);
            UHD.U = this.U;
            UHD.Visible = true;
            this.Hide();
        }

        private void MTRbtnSave_Click(object sender, EventArgs e)
        {
            this.U.Id = this.MTRtxtId.Text;
            int validation = 1;
            if(this.MTRtxtName.Text.Equals("")|| this.MTRtxtName.Text.Any(c => char.IsDigit(c))==true)
            {
                MessageBox.Show("Invalid Name");
                validation = 0;
            }
            if (this.MTRtxtPassword.Text.Equals("")|| this.MTRtxtPassword.Text.Length>20|| this.MTRtxtPassword.Text.Length < 4)
            {
                MessageBox.Show("Invalid Password (4-20 Charachter)");
                validation = 0;
            }
            try
            {
                int x;
                if (this.MTRtxtPhoneNo.Text[0] != '0' || this.MTRtxtPhoneNo.Text.Length == 10 || int.TryParse(this.MTRtxtPhoneNo.Text, out x) == false)
                {
                    MessageBox.Show("Invalid Phone Number");
                    validation = 0;

                }
            }
            catch
            {
                MessageBox.Show("Invalid Phone Number");
                validation = 0;

            }
            


            if ( validation == 1)
            {
                this.U.Name = this.MTRtxtName.Text;
                this.U.Password = this.MTRtxtPassword.Text;
                this.U.Email = this.MTRtxtEmail.Text;
                this.U.PhoneNo = this.MTRtxtPhoneNo.Text;
                if (this.MTRrbMale.Checked == true)
                {
                    this.U.Gender = this.MTRrbMale.Text.ToString();
                }
                else if (this.MTRrbFemale.Checked == true)
                {
                    this.U.Gender = this.MTRrbFemale.Text.ToString();
                }
                this.U.DateOfBirth = MTRdtmDateOfBirth.Text;
                UserRepo URP = new UserRepo();
                U = URP.UpdateUserInfo(U.Id, U);
                this.Hide();
                UserHomeDashboard UHDB = new UserHomeDashboard(U.Id);
                UHDB.Visible = true;
            }
            
            


        }
    }
}
