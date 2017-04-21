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
    class FunctionsForAllProgram
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
            //cmd.CommandText = "SELECT ID FROM Users WHERE EXISTS(SELECT ID FROM USERS WHERE USERNAME = @username";
            cmd.CommandText = "SELECT ID FROM USERS WHERE USERNAME = @username";
            cmd.Parameters.AddWithValue("username", username);
            DataSet ds = db.generalCommand(cmd);

            db.CloseConn(db.ConnStatus());
            try
            {
                MessageBox.Show("User with this username already exists, and it's ID : "+ds.Tables[0].Rows[0].ItemArray[0].ToString());
                status = true;

            }
            catch (System.IndexOutOfRangeException ex )
            {
                status = false;
            }


            return status;

        }
    }
}
