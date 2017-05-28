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
    public partial class Form_associateRemoveEvent : Form
    {
        public Form_associateRemoveEvent()
        {
            InitializeComponent();
        }

        private bool checkFieldText()
        {
            Project_Team3.Classes.FunctionsForAllProgram funcs = new Classes.FunctionsForAllProgram();
            int idInt = -1;

            if (string.IsNullOrWhiteSpace(this.eventIdTextBox.Text))
            {
                MessageBox.Show("The ID field cannot be empty.\n");
                return false;
            }

            try
            {
                idInt = Convert.ToInt32(this.eventIdTextBox.Text);
            }
            catch
            {
                MessageBox.Show("ID must contain numerical digits only.");
                return false;
            }

            if (!(funcs.ifIDinEvents(idInt)))
            {
                MessageBox.Show("Such event doesn't exist.\n");
                return false;
            }

            return true;
        }

        private void removeEvent_Click_1(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            string idToRemove = this.eventIdTextBox.Text;
            string commandString = "DELETE FROM Event WHERE Event.EVENT_ID = " + idToRemove;
            if (checkFieldText())
            {
                db.OpenConn();
                db.executionQuery(commandString);
                MessageBox.Show("Event Deleted.\n");
            }
        }

        private void eventList_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_associateRemoveEvent_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Form_associateMenu parent = (Form_associateMenu)this.Owner;
            parent.Show();
        }
    }
}
