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
    public partial class Form_studentRequiredCourses : Form
    {
        DBconnect connection;
        SqlCommand command;
        private string username;
        public Form_studentRequiredCourses(string un)
        {
            username = un;
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
            command.CommandText = "SELECT Course.* FROM Course, Student WHERE Student.semester = Course.course_semester and Student.username = @username";
            command.Parameters.AddWithValue("username", username);
        }

        private void UpdateListView()
        {
            try
            {
                DataSet ds = connection.generalCommand(command);
                if (ds.Tables.Count > 0)
                {
                    NeededCoursesGridView.AutoGenerateColumns = true;
                    NeededCoursesGridView.DataSource = ds.Tables[0];
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

        private void Form_studentRequiredCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_studentMenu parent = (Form_studentMenu)this.Owner;
            parent.Show();
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
