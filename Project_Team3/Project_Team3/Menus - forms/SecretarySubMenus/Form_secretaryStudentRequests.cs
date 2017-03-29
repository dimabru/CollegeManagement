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
    public partial class Form_secretaryStudentRequests : Form
    {
        public Form_secretaryStudentRequests()
        {
            InitializeComponent();
        }

        private void Form_secretaryStudentRequests_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryMenu parent = (Form_secretaryMenu)this.Owner;
            parent.Show();
        }

        private void detailsRequestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Details not available yet");
        }

        private void acceptRequestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accepting Request not available yet");
        }

        private void denyRequestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Denying Request not available yet");

        }
    }
}
