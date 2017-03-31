﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3
{
    public partial class adminLoginMenu : Form
    {
        private int myPanelCounter = 0;
        List<Panel> listPanel = new List<Panel>();

        public adminLoginMenu()
        {
            InitializeComponent();

            label3.ForeColor = System.Drawing.Color.Black;
            label3.Hide();

            //adding the panels to the list;
            listPanel.Add(panel1);
            listPanel.Add(panel2);

            //hide all panels;
            foreach (Panel panelItem in listPanel)
            {
                panelItem.Hide();
            }
            listPanel[myPanelCounter].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateUserDataBase check_user_instance = new updateUserDataBase();
            publicChecks check_id_if_numeric = new publicChecks();

            if (check_id_if_numeric.isNumeric(textBox1.Text))
            {
                //turn the string into int;
                int id = Int32.Parse(textBox1.Text);

                try
                {
                    if (check_user_instance.userExist(textBox2.Text, id, "Admin"))
                    {
                        label3.Hide();
                        listPanel[myPanelCounter].Hide();
                        //raise counter to next panel;
                        myPanelCounter++;
                        //show secretary menu;
                        listPanel[myPanelCounter].Show();
                    }
                    else
                    {
                        label3.Hide();
                        MessageBox.Show("the username or password is incorrect");
                    }
                }
                catch
                {
                    label3.Hide();
                    MessageBox.Show("there was a problam with the conection");
                }
            }
            else if (textBox1.Text == "")
            {
                label3.Show();
                label3.Text = "please enter values";
                label3.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label3.Show();
                label3.Text = "*there are illegal values";
                label3.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 8;
            // Assign the asterisk to be the password character.
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 8;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            publicChecks exitCheck = new publicChecks();
            exitCheck.setUserExit();
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("team: 3\nyear 2\nsoftware engineering\n\ndolev ben aharon\nelon avisror\ndima brusilovski\nreut shukron ", "software project managing");
        }

        private void adminLoginMenu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
