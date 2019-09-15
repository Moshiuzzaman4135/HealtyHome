using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthyHome.Data;
using HealthyHome.Entity;
using HealthyHome.Repo;
using System.Data;
using System.Windows.Forms;



namespace HealthyHome.Repo
{
    public class UserRepo
    {
        public UserRepo()
        {
            this.Da = new DataAccess();
        }
        DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public void AddUser(User u)
        {
            //MessageBox.Show(u.Password);
            
            
            string query = "select * from [HealthyHome].[dbo].[User] where id='"+u.Id+"';";           
            this.Ds = Da.ExecuteQuery(query);
            MessageBox.Show(Ds.Tables[0].Rows.Count.ToString());
            if (this.Ds.Tables[0].Rows.Count < 1)
            {
                try
                {
                    string sql = "insert into [HealthyHome].[dbo].[User] values('" + u.Id + "','" + u.Name + "','" + u.Password + "','" + u.Email + "','" + u.PhoneNo + "','" + u.Gender + "','" + u.DateOfBirth + "');";
                    Da.ExecuteQuery(sql);
                    sql = "insert into [HealthyHome].[dbo].[Login] values('" + u.Id + "','" + u.Password + "');";
                    Da.ExecuteQuery(sql);
                    sql = "insert into[HealthyHome].[dbo].[Alarm] values('" + u.Id + "','10:0:0','15:0:0','22:0:0');";
                    Da.ExecuteQuery(sql);
                    //sql = "insert into[HealthyHome].[dbo].[Contacts] values('" + u.Id + "',null,null,null);";
                    //Da.ExecuteQuery(sql);
                    //sql = "insert into[HealthyHome].[dbo].[Medicines] values('" + u.Id + "',null,null,null,null,null,null);";
                    //Da.ExecuteQuery(sql);
                    //sql = "insert into[HealthyHome].[dbo].[Documents] values('" + u.Id + "',null,null,null);";
                    //Da.ExecuteQuery(sql);
                    sql = "insert into[HealthyHome].[dbo].[Health] values('" + u.Id + "','',0,0,0,0,0);";
                    Da.ExecuteQuery(sql);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("User ID already taken");
            }
        }
        public User GetUserInfo(string id)
        {
            string query = "select * from [HealthyHome].[dbo].[User] where id='"+id+"';";
            this.Ds = Da.ExecuteQuery(query);
            string name = this.Ds.Tables[0].Rows[0]["name"].ToString();
            string email = this.Ds.Tables[0].Rows[0]["email"].ToString();
            string password = this.Ds.Tables[0].Rows[0]["password"].ToString();
            string phoneNo = this.Ds.Tables[0].Rows[0]["phoneNumber"].ToString();
            string gender = this.Ds.Tables[0].Rows[0]["gender"].ToString();
            string db = this.Ds.Tables[0].Rows[0]["dateOfBirth"].ToString();
            string dateOfBirth = db.Substring(0, db.IndexOf(" "));
            //MessageBox.Show(name+"\n"+email+"\n" +password + "\n" +phoneNo + "\n" +gender + "\n" + dateOfBirth);
            User UserOne = this.ConvertToUser(name, id, email, password, phoneNo, gender, dateOfBirth);
            return UserOne;
        }

        public User ConvertToUser(string name,string id,string email,string password,string phoneNo,string gender,string dateOfBirth)
        {
            User u1 = new User();
            u1.Id = id;
            u1.Name = name;
            u1.Password = password;
            u1.Email = email;
            u1.PhoneNo = phoneNo;
            u1.Gender = gender;
            u1.DateOfBirth = dateOfBirth;
            return u1;
        }
        public User UpdateUserInfo(string id,User u)
        {
            string sql = "update [HealthyHome].[dbo].[User] set name='"+u.Name+"',password='"+u.Password+"',email='"+u.Email+"',phoneNumber='"+u.PhoneNo+"',gender='"+u.Gender+"',dateOfBirth='"+u.DateOfBirth+"' where id='"+u.Id+"';";
            Da.ExecuteUpdateQuery(sql);
            sql = "update [HealthyHome].[dbo].[Login] set password='"+u.Password+"'where userId='"+u.Id+"';" ;
            Da.ExecuteUpdateQuery(sql);
            return u;
        }
    }
}
