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
    public partial class Form_adminManageAccountMenu : Form
    {
        public Form_adminManageAccountMenu()
        {
            InitializeComponent();
        }


        private void addAccountClick(object sender, EventArgs e)
        {
            using (Form_adminAddStudent addStudentBox = new Form_adminAddStudent())
            {
                this.Hide();
                addStudentBox.ShowDialog(this);
            }

        }

        private void addAssociateClick(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");

        }

        private void deleteStudentClick(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");

        }

        private void deleteAssociateClick(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");

        }

        private void BackClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_adminManageAccountMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_adminMenu parent = (Form_adminMenu)this.Owner;
            parent.Show();
        }
    }
}
