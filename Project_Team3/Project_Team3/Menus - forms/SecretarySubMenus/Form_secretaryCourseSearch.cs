using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_Team3.Classes;

namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    public partial class Form_secretaryCourseSearch : Form
    {
        DBconnect connection;
        SqlCommand command;
        private Course selectedCourse;
        public Form_secretaryCourseSearch()
        {
            InitializeComponent();
            connection = new DBconnect();
            command = new SqlCommand();
        }

        private void Form_secretaryCourseSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryMenu parent = (Form_secretaryMenu)this.Owner;
            parent.Show();
        }
        public void clearSearchResults()
        {
            coursesResultsListBox.Items.Clear();

        }

        private void updateResults(DataSet ds)
        {
            //TODO DRISHA
            coursesResultsListBox.Items.Clear();
            try
            {
                foreach (DataRow course in ds.Tables[0].Rows)
                {
                    Course currentCourse = new Course(Convert.ToInt32(course[0]), course[1].ToString(),
                        Convert.ToInt32(course[2]), Convert.ToInt32(course[3]), course[4].ToString(),
                        course[5].ToString(), Convert.ToInt32(course[6]), Convert.ToInt32(course[7]),
                        Convert.ToInt32(course[8]), course[9].ToString());
                    coursesResultsListBox.Items.Add(currentCourse);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool searchByName(string name)
        {
            if (name == "") return false;
            command.CommandText = "SELECT * FROM Course WHERE Course.Course_Name = @name";
            command.Parameters.AddWithValue("name", name);

            DataSet ds = connection.generalCommand(command);
            updateResults(ds);

            return true;
        }

        private string searchByID(string id)
        {
            if (id == "") return "ID Cannot be empty";

            try
            {
                Convert.ToInt32(id);
            }
            catch (Exception)
            {
                return "ID Can be represented only by numbers";
            }

            command.CommandText = "SELECT * FROM Course WHERE Course.Course_ID = @id";
            command.Parameters.AddWithValue("id", id);

            DataSet ds = connection.generalCommand(command);
            updateResults(ds);

            return "Success";

        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            command.CommandType = CommandType.Text;
            command.Connection = connection.getConnection();

            if (courseNameRadio.Checked)
            {
                if (!searchByName(courseValueTextBox.Text)) MessageBox.Show("Name cannot be empty!");
            }
            else
            {
                //TODO DRISHA
               
                string message = searchByID(courseValueTextBox.Text);
                if (message != "Success") MessageBox.Show(message);

            }
            courseValueTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CourseInfoButton_Click(object sender, EventArgs e)
        {
            if (coursesResultsListBox.SelectedItem == null) { MessageBox.Show("No Course selected!"); return; }
            selectedCourse = (Course)coursesResultsListBox.SelectedItem;
            using (Form_secretaryCourseInfo CourseInfo = new Form_secretaryCourseInfo(selectedCourse))
            {
                this.Hide();
                CourseInfo.ShowDialog(this);
            }
        }
    }
}
