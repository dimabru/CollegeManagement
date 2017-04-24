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
       private String username;
        public Form_studentMenu()
        {
            
            InitializeComponent();
        }
        public void setUsername(String username)
        {
            this.username = username;
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

        }

        private void StudentRequestButton_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            using (Form_studentAddRequest studentRequestMenu = new Form_studentAddRequest())
            {
                this.Hide();

                studentRequestMenu.MdiParent = this;
                studentRequestMenu.setUsername(username);
                studentRequestMenu.Show();
            }
        }

        private void CoursesMenuButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        /// 
        /// REQUEST MENU
        /// 

        private void NewRequestButton_Click(object sender, EventArgs e)
        {

            this.IsMdiContainer = true;
            Form_studentAddRequest addRequest = new Form_studentAddRequest();

            addRequest.MdiParent = this;
            addRequest.setUsername(username);
            addRequest.Show();
        }


        private void ExistingRequestsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        ///    ASSSOCIATION MENU
        ///
        ///
        private void AssociationInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void RegisterEventsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void UnregisterEventsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        ///
        ///     COURSES MENU
        ///

        private void MandatoryCoursesListButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void WatchCoursesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void ChangeCourseTimeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
