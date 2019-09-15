using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthyHome.Repo;
using HealthyHome.Entity;
using HealthyHome.Data;
using System.Threading;
using System.IO;
using System.Data.SqlClient;

namespace HealthyHome
{
    public partial class UserHomeDashboard : MetroFramework.Forms.MetroForm
    {
        public string Id { get; set; }
        public User U { get; set; }
        public byte[] Img { get; set; }
        public DataSet DShealth { get; set; }
        public UserHomeDashboard()
        {
            InitializeComponent();
        }
        public UserHomeDashboard(string id)
        {
            UserRepo UR = new UserRepo();
            InitializeComponent();
            this.Id = id;
            this.MTRlblIdUser.Text = this.Id;
            //UR.GetUserInfo(this.Id);
            User userOne = UR.GetUserInfo(this.Id);
            this.MTRlblName.Text = userOne.Name.ToString();
            this.MTRlblMail.Text = userOne.Email.ToString();
            this.MTRlblPhoneNo.Text = userOne.PhoneNo.ToString();
            this.MTRlblGender.Text = userOne.Gender.ToString();
            this.MTRlblDateOfBirth.Text = userOne.DateOfBirth.ToString();
            this.U = userOne;
            //DataSet ds = new DataSet();
            DataAccess da = new DataAccess();
            string sql;
            try
            {
                sql = "select * from [HealthyHome].[dbo].[Health] where userId='" + this.Id + "';";
                this.DShealth = da.ExecuteQuery(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            this.MTRlblBloodGroup.Text = DShealth.Tables[0].Rows[0]["bloodGroup"].ToString();
            this.MTRlblHeight.Text = DShealth.Tables[0].Rows[0]["height"].ToString();
            this.MTRlblWeight.Text = DShealth.Tables[0].Rows[0]["weight"].ToString();
            this.MTRlblSuger.Text = DShealth.Tables[0].Rows[0]["sugarLevel"].ToString();
            this.MTRlblBloodPressure.Text = DShealth.Tables[0].Rows[0]["bpHigh"].ToString()+" - "+ DShealth.Tables[0].Rows[0]["bpLow"].ToString();
            this.MTRlblBMI.Text = (float.Parse(DShealth.Tables[0].Rows[0]["weight"].ToString()) /( float.Parse(DShealth.Tables[0].Rows[0]["height"].ToString()) * float.Parse(DShealth.Tables[0].Rows[0]["height"].ToString()))).ToString();
            try {
                sql = "select * from [HealthyHome].[dbo].[Contacts] where userId='" + this.Id + "';";
                this.PopulateGridViewContacts(sql);
                sql = "select * from [HealthyHome].[dbo].[Medicines] where userId='" + this.Id + "';";
                this.PopulateGridViewMedicine(sql);
                sql = "select imageId from [HealthyHome].[dbo].[Documents] where userId='"+this.Id+"';";
                this.PopulateGridViewImages(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            //Thread OutOfMedicineThread = new Thread(this.CheckOutOfMedicineList);
            //OutOfMedicineThread.Start();
        }
        void CheckOutOfMedicineList()
        {
            Application.Run(new MTRoutOfMedicine(this.Id));

        }

        void PopulateGridViewContacts(string sql)
        {
            DataSet Ds = new DataSet();
            DataAccess Da = new DataAccess();          

            this.MTRdgvEmergencyContacts.AutoGenerateColumns = false;
            Ds = Da.ExecuteQuery(sql);
            this.MTRdgvEmergencyContacts.DataSource = Ds.Tables[0];
        }
        void PopulateGridViewMedicine(string sql)
        {
            DataSet Ds = new DataSet();
            DataAccess Da = new DataAccess();

            this.MTRgrdMedicineInfo.AutoGenerateColumns = false;
            Ds = Da.ExecuteQuery(sql);
            this.MTRgrdMedicineInfo.DataSource = Ds.Tables[0];

        }
        void PopulateGridViewImages(string sql)
        {
            DataSet Ds = new DataSet();
            DataAccess Da = new DataAccess();

            this.MTRgrdImage.AutoGenerateColumns = false;
            Ds = Da.ExecuteQuery(sql);
            this.MTRgrdImage.DataSource = Ds.Tables[0];

        }

        private void UserHomeDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                Environment.Exit(Environment.ExitCode);
                Application.Exit();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void MTRbtnUserEdit_Click(object sender, EventArgs e)
        {
            MTReditUser Medit = new MTReditUser(U);
            Medit.Visible = true;
            this.Hide();
        }

        private void MTRbtnCloseMedical_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlCommand Command { get; set; }
        public string BloodGroup { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double SugarLevel { get; set; }
        public double BPHigh { get; set; }
        public double BPLow { get; set; }
        public string UserId { get; set; }
        


        private void MTRbtnUpdateMedical_Click(object sender, EventArgs e)
        {
            MTRUpdateHealth MH = new MTRUpdateHealth(this.Id,this.DShealth);
            MH.Visible = true;
            this.Hide();
        }

        private void MTRbtnAddContact_Click(object sender, EventArgs e)
        {
            AddContact ac = new AddContact(this.Id);
            ac.Visible = true;
            this.Hide();

        }

        private void MTRbtnUpdateContact_Click(object sender, EventArgs e)
        {
            AddContact ac = new AddContact(this.Id, this.MTRdgvEmergencyContacts.CurrentRow.Cells["contactId"].Value.ToString(), this.MTRdgvEmergencyContacts.CurrentRow.Cells["name"].Value.ToString(), this.MTRdgvEmergencyContacts.CurrentRow.Cells["phoneNo"].Value.ToString());
            ac.Visible = true;
            this.Hide();
        }

        private void MTRbtnDeleteContact_Click(object sender, EventArgs e)
        {

            string sql = "delete from [HealthyHome].[dbo].[Contacts] where contactId='"+ this.MTRdgvEmergencyContacts.CurrentRow.Cells["contactId"].Value.ToString() + "' and userId = '"+this.Id+"';";
            DataSet ds = new DataSet();
            DataAccess da = new DataAccess();
            da.ExecuteUpdateQuery(sql);
            sql = "select * from [HealthyHome].[dbo].[Contacts] where userId='" + this.Id + "';";
            this.PopulateGridViewContacts(sql);
        }

        private void MTRtxtSearchContact_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from [HealthyHome].[dbo].[Contacts] where name like '" + this.MTRtxtSearchContact.Text + "%' or phoneNo like '" +this.MTRtxtSearchContact.Text + "%';";
            this.PopulateGridViewContacts(sql);
        }

        private void MTRbtnSearchContact_Click(object sender, EventArgs e)
        {
            string sql = "select * from [HealthyHome].[dbo].[Contacts] where name like '" + this.MTRtxtSearchContact.Text + "%' or phoneNo like '" + this.MTRtxtSearchContact.Text + "%';";
            this.PopulateGridViewContacts(sql);
        }

        private void MTRtileAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicine AM = new AddMedicine(this.Id);
            this.Hide();
            AM.Visible = true;
        }

        private void MTRtileEditMedicine_Click(object sender, EventArgs e)
        {
            string id = this.Id;
            string medName = this.MTRgrdMedicineInfo.CurrentRow.Cells["medName"].Value.ToString();
            string price = this.MTRgrdMedicineInfo.CurrentRow.Cells["price"].Value.ToString();
            string count = this.MTRgrdMedicineInfo.CurrentRow.Cells["count"].Value.ToString();
            string morningAlarm = this.MTRgrdMedicineInfo.CurrentRow.Cells["morningAlarm"].Value.ToString();
            string dayAlarm = this.MTRgrdMedicineInfo.CurrentRow.Cells["dayAlarm"].Value.ToString();
            string nightAlarm = this.MTRgrdMedicineInfo.CurrentRow.Cells["nightAlarm"].Value.ToString();
            AddMedicine AM = new AddMedicine(id, medName, price, count, morningAlarm, dayAlarm, nightAlarm);
            AM.Visible = true;
            this.Hide();

        }

        private void MTRtileDeleteMedicine_Click(object sender, EventArgs e)
        {
            string sql = "delete from [HealthyHome].[dbo].[Medicines] where medName='" + this.MTRgrdMedicineInfo.CurrentRow.Cells["medName"].Value.ToString() + "' and userId = '" + this.Id + "';";
            DataSet ds = new DataSet();
            DataAccess da = new DataAccess();
            da.ExecuteUpdateQuery(sql);
            sql = "select * from [HealthyHome].[dbo].[Medicines] where userId='" + this.Id + "';";
            this.PopulateGridViewMedicine(sql);

        }

        private void MTRtxtSearchMedicine_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from [HealthyHome].[dbo].[Medicines] where medName like '"+this.MTRtxtSearchMedicine.Text+"%';";
            this.PopulateGridViewMedicine(sql);
        }

        private void MTRbtnSerachMedicine_Click(object sender, EventArgs e)
        {
            string sql = "select * from [HealthyHome].[dbo].[Medicines] where medName like '" + this.MTRtxtSearchMedicine.Text + "%' and userId='"+this.Id+"';";
            this.PopulateGridViewMedicine(sql);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SetAlarm SA = new SetAlarm(this.Id);
            SA.Visible = true;
            this.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Filses (*.jpg)|*.jpg|GIF Files (*gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pbxDocuments.ImageLocation = imgLoc;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string imgLoc = "";
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HVFG5VJ;Initial Catalog=HealthyHome;Integrated Security=True;User ID=sa;Password=4135");
        SqlCommand command;
        private void MTRbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlChcek = "select * from [HealthyHome].[dbo].[Documents] where userId='"+this.Id+"' and imageId='"+this.MTRtxtImageId.Text+"'";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sqlChcek);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("This Image Id already taken");
                }
                else if(this.MTRtxtImageDescription.Text.Length.Equals(0))
                {
                    MessageBox.Show("Please fill description");
                }
                else
                {

                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    string sql = "insert into [HealthyHome].[dbo].[Documents] values('" + this.Id + "','" + this.MTRtxtImageId.Text + "',@img,'" + this.MTRtxtSearchImage.Text + "');";
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    command = new SqlCommand(sql, conn);
                    command.Parameters.Add(new SqlParameter("@img", img));
                    int x = command.ExecuteNonQuery();
                    MessageBox.Show(x.ToString() + " Documnt saved");
                    conn.Close();
                }


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void MTRbtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from [HealthyHome].[dbo].[Documents] where imageId like '" + this.MTRtxtSearchImage.Text + "' and userId='"+this.Id+"'";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    MTRtxtImageId.Text = reader[2].ToString();
                    MTRtxtImageDescription.Text = reader[4].ToString();
                    byte[] img = (byte[])(reader[3]);
                    if (img == null)
                        picDoc.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picDoc.Image = Image.FromStream(ms);
                    }
                    sql = "select imageId from [HealthyHome].[dbo].[Documents] where userId='" + this.Id + "';";
                    this.PopulateGridViewImages(sql);
                }
                else
                {
                    MessageBox.Show("Cannot be found");
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MTRgrdImage_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string sql = "select * from [HealthyHome].[dbo].[Documents] where imageId like '" + this.MTRgrdImage.CurrentRow.Cells["imageId"].Value.ToString()+ "' and userId='" + this.Id + "'";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    MTRtxtImageId.Text = reader[2].ToString();
                    MTRtxtImageDescription.Text = reader[4].ToString();
                    byte[] img = (byte[])(reader[3]);
                    if (img == null)
                        picDoc.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picDoc.Image = Image.FromStream(ms);
                    }
                    sql = "select imageId from [HealthyHome].[dbo].[Documents] where imageId='" + this.Id + "';";
                    this.PopulateGridViewImages(sql);
                }
                else
                {
                    MessageBox.Show("Cannot be found");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MTRbtnClose_Click(object sender, EventArgs e)
        {
            MTRLogin ml = new MTRLogin();
            ml.Visible = true;
            this.Hide();
        }

        private void MTRtxtSearchImage_TextChanged(object sender, EventArgs e)
        {
            string sql = "select imageId from [HealthyHome].[dbo].[Documents] where imageId like '" + this.MTRtxtSearchImage.Text + "%' and userId='"+this.Id+"';";
            this.PopulateGridViewImages(sql);

        }
    }
}
