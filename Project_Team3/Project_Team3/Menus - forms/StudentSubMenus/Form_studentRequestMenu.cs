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
    public partial class Form_studentRequestMenu : Form
    {
        public Form_studentRequestMenu()
        {
            InitializeComponent();
        }

        private void NewRequestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void ExistingRequestsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void BackToLastReqMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_studentRequestMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_studentMenu parent = (Form_studentMenu)this.Owner;
            parent.Show();
        }
    }
}
