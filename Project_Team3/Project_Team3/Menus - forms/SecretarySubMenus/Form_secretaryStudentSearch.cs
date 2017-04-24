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
    public partial class Form_secretaryStudentSearch : Form
    {
        DBconnect connection ;
        SqlCommand command;
        private Student selectedStudent;

        public Form_secretaryStudentSearch()
        {
            InitializeComponent();
            connection = new DBconnect();

        }

        private void Form_secretaryStudentSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryMenu parent = (Form_secretaryMenu)this.Owner;
            parent.Show();
        }

        public void clearSearchResults()
        {
            studentsResultListBox.Items.Clear();

        }

        private void updateResults(DataSet ds)
        {
            //TODO DRISHA
            clearSearchResults();
            try
            {
                foreach (DataRow student in ds.Tables[0].Rows)
                {
                    Student currentStudent = new Student(student[0].ToString(), student[1].ToString(), student[2].ToString(), student[3].ToString(), student[4].ToString(), Convert.ToInt32(student[5]));
                    studentsResultListBox.Items.Add(currentStudent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void searchByName(string name)
        {
            //TODO DRISHA
            command.CommandText = "SELECT Users.ID, Users.username, Users.UName, Users.SName, Users.pass, Student.Semester from Users JOIN Student ON Users.username = Student.username WHERE Users.UName = @name ";
            command.Parameters.AddWithValue("name", name);
            DataSet ds = connection.generalCommand(command);
            updateResults(ds);
        }

        private void searchByID(string id)
        {
            //TODO DRISHA
            command.CommandText = "SELECT Users.ID, Users.username, Users.UName, Users.SName, Users.pass, Student.Semester from Users JOIN Student ON Users.username = Student.username WHERE Users.id = @id ";
            command.Parameters.AddWithValue("id", id);

            DataSet ds = connection.generalCommand(command);
            updateResults(ds);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection.getConnection();

            if (nameRadioButton.Checked)
            {
                searchByName(searchValueTextBox.Text);
            }
            else
            {
                //TODO DRISHA
                try
                {
                    Convert.ToInt32(searchValueTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                searchByID(searchValueTextBox.Text);
                
            }
            searchValueTextBox.Text = "";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void manageCourseButton_Click(object sender, EventArgs e)
        {
            if (studentsResultListBox.SelectedItem == null) { MessageBox.Show("No Student selected!"); return; }
            selectedStudent =(Student)studentsResultListBox.SelectedItem;
            using (Form_secretaryManageStudent manageStudentCourses = new Form_secretaryManageStudent(selectedStudent)) 
            {
                this.Hide();
                manageStudentCourses.ShowDialog(this);
            }
        }
    }
}
