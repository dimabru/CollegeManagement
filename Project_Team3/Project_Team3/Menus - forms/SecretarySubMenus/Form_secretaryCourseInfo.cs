using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3.Classes;
using System.Data.SqlClient;

namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    public partial class Form_secretaryCourseInfo : Form
    {
        private Course course;
        DBconnect connection;
        SqlCommand command;
        public Form_secretaryCourseInfo(Course cr)
        {
            course = cr;
            InitializeComponent();
            labelID.Text = "ID:\n" + course.ID.ToString();
            labelName.Text = "Name:\n" + course.Name;
            labelTeacherID.Text = "Teacher ID:\n" + course.Teacher_id.ToString();
            labelMaxStudents.Text = "Maximum Students:\n" + course.Max_students.ToString();
            labelRoom.Text = "Room:\n" + course.Room;
            labelDay.Text = "Day:\n" + course.Day;
            labelStart_H.Text = "Start Hour:\n" + course.Start_hour.ToString();
            labelEnd_H.Text = "End Hour:\n" + course.End_hour.ToString();
            labelSemester.Text = "Semester:\n" + course.Semester.ToString();
            labelTrack.Text = "Track:\n" + course.Track;
            Init();
            UpdateGrid();
        }
        private void Init()
        {
            connection = new DBconnect();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection.getConnection();
            connection = new DBconnect();
            command.CommandText = "SELECT * FROM Course where course_id != @id and course_name = @name order by course_id";
            command.Parameters.AddWithValue("name", course.Name);
            command.Parameters.AddWithValue("id", course.ID);
        }

        private void UpdateGrid()
        {
            try
            {
                DataSet ds = connection.generalCommand(command);
                if (ds.Tables.Count > 0)
                {
                    CoursesGrid.AutoGenerateColumns = true;
                    CoursesGrid.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form_secretaryCourseInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryCourseSearch parent = (Form_secretaryCourseSearch)this.Owner;
            parent.clearSearchResults();
            parent.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
