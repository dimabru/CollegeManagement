using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3.Classes;

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
            String messageBody = this.messageInputBox.Text;
            if (messageBody.Length == 0)
            {
                MessageBox.Show("Can's send empty message !");
                return;
            }

            DBconnect db = new DBconnect();
            try
            {
                db.addGlobalMessageToDB(messageBody);
                MessageBox.Show("Message added :\n"+ messageBody + "\n");
            }
            catch
            {
                MessageBox.Show("Something went wrong, user not been added! \ncheck your database connection and fields correctness and try again!");
            }
        }
        // Task 53

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
            Form viewAllMessages = new Form_adminSeeAllGlobalMessages();
            viewAllMessages.Show();
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
            
                FunctionsForAllProgram func = new FunctionsForAllProgram();
            bool existCheck = func.ifIDinTable(id, "GlobalMessages");
            if (existCheck)
            {
                try
                {
                    bool result = db.executionQuery(query);
                    if (result)
                        MessageBox.Show("Global message with id : " + id + " removed from database");
                }
                catch
                {
                    MessageBox.Show("Cannot delete message with id : " + id);
                }
            }
            else
            {
                MessageBox.Show("Message with this id does not exists");
            }
        }
    }
}
