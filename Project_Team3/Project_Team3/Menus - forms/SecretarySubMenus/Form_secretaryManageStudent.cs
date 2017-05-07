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
    public partial class Form_secretaryManageStudent : Form
    {
        private Student student;
        private DBconnect connection;
        private SqlCommand selectCoursesCommand;
        private SqlCommand insertScheduleCommand;
        private SqlCommand selectSchedulesCommand;

        public Form_secretaryManageStudent(Student student)
        {
            this.student = student;
            InitializeComponent();
            nameLabel.Text += student.Name + " " + student.Surename;
            usernameLabel.Text += student.Username;
            semesterLabel.Text += student.Semester;
            Init();
            UpdateCoursesDataGridView();
        }

        private void Init()
        {
            connection = new DBconnect();

            selectCoursesCommand = new SqlCommand();
            selectCoursesCommand.CommandType = CommandType.Text;
            selectCoursesCommand.Connection = connection.getConnection();
            selectCoursesCommand.CommandText = @"
                                                SELECT * FROM Course  
                                                WHERE COURSE_SEMESTER = @semester
                                                EXCEPT 
                                                SELECT Course.* FROM Course , Schedules
                                                WHERE Course.COURSE_ID=Schedules.COURSE_ID AND STUDENT_UN = @username
                                               ";
            selectCoursesCommand.Parameters.AddWithValue("semester", student.Semester);
            selectCoursesCommand.Parameters.AddWithValue("username", student.Username);

            selectSchedulesCommand = new SqlCommand();
            selectSchedulesCommand.CommandType = CommandType.Text;
            selectSchedulesCommand.Connection = connection.getConnection();
            selectSchedulesCommand.CommandText = @"
                                                    SELECT Schedules.COURSE_ID FROM Schedules 
                                                    WHERE STUDENT_UN=@username 
                                                    EXCEPT 
                                                    SELECT Schedules.COURSE_ID FROM Schedules,Course
                                                    WHERE
                                                    STUDENT_UN=@username
                                                    AND
                                                    Course.Course_ID=Schedules.COURSE_ID
                                                    AND
                                                    (
                                                    @day != COURSE_DAY
                                                    OR
                                                    (@end < START_HOUR AND @start < START_HOUR)
                                                    OR
                                                    (@end > END_HOUR AND @start > END_HOUR)
                                                    )
                                                    
                                                 ";
                                                    
            insertScheduleCommand = new SqlCommand();
            insertScheduleCommand.CommandType = CommandType.Text;
            insertScheduleCommand.Connection = connection.getConnection();
            insertScheduleCommand.CommandText = "INSERT INTO Schedules VALUES(@username,@courseid)";
            
        }

        private void UpdateCoursesDataGridView()
        {
            try
            {
                DataSet ds = connection.generalCommand(selectCoursesCommand);
                if (ds.Tables.Count > 0)
                {
                    coursesDataGridView.AutoGenerateColumns = true;
                    coursesDataGridView.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No Record Found");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int AddCourseToSchedule(int startHour, int endHour ,int courseID , string day)
        {
            selectSchedulesCommand.Parameters.Clear();
            selectSchedulesCommand.Parameters.AddWithValue("username", student.Username);
            selectSchedulesCommand.Parameters.AddWithValue("start", startHour);
            selectSchedulesCommand.Parameters.AddWithValue("end", endHour);
            selectSchedulesCommand.Parameters.AddWithValue("day", day);

            DataSet ds = connection.generalCommand(selectSchedulesCommand);

            if (ds.Tables[0].Rows.Count != 0) MessageBox.Show("Course overlapping with another course or event!");

            MessageBox.Show(courseID + " " + startHour + " " + endHour);


            return -1;
        }
        private void Form_secretaryManageStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryStudentSearch parent = (Form_secretaryStudentSearch)this.Owner;
            parent.clearSearchResults();
            parent.Show();
        }

        private void CoursesReport_Click(object sender, EventArgs e)
        {
            using (Form_secretaryStudentCoursesReport manageStudentCourses = new Form_secretaryStudentCoursesReport(student))
            {
                this.Hide();
                manageStudentCourses.ShowDialog(this);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(coursesDataGridView.SelectedRows[0].Cells[0].Value);
            string day = coursesDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            int startHour = Convert.ToInt32(coursesDataGridView.SelectedRows[0].Cells[6].Value);
            int endHour = Convert.ToInt32(coursesDataGridView.SelectedRows[0].Cells[7].Value);

            AddCourseToSchedule(startHour, endHour, id , day);
        }
    }
}
