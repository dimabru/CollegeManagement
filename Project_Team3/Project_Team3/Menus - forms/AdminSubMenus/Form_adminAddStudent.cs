using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.Menus___forms.AdminSubMenus
{
    public partial class Form_adminAddStudent : Form
    {
        public Form_adminAddStudent()
        {
            InitializeComponent();
        }

        private void Form_adminAddStudent_Load(object sender, EventArgs e)
        {
        }

        private void addStudentToDatabase_Click(object sender, EventArgs e)
        {

            Classes.Student newStudent;
            Project_Team3.Classes.FunctionsForAllProgram funcs = new Classes.FunctionsForAllProgram();
            String username = this.username_box.Text;
            String id = this.id_box.Text;
            int id_int=-1;
            
            if (checkFields() == false)
            {
                return;
            }

            try
            {
                id_int = Convert.ToInt32(id);
            }
            catch
            {
                MessageBox.Show("Unsuccessfull convertion attempt string ID to Int or ID field is empty!");
                return;
            }
            bool usernameExists = funcs.ifUserInDatabase(username);
            if (usernameExists)
                MessageBox.Show("User with username " + username + " already exists");

            bool userIdExists = funcs.ifUserIDinDatabase(id_int);
            if (userIdExists)
                MessageBox.Show("User with id " + id_int + " already exists");

            bool userExists = usernameExists || userIdExists;

            if (userExists == false )
            {
                String Name = this.firstname_box.Text, surename=this.secondName_box.Text, password = this.password_box.Text;
                int semester;
                try
                {
                    semester = Convert.ToInt32(this.semester_box.Text);
                    if (semester < 0 || semester > 8)
                    {
                        MessageBox.Show("Semester value must been 1-8");
                        return;
                    }
                }
                catch
                {
                    semester = 1;
                }
                string email = this.email_Box.Text;
                bool emailExists = funcs.ifEmailInDatabase(email);
                if (emailExists)
                {
                    MessageBox.Show("User with email " + email + " already exists");
                    return;
                }
                newStudent = new Classes.Student(id, username, Name, surename, password, semester, email);
                DBconnect db = new DBconnect();
                try
                {
                    db.addStudentToDB(newStudent);
                    MessageBox.Show("New Student been added to database!");
                }
                catch
                {
                    MessageBox.Show("Something went wrong, user not been added! \ncheck your database connection and fields correctness and try again!");
                }
            }
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool checkFields()
        {
            if (string.IsNullOrWhiteSpace(id_box.Text))
            {
                MessageBox.Show("ID field can not be empty!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(username_box.Text))
            {
                MessageBox.Show("Username field can not be empty!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(firstname_box.Text))
            {
                MessageBox.Show("First name field can not be empty!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(secondName_box.Text))
            {
                MessageBox.Show("Second name field can not be empty!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(password_box.Text))
            {
                MessageBox.Show("Password field can not be empty!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(semester_box.Text))
            {
                MessageBox.Show("Semester field can not be empty!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(email_Box.Text))
            {
                MessageBox.Show("Email field can not be empty!");
                return false;
            }
            return true;
        }

        private void Form_adminAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_adminManageAccountMenu parent = (Form_adminManageAccountMenu)this.Owner;
            parent.Show();
        }
    }
}
