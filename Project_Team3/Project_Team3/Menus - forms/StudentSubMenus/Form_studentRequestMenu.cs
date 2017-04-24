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
        private String username;

        public void setUsername(String username)
        {
            this.username = username;
        }
        public Form_studentRequestMenu()
        {
            InitializeComponent();
        }

        private void NewRequestButton_Click(object sender, EventArgs e)
        {
            Form_studentAddRequest addRequest = new Form_studentAddRequest();
            addRequest.setUsername(username);
            Owner.Owner.Hide();
            Owner.Hide();
            addRequest.Show();
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

        private void Form_studentRequestMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
