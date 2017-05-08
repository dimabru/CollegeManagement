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
    public partial class Form_studentRegisteredCourses : Form
    {
        DBconnect connection;
        SqlCommand command;
        private string username;
        public Form_studentRegisteredCourses(string un)
        {
            username = un;
            InitializeComponent();
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
            command.CommandText = "SELECT Course.* FROM Course, Schedules WHERE Course.course_id = Schedules.course_id and Schedules.student_un = @username";
            command.Parameters.AddWithValue("username", username);
        }
        private void Form_studentRegisteredCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_studentMenu parent = (Form_studentMenu)this.Owner;
            parent.Show();
        }
        private void UpdateGrid()
        {
            try
            {
                DataSet ds = connection.generalCommand(command);
                if (ds.Tables.Count > 0)
                {
                    CoursesGridView.AutoGenerateColumns = true;
                    CoursesGridView.DataSource = ds.Tables[0];
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

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
