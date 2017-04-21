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
    public partial class Form_adminAddGlobalMessage : Form
    {
        public Form_adminAddGlobalMessage()
        {
            InitializeComponent();
        }

        private void addMessage_Click(object sender, EventArgs e)
        {
            String message = this.messageInputBox.Text;
            DBconnect db = new DBconnect();
            try
            {
                db.addGlobalMessageToDB(message);
                MessageBox.Show("Message added :\n"+message+"\n");
            }
            catch
            {
                MessageBox.Show("Something went wrong, user not been added! \ncheck your database connection and fields correctness and try again!");
            }
        }
        // Task 53
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form_adminAddGlobalMessage_Load(object sender, EventArgs e)
        {

        }


        private void returnButton_Click(object sender, EventArgs e)
        {
            // Open main menu
            Form_adminMenu parent = (Form_adminMenu)this.Owner;
            parent.Show();
            this.Hide();
        }

        private void showAllMessages_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Temporary not working");
        }

        private void deleteMessageButton_Click(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            int id;
            try
            {
               id =  Convert.ToInt32(this.globalMessageId_box.Text);

            }
            catch
            {
                MessageBox.Show("Empty ID field or non-digit symbol been inputed.");
                return;
            }
            String query = "DELETE FROM GlobalMEssages WHERE ID=" + id;
            try
            {
               bool result =  db.executionQuery(query);
                if(result)
                    MessageBox.Show("Global message with id : " + id + " removed from database");
            }
            catch
            {
                MessageBox.Show("Cannot delete message with id : " + id );
            }
        }
    }
}
