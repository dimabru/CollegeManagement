using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3.Menus___forms.StudentSubMenus;


namespace Project_Team3
{
    public partial class Form_studentMenu : Form
    {
        public Form_studentMenu()
        {
            InitializeComponent();
        }

        private void Form_studentMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void Form_studentMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_login parent = (Form_login)this.Owner;
            parent.Show();
        }

        private void AssociationMenuButton_Click(object sender, EventArgs e)
        {
            using (Form associationMenu = new Form_studentAssociationMenu())
            {
                this.Hide();
                associationMenu.ShowDialog(this);
            }
        }

        private void StudentRequestButton_Click(object sender, EventArgs e)
        {
            using (Form studentRequestMenu = new Form_studentRequestMenu())
            {
                this.Hide();
                studentRequestMenu.ShowDialog(this);
            }
        }

        private void CoursesMenuButton_Click(object sender, EventArgs e)
        {
            using (Form studentCoursesMenu = new Form_studentCoursesMenu())
            {
                this.Hide();
                studentCoursesMenu.ShowDialog(this);
            }
        }

        private void LogoutStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
