using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3.Menus___forms.AdminSubMenus;

namespace Project_Team3
{
    public partial class Form_adminMenu : Form
    {
        public Form_adminMenu()
        {
            InitializeComponent();
        }

        private void Form_adminMenu_Load(object sender, EventArgs e)
        {

        }


        private void manageAccountsButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Form Account_Managment = new Form_adminAccountsMenu();
            Account_Managment.BringToFront();
            Account_Managment.Show();

        }


        private void globalMessageButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }


        private void Form_adminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_login parent = (Form_login)this.Owner;
            parent.Show();
        }

        private void coursesMenuButtonClick(object sender, EventArgs e)
        {
            Form coursesMenu = new Form_adminCoursesMenu();
            this.Hide();
            coursesMenu.Show();
            coursesMenu.BringToFront();
        }

        private void accountsMenuButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void logoutButtonClick(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
