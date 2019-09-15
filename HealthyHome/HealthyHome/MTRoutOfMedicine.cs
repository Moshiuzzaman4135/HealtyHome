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
    public partial class MTRoutOfMedicine : MetroFramework.Forms.MetroForm
    {
        string Id { get; set; }
        public MTRoutOfMedicine()
        {
            InitializeComponent();
        }
        public MTRoutOfMedicine(string id)
        {
            InitializeComponent();
            this.Id = id;
            DataAccess da = new DataAccess();
            DataSet ds = new DataSet();
            string sql = "select * from [HealthyHome].[dbo].[Medicines] where userId='"+this.Id+"' and count<3;";
            ds = da.ExecuteQuery(sql);
            //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
            if (ds.Tables[0].Rows.Count < 1)
            {
                this.Hide();
            }
            else
            {
                //this.MTRgrdMedicineInfo.AutoGenerateColumns = false;
                //ds = da.ExecuteQuery(sql);
                this.Visible = true;
                this.MTRgrdMedicineInfo.DataSource = ds.Tables[0];
            }



        }

        private void MTRoutOfMedicine_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void MTRbtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose(); ;
        }

        private void MTRpnlOutOfMed_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
