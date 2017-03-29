using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    public partial class Form_secretaryStudentSearch : Form
    {
        public Form_secretaryStudentSearch()
        {
            InitializeComponent();
        }

        private void Form_secretaryStudentSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryMenu parent = (Form_secretaryMenu)this.Owner;
            parent.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchValueTextBox.Text = "";
            MessageBox.Show("Student Details not available yet");

        }
    }
}
