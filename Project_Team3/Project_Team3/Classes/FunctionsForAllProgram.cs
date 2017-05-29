using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.Classes
{
    public class FunctionsForAllProgram
    {

        public bool ifUserInDatabase(String username)
        {
            bool status=false;
            DBconnect db;
            db = new DBconnect();
            db.OpenConn();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.getConnection();
            cmd.CommandText = "SELECT ID FROM USERS WHERE USERNAME = @username";
            cmd.Parameters.AddWithValue("username", username);
            DataSet ds = db.generalCommand(cmd);

            db.CloseConn(db.ConnStatus());
            try
            {
               string user = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                status = true;

            }
            catch (System.IndexOutOfRangeException)
            {
                status = false;
            }


            return status;

        }

        public bool ifUserIDinDatabase(int id)
        {
            bool status = false;
            DBconnect db;
            db = new DBconnect();
            db.OpenConn();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.getConnection();
            cmd.CommandText = "SELECT username FROM USERS WHERE ID = @ID";
            cmd.Parameters.AddWithValue("ID", id);
            DataSet ds = db.generalCommand(cmd);

            db.CloseConn(db.ConnStatus());
            try
            {
               string user = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                status = true;

            }
            catch (System.IndexOutOfRangeException)
            {
                status = false;
            }


            return status;

        }

        public bool ifIDinTable(int id,String tableName)
        {
            bool status = false;
            DBconnect db;
            db = new DBconnect();
            db.OpenConn();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.getConnection();
            cmd.CommandText = "SELECT * FROM "+tableName+" WHERE ID = @ID";
            cmd.Parameters.AddWithValue("ID", id);
            DataSet ds = db.generalCommand(cmd);

            db.CloseConn(db.ConnStatus());
            try
            {
                ds.Tables[0].Rows[0].ItemArray[0].ToString();
                status = true;

            }
            catch (System.IndexOutOfRangeException)
            {
                status = false;
            }


            return status;

        }

        public bool ifIDinEvents(int id)
        {
            bool status = false;
            DBconnect db;
            db = new DBconnect();
            db.OpenConn();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.getConnection();
            cmd.CommandText = "SELECT * FROM Event WHERE EVENT_ID = @ID";
            cmd.Parameters.AddWithValue("ID", id);
            DataSet ds = db.generalCommand(cmd);

            db.CloseConn(db.ConnStatus());
            try
            {
                ds.Tables[0].Rows[0].ItemArray[0].ToString();
                status = true;

            }
            catch (System.IndexOutOfRangeException)
            {
                status = false;
            }

            return status;

        }
    }
}
