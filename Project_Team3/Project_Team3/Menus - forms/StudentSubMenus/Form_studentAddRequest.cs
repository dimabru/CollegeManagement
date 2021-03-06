﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.Menus___forms.StudentSubMenus
{
    public partial class Form_studentAddRequest : Form
    {

        private string username;

        public void setUsername(string username)
        {
            this.username = username;
        }
        public Form_studentAddRequest()
        {
            InitializeComponent();
        }

        private void secretaryChooseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_studentAddRequest_Load(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            DataSet ds = db.LoadTableWithRule("users","WHERE accessgroup='Secretary'");
            secretaryChooseList.DataSource = ds.Tables[0];
            secretaryChooseList.ValueMember = "Uname";
            secretaryChooseList.DisplayMember = "Uname";
        }

        private void sendRequest_button_Click(object sender, EventArgs e)
        {
            String messageBody = messageBox.Text;
            if (messageBody.Length == 0)
            {
                MessageBox.Show("Can's send empty message");
                return;
            }

            String secretaryName = secretaryChooseList.Text;
            if (secretaryName.Length == 0)
            {
                MessageBox.Show("Not secretary choosen, can't assign to nobody");
                return;
            }


            DBconnect db = new DBconnect();
            try
            {
                db.executionQuery("insert into StudentRequests values('"+ username+"', '" + messageBody + "','New request','" + secretaryName + "')");
                MessageBox.Show("Request message : \n\n"+messageBody+"\n\nBeen save in system and assigned to Secretary :"+secretaryName);
            }
            catch { }
        }

    }
}
