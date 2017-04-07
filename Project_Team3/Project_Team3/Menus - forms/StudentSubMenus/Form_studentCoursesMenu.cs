using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.Menus___forms.StudentSubMenus
{
    public partial class Form_studentCoursesMenu : Form
    {
        public Form_studentCoursesMenu()
        {
            InitializeComponent();
        }

        private void Form_studentCoursesMenu_Load(object sender, EventArgs e)
        {

        }

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

        private void BackToLastCoursesMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_studentCoursesMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_studentMenu parent = (Form_studentMenu)this.Owner;
            parent.Show();
        }
    }
}
