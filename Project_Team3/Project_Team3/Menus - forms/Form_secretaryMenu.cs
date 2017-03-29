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
            this.Hide();
            Form studentSearch = new Form_secretaryStudentSearch();
            studentSearch.ShowDialog();
        }

        private void searchCourseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form courseSearch = new Form_secretaryCourseSearch();
            courseSearch.ShowDialog();

        }

        private void associationEventsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form associationEvents = new Form_secretaryAssociationEvents();
            associationEvents.ShowDialog();
        }
    }
}
