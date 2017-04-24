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
    public partial class Form_secretaryStudentSearch : Form
    {
        DBconnect connection ;
        SqlCommand command;

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

        private void updateResults(DataSet ds)
        {
            //TODO DRISHA
            studentsResultListBox.Items.Clear();
            try
            {
                foreach (DataRow Student in ds.Tables[0].Rows)
                {
                    studentsResultListBox.Items.Add("Username: " + Student[0].ToString() + "\nFirstname: " + Student[1].ToString() + "\nLastname: " + Student[2].ToString());
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
            command.CommandText = "SELECT Users.username , Users.UName , Users.SName from Users JOIN Student ON Users.username = Student.username WHERE Users.UName = @name ";
            command.Parameters.AddWithValue("name", name);

            DataSet ds = connection.generalCommand(command);
            updateResults(ds);
        }

        private void searchByID(string id)
        {
            //TODO DRISHA
            command.CommandText = "SELECT Users.username , Users.UName , Users.SName from Users JOIN Student ON Users.username = Student.username WHERE Users.id = @id ";
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
    }
}
