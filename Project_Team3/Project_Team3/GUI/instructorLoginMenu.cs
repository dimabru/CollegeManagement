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
    public partial class instructorLoginMenu : Form
    {
        private GetTheMail g;

        public instructorLoginMenu()
        {
            InitializeComponent();

            //paint allert label in black and hide him;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Hide();

            //show the first panel
            panel1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //limit the text box to just 8 chrecters;
            textBox1.MaxLength = 8;
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
                    if (check_user_instance.userExist(textBox2.Text, id, "Instructor"))
                    {
                        //hide this panel to show the other;
                        label3.Hide();

                        //In perception i thing that its importent to pass 
                        //user object for the next managing form
                        //plese do it in all other form  

                        //here i create new prof obj
                        professor prof = new professor(id);
                        //and then i pass it to the next form 
                        //i'll catch it in the next form constractor
                        teachingStaffMenu instrfMen = new teachingStaffMenu(prof);

                        this.Hide();
                        instrfMen.ShowDialog();
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
                    //show allert and paint it;
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
            //close this window;
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Set the maximum length of text in the control to eight.
            textBox2.MaxLength = 8;
            // Assign the asterisk to be the password character.
            textBox2.PasswordChar = '*';
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //declare that the application is closed to avoid open new windows and making bug;
            publicChecksAndOperations closeCheck = new publicChecksAndOperations();
            closeCheck.setUserExit();
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("team: 3\nyear 2\nsoftware engineering\n\ndolev ben aharon\nelon avisror\ndima brusilovski\nreut shukron ", "software project managing");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //close this windows;
            this.Close();
        }

        private void instructorLoginMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void facebookLoginButton(object sender, EventArgs e)
        {
            facebook();
        }

        [STAThread]
        public void facebook()
        {
            Application.EnableVisualStyles();
            g = new GetTheMail();
            string mail = g.getMail();
            if (dataBaseOperations.facebookUserExist(mail, "instructor") )
            {

                //In perception i thing that its importent to pass 
                //user object for the next managing form
                //plese do it in all other form  
                ulong i = dataBaseOperations.getIdByMail(mail);
                //here i create new inst obj
                instructor inst = new instructor(dataBaseOperations.getIdByMail(mail));
                //and then i pass it to the next form 
                //i'll catch it in the next form constractor
                teachingStaffMenu instrfMen = new teachingStaffMenu(inst);

                this.Hide();
                instrfMen.ShowDialog();
            }
            else
            {
                MessageBox.Show("the user not exist");
            }
            g.logout();
        }
    }
}
