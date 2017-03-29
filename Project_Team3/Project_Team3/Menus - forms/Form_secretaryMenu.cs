using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3.Menus___forms.SecretarySubMenus;

namespace Project_Team3
{
    public partial class Form_secretaryMenu : Form
    {
        public Form_secretaryMenu()
        {
            InitializeComponent();
        }

        private void coursesReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Courses Reports are not available yet");
        }

        private void studentSearchButton_Click(object sender, EventArgs e)
        {
            using (Form_secretaryStudentSearch studentSearch = new Form_secretaryStudentSearch())
            {
                this.Hide();
                studentSearch.ShowDialog(this);
            }
        }

        private void searchCourseButton_Click(object sender, EventArgs e)
        {
            using (Form_secretaryCourseSearch courseSearch = new Form_secretaryCourseSearch())
            {
                this.Hide();
                courseSearch.ShowDialog(this);
            }

        }

        private void associationEventsButton_Click(object sender, EventArgs e)
        {
            using (Form_secretaryAssociationEvents associationEvents = new Form_secretaryAssociationEvents())
            {
                this.Hide();
                associationEvents.ShowDialog(this);
            }
        }

        private void studentRequestsButton_Click(object sender, EventArgs e)
        {
            using (Form_secretaryStudentRequests studentRequests = new Form_secretaryStudentRequests())
            {
                this.Hide();
                studentRequests.ShowDialog(this);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
