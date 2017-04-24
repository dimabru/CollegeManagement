using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Team3
{
    class dataBaseOperations
    {
        private string connetionString = null;
        private SqlConnection con;

        /// <summary>
        /// this function delete all professor constraints
        /// that mean taht the specific professos will lose all the constraints he enterd just in database
        /// make sure you delete it in the professor class to
        /// </summary>
        /// <param name="id"></param>
        public void deleteConstrints(ulong id)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                SqlConnection con = new SqlConnection(str);
                SqlCommand sqlCommand = new SqlCommand("delete from dbo.constraints where Id = '" + id + "'", con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }


        /// <summary>
        /// this function get 4 argumments
        /// id,start,ends,day
        /// and build new constraints
        /// </summary>
        /// <param name="toInsert"></param>
        /// <param name="start"></param>
        /// <param name="ends"></param>
        /// <param name="day"></param>
        public void setConstraints(ulong toInsert,int start, int ends, int day)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                SqlConnection con = new SqlConnection(str);
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.constraints(Id,start,ends,day) VALUES(@Id,@start,@ends,@day)", con);

                //the "" + ulong ment to fit the data base type;
                //you can see here other option to convert https://msdn.microsoft.com/en-us/library/2wfez910(v=vs.110).aspx
                sqlCommand.Parameters.AddWithValue("@Id", ""+toInsert);
                sqlCommand.Parameters.AddWithValue("@start",""+start);
                sqlCommand.Parameters.AddWithValue("@ends",""+ends);
                sqlCommand.Parameters.AddWithValue("@day",""+ day);
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// this function return 1d arry 
        /// to parse it you need to divide every 4 item to one constraints
        ///first one in the arry is the id
        ///secound the houre constraints start.
        ///third the houre constraints end's
        ///four's the day in numbers
        ///
        /// trow eception if there was connections error;
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int[] getConstraints(ulong id)
        {
            try
            {
                int counter = 0;
                int[] arrToReturn = {0};
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.constraints where Id = '" + id + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    for (int i = 0;i < 4; i++)
                    {
                        // Resize the array.
                        Array.Resize(ref arrToReturn, counter + 1);
                        arrToReturn[counter++] = Convert.ToInt32(dbr.GetString(i));
                    }
                }
                con.Close();
                return arrToReturn;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// return the password of the user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getUserPasswordById(ulong id)
        {
            try
            {
                string to_return = "";
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Users where Id = '" + id + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {
                    to_return = dbr.GetValue(2).ToString();
                    //to_return = (dbr["PASS"].ToString());
                }
                con.Close();
                return "" + to_return.Trim();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }


        /// <summary>
        /// update the user password in data base
        /// </summary>
        /// <param name="password"></param>
        /// <param name="id"></param>
        public void updateUserPassword(String password, ulong id)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                string query = "UPDATE dbo.Users SET ID = " + id + ", PASS = " + password + "WHERE ID = " + id;
                SqlConnection con = new SqlConnection(str);
                SqlCommand sqlCommand = new SqlCommand(query, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }

            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean userExist(String password, ulong id,String userType)
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
                con.Close();
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

        public dataBaseOperations() // ctor
        {
            initialize_Data_Base_Connection();
        }


        /// <summary>
        /// initiallize user data base connection
        /// </summary>
        public void initialize_Data_Base_Connection()
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
