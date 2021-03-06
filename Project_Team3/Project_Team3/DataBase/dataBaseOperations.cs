﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_Team3.Courses;

namespace Project_Team3
{
    public class dataBaseOperations
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
        /// romove a single course from our system
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool removeCourse(int id)
        {
            if (!(courseExist(id)))
            {
                return false;
            }
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                SqlConnection con = new SqlConnection(str);
                SqlCommand sqlCommand = new SqlCommand("delete from dbo.Course where COURSE_ID = '" + id + "'", con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// remove a single room from our system
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool removeRoom(string name)
        {
            if (!(roomExist(name)))
            {
                return false;
            }
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                SqlConnection con = new SqlConnection(str);
                SqlCommand sqlCommand = new SqlCommand("delete from dbo.Room where room_number = '" + name + "'", con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
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
        public void setConstraints(ulong toInsert, int start, int ends, int day)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                SqlConnection con = new SqlConnection(str);
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.constraints(Id,start,ends,day) VALUES(@Id,@start,@ends,@day)", con);

                //the "" + ulong ment to fit the data base type;
                //you can see here other option to convert https://msdn.microsoft.com/en-us/library/2wfez910(v=vs.110).aspx
                sqlCommand.Parameters.AddWithValue("@Id", "" + toInsert);
                sqlCommand.Parameters.AddWithValue("@start", "" + start);
                sqlCommand.Parameters.AddWithValue("@ends", "" + ends);
                sqlCommand.Parameters.AddWithValue("@day", "" + day);
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
        public void setNewUser(ulong id, string name, string lastName, string pass, string accessGroup, string user_name)
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
                sqlCommand.Parameters.AddWithValue("@UNAME", "" + user_name);
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
        /// return a list of professors, sort by id's,
        /// </summary>
        /// <returns></returns>
        public static List<ulong> getProfessorIdList()
        {
            try
            {
                List<ulong> idList = new List<ulong>();
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Users where ACCESSGROUP = '" + "Professor" + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;

                con.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    idList.Add(publicChecksAndOperations.convertToUlong(dbr.GetValue(0).ToString()));
                }
                con.Close();
                return idList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// return a list of instructors, sort by id's, from our system
        /// </summary>
        /// <returns></returns>
        public static List<ulong> getInstructorIdList()
        {
            try
            {
                List<ulong> idList = new List<ulong>();
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Users where ACCESSGROUP = '" + "Instructor" + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;

                con.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    idList.Add(publicChecksAndOperations.convertToUlong(dbr.GetValue(0).ToString()));
                }
                con.Close();
                return idList;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// return a list of courses, sort by id's, from our system
        /// </summary>
        /// <returns></returns>
        public static List<int> getCourseIdList()
        {
            try
            {
                List<int> idList = new List<int>();
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Course";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;

                con.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    idList.Add(Int32.Parse(dbr.GetValue(0).ToString()));
                }
                con.Close();
                return idList;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// return a list of rooms, from our system
        /// </summary>
        /// <returns></returns>
        public static List<string> getRoomIdList()
        {
            try
            {
                List<string> idList = new List<string>();
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Room";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;

                con.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    idList.Add(dbr.GetValue(0).ToString());
                }
                con.Close();
                return idList;
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
                String query = "select * from dbo.Course where TEACHER_ID = '" + id + "'";
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
        /// get for us a room from the system, if exist
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public static Room getRoom(string room)
        {
            try
            {
                string roomNumber = room;
                int maxStudent = 0;

                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Room where room_number = '" + room + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {
                    if (room.Equals(dbr.GetValue(0)))
                    {
                        maxStudent = (int)dbr.GetValue(1);
                    }
                }
                con.Close();
                if (maxStudent == 0)
                {
                    return null;
                }
                return new Room(roomNumber, maxStudent);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// check if a single room is exist in our system
        /// </summary>
        /// <param name="Rname"></param>
        /// <returns></returns>
        public static bool roomExist(string Rname)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Room where room_number = " + "'" + Rname + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {
                    con.Close();
                    return true;
                }
                con.Close();
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        /// <summary>
        /// add a room to the system
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public static bool addRoom(Room room)
        {
            try
            {
                if (roomExist(room.getRoomNumber()))
                {
                    MessageBox.Show("Room already exists");
                    return false;
                }
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                SqlConnection con = new SqlConnection(str);
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.Room(room_number,max_student) VALUES(@room_number,@max_student)", con);

                //the "" + ulong ment to fit the data base type;
                //you can see here other option to convert https://msdn.microsoft.com/en-us/library/2wfez910(v=vs.110).aspx
                sqlCommand.Parameters.AddWithValue("@room_number", "" + room.getRoomNumber());
                sqlCommand.Parameters.AddWithValue("@max_student", "" + room.getMaxStudent());

                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// check if a single course exist in our system, by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Boolean courseExist(int id)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Course where COURSE_ID = " + id;
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
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// add a course to the system
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public static bool addCourse(Course course)
        {
            int course_mandatory = 1;
            int mandatory_presence = 1;
            try
            {
                if (courseExist(course.getID()))
                {
                    return false;
                }
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                SqlConnection con = new SqlConnection(str);
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.Course(COURSE_ID,COURSE_NAME,TEACHER_ID,MAX_STUDENTS,ROOM_NUMBER,COURSE_DAY,START_HOUR,END_HOUR,COURSE_SEMESTER,IS_MANDATORY,MANDATORY_PRESENCE,Track,Points) VALUES(@COURSE_ID,@COURSE_NAME,@TEACHER_ID,@MAX_STUDENTS,@ROOM_NUMBER,@COURSE_DAY,@START_HOUR,@END_HOUR,@COURSE_SEMESTER,@IS_MANDATORY,@MANDATORY_PRESENCE,@Track,@Points)", con);
                if (course.getIsMandatory() == false)
                {
                    course_mandatory = 0;
                }
                if (course.getMandatoryPresence() == false)
                {
                    mandatory_presence = 0;
                }

                //the "" + ulong ment to fit the data base type;
                //you can see here other option to convert https://msdn.microsoft.com/en-us/library/2wfez910(v=vs.110).aspx
                sqlCommand.Parameters.AddWithValue("@COURSE_ID", "" + course.getID());
                sqlCommand.Parameters.AddWithValue("@COURSE_NAME", "" + course.getName());
                sqlCommand.Parameters.AddWithValue("@TEACHER_ID", "" + course.getTeacherID());
                sqlCommand.Parameters.AddWithValue("@MAX_STUDENTS", "" + course.getMaxStudents());
                sqlCommand.Parameters.AddWithValue("@ROOM_NUMBER", "" + course.getRoom());
                sqlCommand.Parameters.AddWithValue("@COURSE_DAY", "" + course.getDay());
                sqlCommand.Parameters.AddWithValue("@START_HOUR", "" + course.getStart());
                sqlCommand.Parameters.AddWithValue("@END_HOUR", "" + course.getEnd());
                sqlCommand.Parameters.AddWithValue("@COURSE_SEMESTER", "" + course.getSemester());
                sqlCommand.Parameters.AddWithValue("@Track", "");
                sqlCommand.Parameters.AddWithValue("@Points", "" + course.getCreditPoints());
                sqlCommand.Parameters.AddWithValue("@IS_MANDATORY", "" + course_mandatory);
                sqlCommand.Parameters.AddWithValue("@MANDATORY_PRESENCE", "" + mandatory_presence);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// return a single course, from our system
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Course getCourse(int id)
        {
            try
            {
                int ID = id;
                string NAME = "";
                ulong TEACHERID = 0;
                int MAXSTUDENTS = 0;
                string ROOM = "";
                string DAY = "";
                int START = 0;
                int END = 0;
                int SEMESTER = 0;
                float CREDITPOINTS = 0;
                int mandatory = 0;
                int mandatory_presence = 0;
                bool MANDATORY_B = false;
                bool MANDATORY_PRESENCE_B = false;
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Course where COURSE_ID = '" + id + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {
                    if (id.Equals(dbr.GetValue(0)))
                    {
                        NAME = dbr.GetValue(1).ToString();
                        TEACHERID = publicChecksAndOperations.convertToUlong(dbr.GetValue(2).ToString());
                        MAXSTUDENTS = (int)dbr.GetValue(3);
                        ROOM = dbr.GetValue(4).ToString();
                        DAY = dbr.GetValue(5).ToString();
                        START = (int)dbr.GetValue(6);
                        END = (int)dbr.GetValue(7);
                        SEMESTER = (int)dbr.GetValue(8);
                        string check = dbr.GetValue(10).ToString();
                        if (check != "")
                        {
                            CREDITPOINTS = float.Parse(check);
                        }
                        if (dbr.GetValue(11).ToString() != "") mandatory = (int)dbr.GetValue(11);
                        if (mandatory == 1)
                        {
                            MANDATORY_B = true;
                        }
                        if (dbr.GetValue(12).ToString() != "") mandatory_presence = (int)dbr.GetValue(12);
                        if (mandatory_presence == 1)
                        {
                            MANDATORY_PRESENCE_B = true;
                        }
                    }
                }
                con.Close();
                if (NAME == "" && TEACHERID == 0 && MAXSTUDENTS == 0 && ROOM == "" && DAY == "" && START == 0 && END == 0 && SEMESTER == 0 && CREDITPOINTS == 0 && !MANDATORY_B && !MANDATORY_PRESENCE_B)
                {
                    return null;
                }
                return new Course(ID, NAME, TEACHERID, MAXSTUDENTS, ROOM, DAY, START, END, SEMESTER, CREDITPOINTS, MANDATORY_B, MANDATORY_PRESENCE_B);
            }
            catch (Exception e)
            {
                throw e;
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

        /// <summary>
        /// change the status of the instructor constraint option, by sending a status to the system
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static bool setConstraintStatusInst(bool status)
        {
            return setConstraintStatusProf(status, 2);
        }

        /// <summary>
        /// change the status of the professor constraint option, by sending a status to the system
        /// </summary>
        /// <param name="status"></param>
        /// <param name="iORp">instructor or professor</param>
        /// <returns></returns>
        public static bool setConstraintStatusProf(bool status, int iORp = 1)
        {
            int set_constraints = 1;
            if (status)
            {
                set_constraints = 1;
            }
            else
            {
                set_constraints = 0;
            }

            try
            {
                string str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                string query = "UPDATE dbo.GLOBAL_OPERATION SET ENTER_CONSTRAINTS = " + set_constraints + "WHERE ID = " + iORp;
                SqlConnection con = new SqlConnection(str);
                SqlCommand sqlCommand = new SqlCommand(query, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// return the status of the instructor constraint option, from the system
        /// </summary>
        /// <returns></returns>
        public static bool getConstraintStatusInst()
        {
            return getConstraintStatusProf(2);
        }

        /// <summary>
        /// return the status of the professor constraint option, from the system
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool getConstraintStatusProf(int id = 1)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from GLOBAL_OPERATION where id = '" + id + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();
                //int count = 0;
                while (dbr.Read())
                {
                    int w = (int)dbr.GetValue(1);
                    if (w == 1)
                    {
                        con.Close();
                        return true;
                    }

                }
                con.Close();
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// return the id, by sending a mail to the system
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public static ulong getIdByMail(string mail)
        {
            try
            {
                string to_return = "";
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from dbo.Users where MAIL = '" + mail + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {
                    to_return = dbr.GetValue(0).ToString();
                }
                con.Close();
                return publicChecksAndOperations.convertToUlong(to_return);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// check if the user already exist in the facebook system, by sending mail and userType to the system
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        public static Boolean facebookUserExist(string mail, string userType)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from Users where MAIL = '" + mail + "'and ACCESSGROUP = '" + userType + "'";
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
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// check if the user already exist in the system, by sending password and userType to the system
        /// </summary>
        /// <param name="password"></param>
        /// <param name="id"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        public Boolean userExist(String password, ulong id, String userType)
        {
            try
            {
                String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                String query = "select * from Users where ID = '" + id + "'and ACCESSGROUP = '" + userType + "'and PASS = '" + password + "'";
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

        /// <summary>
        /// get a list of courses, by typing id from the system
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// sign in a single person, to our system
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="password"></param>
        /// <param name="id"></param>
        /// <param name="userType"></param>
        /// <returns></returns>

        public Boolean signPerson(String Name, String password, int id, String userType)
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

        /// <summary>
        /// initialize our data base connection
        /// </summary>
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

        /// <summary>
        /// open connection to our data base
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// check the connection to our data base
        /// </summary>
        /// <param name="ConnStatus"></param>
        public void CloseConn(Boolean ConnStatus)
        {
            if (ConnStatus == true)
            {
                con.Close();
            }

        }

        /// <summary>
        /// get our connection
        /// </summary>
        /// <returns></returns>
        public SqlConnection getConnection() { return con; }

        /// <summary>
        /// get published schedule
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool getPublishedSched(ulong id)
        {
            try
            {
                bool returnValue = false;
                string str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                string query = "select * from dbo.Users where Id = '" + id + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    if (Int32.Parse(id.ToString()) == (int)dbr.GetValue(0))
                    {
                        if (dbr.GetValue(7) != null)
                        {
                            if ((int)dbr.GetValue(7) == 1) returnValue = true;
                        }
                    }
                }
                con.Close();
                return returnValue;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// publish schedule
        /// </summary>
        /// <param name="id"></param>
        public void publishSched(ulong id)
        {
            try
            {
                string str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                string query = "UPDATE dbo.Users SET PUBLISHEDSCHED = " + 1 + "WHERE ID = " + id;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
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
    }
}
