using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.Menus___forms.AssociateSubMenus
{
    public partial class Form_associateDefineNewEvent : Form
    {
        public Form_associateDefineNewEvent()
        {
            InitializeComponent();
        }

        private void Form_associateDefineNewEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_associateMenu parent = (Form_associateMenu) this.Owner;
            parent.Show();
        }

        private void clearNameButton_Click(object sender, EventArgs e)
        {
            eventNameTextBox.Text = "";
        }

        private void clearDescription_Click(object sender, EventArgs e)
        {
            eventDescriptionRichTextBox.Text = "";
        }

        private void createEventButton_Click(object sender, EventArgs e)
        {

            
            MessageBox.Show("Event Created! (Not Really)");
            this.Close();
        }
    }
}
