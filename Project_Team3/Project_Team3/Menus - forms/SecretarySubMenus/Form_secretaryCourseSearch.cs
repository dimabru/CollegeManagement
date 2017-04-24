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

namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    public partial class Form_secretaryCourseSearch : Form
    {
        DBconnect connection;
        SqlCommand command;

        public Form_secretaryCourseSearch()
        {
            InitializeComponent();
            connection = new DBconnect();
        }

        private void Form_secretaryCourseSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryMenu parent = (Form_secretaryMenu)this.Owner;
            parent.Show();
        }

        private void updateResults(DataSet ds)
        {
            //TODO DRISHA
            coursesResultsListBox.Items.Clear();
            try
            {
                foreach (DataRow course in ds.Tables[0].Rows)
                {
                    coursesResultsListBox.Items.Add(course[0].ToString());
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
            command.CommandText = "SELECT Course.Course_Name FROM Course WHERE Course.Course_Name = @name";
            command.Parameters.AddWithValue("name", name);

            DataSet ds = connection.generalCommand(command);
            updateResults(ds);
        }

        private void searchByID(string id)
        {
            //TODO DRISHA
            command.CommandText = "SELECT Course.Course_Name FROM Course WHERE Course.Course_ID = @id";
            command.Parameters.AddWithValue("id", id);

            DataSet ds = connection.generalCommand(command);
            updateResults(ds);

        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection.getConnection();

            if (courseNameRadio.Checked)
            {
                searchByName(courseValueTextBox.Text);
            }
            else
            {
                //TODO DRISHA
                try
                {
                    Convert.ToInt32(courseValueTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                searchByID(courseValueTextBox.Text);

            }
            courseValueTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
