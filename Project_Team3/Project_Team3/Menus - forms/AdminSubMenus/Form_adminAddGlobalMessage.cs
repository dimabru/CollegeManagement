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
    }
}
