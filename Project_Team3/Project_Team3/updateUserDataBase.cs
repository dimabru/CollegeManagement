using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Team3
{
    class updateUserDataBase
    {

        private string connetionString = null;
        private SqlConnection con;

        public Boolean userExist(String password, int id,String userType)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from Users where ID = '" + id +  "'and ACCESSGROUP = '" + userType + "'and PASS = '" + password + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();
                //int count = 0;
                while (dbr.Read())
                {
                    con.Close();
                    return true;
                }
                con.Close();
                return false;
            }
            catch
            {
                throw;
            }
            
        }

        public Boolean signPerson(String Name,String password,int id,String userType)
        {
            try
            {

                return true;
            }
            catch
            {
                return false;
            }
        }

        public updateUserDataBase() // ctor
        {
            initializeConnection();
        }

        public void initializeConnection()
        {
            connetionString = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
            //connetionString = "Server=tcp:sce2017b.database.windows.net,1433;Initial Catalog=Project3DB;Persist Security Info=False;User ID=sceproject;Password=2017Sce2017;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            con = new SqlConnection(connetionString);
        }

        public Boolean OpenConn()
        {
            try
            {
                con.Open();                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public void CloseConn(Boolean ConnStatus)
        {
            if (ConnStatus == true)
            {
                con.Close();
            }

        }

        public SqlConnection getConnection() { return con; }
    }
}
