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

        private string connetionString = "Server=tcp:sce2017b.database.windows.net,1433;Initial Catalog=Project3DB;Persist Security Info=False;User ID=sceproject;Password=2017Sce2017;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection con;


        public DBconnect() // ctor
        {
            initializeConnection();
        }


        public string ConnectionStringGet() { return connetionString; }
        public void initializeConnection()
        {
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


        public DataSet LoadAllTable(string tableName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM " + tableName;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds;
        }



        public DataSet generalSelect(string tableName, bool where,  string condition, List<string> a,string columns = "*")
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();


            cmd.CommandText = "SELECT " + columns + " FROM " + tableName;
            if (where) cmd.CommandText += " WHERE "+ condition;

            for (int i =0; i < a.Count; i++)
            {
                cmd.Parameters.AddWithValue(i.ToString(), a[i]);

            }
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds;
        }
        public DataSet generalCommand(SqlCommand cmd){
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            try
            {
                sda.Fill(ds, "Conn_DB");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Data!");
                return null;
            }
            return ds;
    }

    }
}
