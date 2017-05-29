using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.Menus___forms.StudentSubMenus
{
    public partial class Form_studentChangeCourse : Form
    {
        string username;
        DBconnect connection;

        public Form_studentChangeCourse()
        {
            InitializeComponent();
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_studentChangeCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_studentMenu parent = (Form_studentMenu)this.Owner;
            parent.Show();
        }

        private void LoadDataToGrid()
        {

            connection = new DBconnect();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection.getConnection();
            connection = new DBconnect();
            command.CommandText = "SELECT Course.COURSE_NAME,course.room_number,course.course_day,course.start_hour,course.end_hour FROM Course WHERE Course.COURSE_SEMESTER = (SELECT student.semester FROM student where student.username = @username)";
            command.Parameters.AddWithValue("username", Username);
            try
            {
                DataSet ds = connection.generalCommand(command);
                if (ds.Tables.Count > 0)
                {
                    showCoursesGrid.AutoGenerateColumns = true;
                    showCoursesGrid.DataSource = ds.Tables[0];
                    showCoursesGrid.Columns[0].HeaderText = "Course";
                    showCoursesGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    showCoursesGrid.Columns[1].HeaderText = "Room";
                    showCoursesGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    showCoursesGrid.Columns[2].HeaderText = "Day";
                    showCoursesGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    showCoursesGrid.Columns[3].HeaderText = "Start Hour";
                    showCoursesGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    showCoursesGrid.Columns[4].HeaderText = "End Hour";
                    showCoursesGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    MessageBox.Show("No Record Found");
                    this.Close();
                }
            }
            catch (Exception)
            {

            }
        }


        private void Form_studentChangeCourse_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void request_change_Click(object sender, EventArgs e)
        {
            string course_name = showCoursesGrid[0, showCoursesGrid.CurrentRow.Index].Value.ToString();
            string startH = showCoursesGrid[3, showCoursesGrid.CurrentRow.Index].Value.ToString(); ;
            string endH = showCoursesGrid[4, showCoursesGrid.CurrentRow.Index].Value.ToString();
            string messageBody = "Please change my signup to course " + course_name+" from hour "+startH+" till "+endH;
            MessageBox.Show("Your request to : \n"+messageBody+"\n\nBeen sended to processing");
            string querry = "insert into StudentRequests values('" + username + "', '" + messageBody + "','New request','All secretaries')";
            connection.executionQuery(querry);

        }


    }
}
