using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3.Menus___forms.AssociateSubMenus;

namespace Project_Team3.Menus___forms
{
    public partial class Form_associateMenu : Form
    {
        public Form_associateMenu()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewWeeklyPlanButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Available");
        }

        private void defineNewEventButton_Click(object sender, EventArgs e)
        {
            using (Form_associateDefineNewEvent defineNewEvent = new Form_associateDefineNewEvent())
            {
                this.Hide();
                defineNewEvent.ShowDialog(this);
            }

        }

        private void viewAllEventsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Available");
        }
    }
}
