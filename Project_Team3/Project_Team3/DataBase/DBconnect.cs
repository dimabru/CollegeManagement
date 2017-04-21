using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Project_Team3.Classes;
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
            if (con == null || con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
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
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            return ds;
    }

        public bool executionQuery(String query)
        {
            try
            {
                OpenConn();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = query;

                DataSet ds = generalCommand(cmd);

                CloseConn(ConnStatus());
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool addStudentToDB(Student student)
        {
            String queryUsers = "insert into Users values(" + student.ID_setters + ",'" + student.Username + "','" + student.Password + "','Student','" + student.Name + "','" + student.Surename + "')";
            String queryStudents = "insert into Student values('" + student.Username + "'," + student.Semester+")";

            try
            {
                executionQuery(queryUsers);
                executionQuery(queryStudents);
                return true;
            }
            catch
                {
                return false;
            }
        }

        public bool addUserToDB(User user)
        {
            String queryUsers = "insert into Users values(" + user.ID_setters + ",'" + user.Username + "','" + user.Password + "','Associate','" + user.Name + "','" + user.Surename + "')";

            try
            {
                executionQuery(queryUsers);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
