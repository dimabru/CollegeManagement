﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3.Classes;
namespace Project_Team3.Menus___forms.AdminSubMenus
{
    public partial class Form_adminAddAssociate : Form
    {
        public Form_adminAddAssociate()
        {
            InitializeComponent();
        }

        private void generalLabel_Click(object sender, EventArgs e)
        {

        }

        private void semester_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondName_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstname_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void semesterLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void surenameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToDatabase_Click(object sender, EventArgs e)
        {
            User newAssociate;
            FunctionsForAllProgram funcs = new FunctionsForAllProgram();
            String username = this.username_box.Text;
            String id = this.id_box.Text;
            int id_int = -1;
            try
            {
                id_int = Convert.ToInt32(id);
            }
            catch
            {
                MessageBox.Show("ID field contains non-digit symbols this field is empty!");
                return;
            }

            bool userExists = funcs.ifUserInDatabase(username) || funcs.ifUserIDinDatabase(id_int);
            if (userExists == false)
            {
                String Name = this.firstname_box.Text, surename = this.secondName_box.Text, password = this.password_box.Text;

                newAssociate = new User(id, username, Name, surename, password);
                DBconnect db = new DBconnect();
                try
                {
                    db.addUserToDB(newAssociate);
                    MessageBox.Show("New Associate member been added to database!");
                }
                catch
                {
                    MessageBox.Show("Something went wrong, user not been added! \ncheck your database connection and fields correctness and try again!");
                }
            }
        }

        private void Form_adminAddAssociate_Load(object sender, EventArgs e)
        {

        }
    }
}
