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
    public partial class Form_secretaryAssociationEvents : Form
    {
        public Form_secretaryAssociationEvents()
        {
            InitializeComponent();
        }

        private void Form_secretaryAssociationEvents_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryMenu parent = (Form_secretaryMenu)this.Owner;
            parent.Show();
        }

        private void eventDetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Event Details not Available yet.");
        }

    }
}
