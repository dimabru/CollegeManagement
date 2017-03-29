using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Project_Team3
{
    class DBconnect
    {

        private string connetionString = null;
        private SqlConnection con;

        public DBconnect() // ctor
        {
            initializeConnection();
        }

        public void initializeConnection()
        {
            connetionString = "Server=tcp:sce2017b.database.windows.net,1433;Initial Catalog=Project3DB;Persist Security Info=False;User ID=sceproject;Password=2017Sce2017;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            con = new SqlConnection(connetionString);
        }

        public Boolean OpenConn()
        {
            try
            {
                con.Open();
                //MessageBox.Show ("Connection Open ! ");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                return false;
            }

        }
        public Boolean ConnStatus()
        {
            if (con == null || con.State == ConnectionState.Closed)
                return false;
            return true;
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
