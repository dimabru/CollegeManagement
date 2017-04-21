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
            try
            {
                id_int = Convert.ToInt32(id);
            }
            catch
            {
                MessageBox.Show("Unsuccessfull convertion attempt string ID to Int or ID field is empty!");
                return;
            }

            bool userExists = funcs.ifUserInDatabase(username) || funcs.ifUserIDinDatabase(id_int);
            if (userExists == false)
            {
                String Name = this.firstname_box.Text, surename=this.secondName_box.Text, password = this.password_box.Text;
                int semester;
                try
                {
                    semester = Convert.ToInt32(this.semester_box.Text);
                    if (semester < 0 || semester > 8)
                    {
                        MessageBox.Show("Semester value must been 1-8, default value 1 been setted");
                        semester = 1;
                    }
                }
                catch
                {
                    semester = 1;
                }

                newStudent = new Classes.Student(id, username, Name, surename, password, semester);
                DBconnect db = new DBconnect();
                try
                {
                    db.addStudentToDB(newStudent);
                    MessageBox.Show("New Student been received to database!");
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
    }
}
