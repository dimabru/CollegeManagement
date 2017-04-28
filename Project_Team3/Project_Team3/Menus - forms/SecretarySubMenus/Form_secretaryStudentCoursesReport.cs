using Project_Team3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    public partial class Form_secretaryStudentCoursesReport : Form
    {
        private Student student;
        DBconnect connection;
        SqlCommand command;
        public Form_secretaryStudentCoursesReport(Student student)
        {
            this.student = student;
            InitializeComponent();
            Init();
            UpdateListView();
        }

        private void Init()
        {
            connection = new DBconnect();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection.getConnection();
            connection = new DBconnect();
            command.CommandText = "SELECT Course.Course_ID, Course.Course_name, Course.teacher_id, Course.room_number, Course.course_day, Course.start_hour, Course.end_hour, Course.course_semester from Schedules, Course WHERE Schedules.Student_UN = @username and Schedules.Course_id = Course.course_id";
            command.Parameters.AddWithValue("username", student.Username);
        }

        private void UpdateListView(){
            DataSet ds = connection.generalCommand(command);
            CoursesReport.Items.Clear();
            int counter = 1;
            try
            {
                foreach (DataRow course in ds.Tables[0].Rows)
                {
                    ListViewItem lv = new ListViewItem(counter.ToString());
                    for (int i = 0; i < 8; i++)
                        lv.SubItems.Add(Regex.Replace(course[i].ToString(), @"\s+", ""));
                    CoursesReport.Items.Add(lv);
                    counter++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form_secretaryStudentCoursesReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryManageStudent parent = (Form_secretaryManageStudent)this.Owner;
            parent.Show();
        }
    }
}
