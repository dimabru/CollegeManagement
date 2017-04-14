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
        //panel counter;
        private int myPanelCounter = 0;
        //list of panels;
        List<Panel> listPanel = new List<Panel>();

        public adminLoginMenu()
        {
            InitializeComponent();

            //paint allert label in black and hide him;
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
            //show the first panel
            listPanel[myPanelCounter].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instance of data base managment;
            dataBaseOperations check_user_instance = new dataBaseOperations();
            //instance of cheking class;
            publicChecksAndOperations check_id_if_numeric = new publicChecksAndOperations();

            if (check_id_if_numeric.isNumericUlong(textBox1.Text))
            {
                //turn the string into int;

                ulong id = Convert.ToUInt32(textBox1.Text, 10);
                try
                {
                    //check if user exist in the system;
                    if (check_user_instance.userExist(textBox2.Text, id, "Admin"))
                    {
                        //hide this panel to show the other;
                        label3.Hide();
                        listPanel[myPanelCounter].Hide();
                        //raise counter to next panel;
                        myPanelCounter++;
                        //show secretary menu;
                        listPanel[myPanelCounter].Show();
                    }
                    else
                    {
                        //if lable 3 pop in previous case;
                        label3.Hide();
                        MessageBox.Show("the username or password is incorrect");
                    }
                }
                catch
                {
                    //if lable 3 pop in previous case;
                    label3.Hide();
                    MessageBox.Show("there was a problam with the conection");
                }
            }
            else if (textBox1.Text == "")
            {
                //show allert and paint it;
                label3.Show();
                label3.Text = "please enter values";
                label3.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                //show allert and paint it;
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
            // Set the maximum length of text in the control to eight.
            textBox2.MaxLength = 8;
            // Assign the asterisk to be the password character.
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //limit the text box to just 8 chrecters;
            textBox1.MaxLength = 8;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //declare that the application is closed to avoid open new windows and making bug;
            publicChecksAndOperations exitCheck = new publicChecksAndOperations();
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
            //close this windows;
            this.Close();
        }
    }
}
