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
        /// delete user by id
        /// </summary>
        /// <param name="id"></param>
        public void deleteUser(ulong id)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                SqlConnection con = new SqlConnection(str);
                SqlCommand sqlCommand = new SqlCommand("delete from dbo.Users where ID = '" + id + "'", con);
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
        /// set new uer in data base
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="pass"></param>
        /// <param name="accessGroup"></param>
        public void setNewUser(ulong id, string name, string lastName ,string pass, string accessGroup)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                SqlConnection con = new SqlConnection(str);
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.Users(ID,USERNAME,PASS,ACCESSGROUP,UNAME,SNAME) VALUES(@ID,@USERNAME,@PASS,@ACCESSGROUP,@UNAME,@SNAME)", con);

                //the "" + ulong ment to fit the data base type;
                //you can see here other option to convert https://msdn.microsoft.com/en-us/library/2wfez910(v=vs.110).aspx
                sqlCommand.Parameters.AddWithValue("@ID", "" + id);
                sqlCommand.Parameters.AddWithValue("@USERNAME", "" + name);
                sqlCommand.Parameters.AddWithValue("@PASS", "" + pass);
                sqlCommand.Parameters.AddWithValue("@ACCESSGROUP", "" + accessGroup);
                sqlCommand.Parameters.AddWithValue("@UNAME", "" + name);
                sqlCommand.Parameters.AddWithValue("@SNAME", "" + lastName);
                
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
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
                return to_return.Trim();
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
        /// return the user access group by his id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getUserAccessGroupById(ulong id)
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
                    to_return = dbr.GetValue(3).ToString();
                    //to_return = (dbr["ACCESSGROUP"].ToString());
                }
                con.Close();
                return to_return.Trim();
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
        /// return the user name from the database by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getUserNameById(ulong id)
        {
            try
            {
                string to_return = "";
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Users where ID = '" + id + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {
                    to_return = dbr.GetValue(1).ToString();
                    //to_return = (dbr["USERNAME"].ToString());
                }
                con.Close();
                return to_return.Trim();
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
        /// return the last name of the user from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getUserLastNameById(ulong id)
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
                    to_return = dbr.GetValue(5).ToString();
                    //to_return = (dbr["SNAME"].ToString());
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

        /// <summary>//
        /// return an array of the names of the courses according id of teacher
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string[] getCoursesByTId(ulong id)
        {
            try
            {
                int counter = 0;
                string[] arrToReturn = { "" };
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Course where COURSE_ID = '" + id + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {
                    int w = (int)dbr.GetValue(2);
                    ulong res = Convert.ToUInt64(w);
                    if (id == res)
                    { // Resize the array.
                        Array.Resize(ref arrToReturn, counter + 1);
                        arrToReturn[counter++] = dbr.GetValue(1).ToString();
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

        /// <summary>//
        /// return an attribute value of the course according the id (location) of the attribute in DB
        /// </summary>
        /// <param name="name",param name="i"></param>
        /// <returns></returns>
        public string getAttrByName(string name, int i)
        {
            try
            {

                string ToReturn = "";
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Course where COURSE_NAME = '" + name + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {
                    if (name.Equals(dbr.GetValue(1)))
                    {

                        ToReturn = dbr.GetValue(i).ToString();
                    }
                }
                con.Close();
                return ToReturn;
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// return how many users in this access group
        /// </summary>
        /// <param name="access_group"></param>
        /// <returns></returns>
        public int how_many_from_this_type(string access_group)
        {
            try
            {
                int counter = 0;
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from Users where ACCESSGROUP = '" + access_group + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();
                //int count = 0;
                while (dbr.Read())
                    {
                        counter++;
                    }
                con.Close();
                return counter;
            }
            catch
            {
                con.Close();
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
        public void updateUserPassword(string password, ulong id)
        {
            try
            {
                string str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                string query = "UPDATE dbo.Users SET ID = " + id + ", PASS = " + "'" + password + "'" + "WHERE ID = " + id;
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


       





































        ///////////////////////////////////////////////////////////////////////////////////////
        /// <summary>//change the summary- reut
        /// return the day of the course according id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getCourseDayById(int id, int i)
        {
            try
            {
                string to_return = "";
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Course where COURSE_ID = '" + id + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {
                    to_return = dbr.GetValue(i).ToString();
                    //to_return = (dbr["SNAME"].ToString());
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

        public int[] getnumofCourses(ulong id)
        {
            try
            {
                int counter = 0;
                int[] arrToReturn = { 0 };
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.constraints where Id = '" + id + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    for (int i = 0; i < 4; i++)
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
        /// /////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="password"></param>
        /// <param name="id"></param>
        /// <param name="userType"></param>
        /// <returns></returns>

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
            con = new SqlConnection(connetionString);
        }

        public Boolean OpenConn()
        {
            try
            {
                con.Open();                
                return true;
            }
            catch 
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
