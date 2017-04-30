using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3.Classes;

namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    public partial class Form_secretaryManageStudent : Form
    {
        private Student student;

        public Form_secretaryManageStudent(Student student)
        {
            this.student = student;
            InitializeComponent();
            
        }

        private void Form_secretaryManageStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryStudentSearch parent = (Form_secretaryStudentSearch)this.Owner;
            parent.clearSearchResults();
            parent.Show();
        }

        private void CoursesReport_Click(object sender, EventArgs e)
        {
            using (Form_secretaryStudentCoursesReport manageStudentCourses = new Form_secretaryStudentCoursesReport(student))
            {
                this.Hide();
                manageStudentCourses.ShowDialog(this);
            }
        }
    }
}
