using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Project_Team3.Classes;
namespace Project_Team3
{
    public class DBconnect
    {

        private string connetionString = "Server=tcp:sce2017b.database.windows.net,1433;Initial Catalog=Project3DB;Persist Security Info=False;User ID=sceproject;Password=2017Sce2017;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection con;

        /// <summary>
        /// initialize the connection to our data base
        /// </summary>
        public DBconnect() // ctor
        {
            initializeConnection();
        }

        /// <summary>
        /// get the connection toString()
        /// </summary>
        /// <returns></returns>
        public string ConnectionStringGet() { return connetionString; }

        /// <summary>
        /// new connection to our system, with our string connection
        /// </summary>
        public void initializeConnection()
        {
            con = new SqlConnection(connetionString);
        }

        /// <summary>
        /// open our connection
        /// </summary>
        /// <returns></returns>
        public Boolean OpenConn()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (Exception)
            {
                //MessageBox.Show("Can not open connection ! ");
                return false;
            }
        }

        /// <summary>
        /// check connection status
        /// </summary>
        /// <returns></returns>
        public Boolean ConnStatus()
        {
            if (con == null || con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                return false;
            return true;
        }

        /// <summary>
        /// close our connection
        /// </summary>
        /// <param name="ConnStatus"></param>
        /// <returns></returns>
        public Boolean CloseConn(Boolean ConnStatus)
        {
            if (ConnStatus == true)
            {
                con.Close();
                return true;
            }
            return false;
        }

        /// <summary>
        /// get our connection
        /// </summary>
        /// <returns></returns>
        public SqlConnection getConnection() { return con; }

        /// <summary>
        /// load all our tabels
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
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

        /// <summary>
        /// load  a table with rule that we send
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet LoadTableWithRule(string tableName, String where)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM " + tableName+" "+where;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds;
        }

        /// <summary>
        /// new genenral command
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public DataSet generalCommand(SqlCommand cmd)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cmd.Connection = this.getConnection(); //Remove this line from ALL Queries that use it
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

        /// <summary>
        /// do and execution to query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
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

        /// <summary>
        /// add a sing student to our system
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool addStudentToDB(Student student)
        {
            String queryUsers = "insert into Users values(" + student.ID_setters + ",'" + student.Username + "','" + student.Password + "','Student','" + student.Name + "','" + student.Surename +  "','" + student.email + "',NULL)";
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

        /// <summary>
        /// add a single user to our system
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool addUserToDB(User user)
        {
            String queryUsers = "insert into Users values(" + user.ID_setters + ",'" + user.Username + "','" + user.Password + "','Associate','" + user.Name + "','" + user.Surename + "','" + user.email + "',NULL)";

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

        /// <summary>
        /// add global massage to our system
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool addGlobalMessageToDB(String message)
        {
            String queryUsers = "insert into GlobalMessages values('" + message + "')";

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

        /// <summary>
        /// load a table by free query
        /// </summary>
        /// <param name="querry"></param>
        /// <returns></returns>
        public DataSet LoadTableByFreeQuerry(string querry)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = querry;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds;
        }
    }
}
