using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.GUI
{
    public partial class adminMenu : Form
    {
        admin ad;
        dataBaseOperations dbo = new dataBaseOperations();

        //font size
        //learn more here: https://msdn.microsoft.com/en-us/library/system.drawing.font.size(v=vs.110).aspx
        const float fSize = 12.0F;

        public adminMenu(admin ad)
        {
            InitializeComponent();
            this.ad = ad;


            //change this form size 
            //see also: https://msdn.microsoft.com/en-us/library/ms229606(v=vs.110).aspx 
            this.Size = new System.Drawing.Size(760, 460);

            //set position in the center;
            //see also: https://msdn.microsoft.com/en-us/library/system.windows.forms.form.startposition(v=vs.110).aspx
            this.StartPosition = FormStartPosition.CenterScreen;

            //set pages
            set_account_Management();

            set_add_user_and_user_details();

            set_delete_user();
        }

        /// <summary>
        /// set the page add user delete user
        /// </summary>
        public void set_delete_user()
        {

            comboBox_access_group_delete.Items.Add("Secretary");
            comboBox_access_group_delete.Items.Add("Instructor");
            comboBox_access_group_delete.Items.Add("Professor");
        }

        private void button_delete_this_user(object sender, EventArgs e)
        {
            if (textBox_id_delete.Text == "" || comboBox_access_group_delete.Text == "")
            {
                MessageBox.Show("you have to fill all fields");
                return;
            }
            try
            {
                ulong deletUserId = publicChecksAndOperations.convertToUlong(textBox_id_delete.Text);
                if (comboBox_access_group_delete.Text != ad.getUserAccessGroup(deletUserId))
                {
                    MessageBox.Show("you have wrong with the access group");
                    return;
                }
                string message_for_message_box = "you deleted " + dbo.getUserNameById(deletUserId);
                ad.deleteUserById(deletUserId);
                MessageBox.Show(message_for_message_box);
                textBox_id_delete.Text = "";
                comboBox_access_group_delete.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// set the page add user and user details;
        /// </summary>
        public void set_add_user_and_user_details()
        {
            numOfSecretaryLabelConst.Font = new Font(lastNameLabel.Font.Name, fSize, lastNameLabel.Font.Style, lastNameLabel.Font.Unit);
            numOfSecretaryLabelDinamic.Font = new Font(lastNameLabel.Font.Name, fSize, lastNameLabel.Font.Style, lastNameLabel.Font.Unit);
            amount_of_instructors_lable_const.Font = new Font(lastNameLabel.Font.Name, fSize, lastNameLabel.Font.Style, lastNameLabel.Font.Unit);
            amount_of_instructors_lable_dinamic.Font = new Font(lastNameLabel.Font.Name, fSize, lastNameLabel.Font.Style, lastNameLabel.Font.Unit);
            amount_of_professors_lable_const.Font = new Font(lastNameLabel.Font.Name, fSize, lastNameLabel.Font.Style, lastNameLabel.Font.Unit);
            amount_of_professors_lable_dinamic.Font = new Font(lastNameLabel.Font.Name, fSize, lastNameLabel.Font.Style, lastNameLabel.Font.Unit);

            numOfSecretaryLabelDinamic.Text = ad.how_many_from_this_type("Secretary").ToString();
            amount_of_instructors_lable_dinamic.Text = ad.how_many_from_this_type("Instructor").ToString();
            amount_of_professors_lable_dinamic.Text = ad.how_many_from_this_type("Professor").ToString();

            comboBox_access_group.Items.Add("Secretary");
            comboBox_access_group.Items.Add("Instructor");
            comboBox_access_group.Items.Add("Professor");
        }

        /// <summary>
        /// refrash the numbers in user detail page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_refresh_user_details_Click(object sender, EventArgs e)
        {
            numOfSecretaryLabelDinamic.Text = ad.how_many_from_this_type("Secretary").ToString();
            amount_of_instructors_lable_dinamic.Text = ad.how_many_from_this_type("Instructor").ToString();
            amount_of_professors_lable_dinamic.Text = ad.how_many_from_this_type("Professor").ToString();
        }

        private void set_account_Management()
        {
            //here you can learn how to set fonts: https://msdn.microsoft.com/en-us/library/system.drawing.font.size(v=vs.110).aspx
            nameLable.Text = "name:";
            lastNameLabel.Text = "last name:";

            lNameLable.Text = ad.getUserLastName;
            UnameLable.Text = ad.getUserName;


            lastNameLabel.Font = new Font(lastNameLabel.Font.Name, fSize, lastNameLabel.Font.Style, lastNameLabel.Font.Unit);
            nameLable.Font = new Font(nameLable.Font.Name, fSize, nameLable.Font.Style, nameLable.Font.Unit);
        }

        private void changeMyPassbutton_Click(object sender, EventArgs e)
        {
            if (oldPassTextBox.Text == "" || newPassTextBox.Text == "" || confPassTextBox.Text == "")
            {
                MessageBox.Show("you have to fill all fields");
                return;
            }
            if (newPassTextBox.Text != confPassTextBox.Text)
            {
                MessageBox.Show("Password does not match the confirm password.");
                return;
            }

            
            if (oldPassTextBox.Text == ad.getPassword())
            {
                ad.changePassword(newPassTextBox.Text);
                MessageBox.Show("the password has changed");
                return;
            }
            MessageBox.Show("the old password is not correct");
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_new_user_Click(object sender, EventArgs e)
        {
            if(textBox_first_name.Text == "" || textBox_id.Text == "" || textBox_last_name.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("you have to fill all fields");
                return;
            }

            string name = textBox_first_name.Text;
            string lname = textBox_last_name.Text;
            string id = textBox_id.Text;
            string password = textBox_password.Text;
            string accessGroup = comboBox_access_group.Text;

            ad.set_new_user(publicChecksAndOperations.convertToUlong(id), name, lname, password, accessGroup);
            MessageBox.Show("the user was successfully created");


            textBox_first_name.Text = "";
            textBox_id.Text = "";
            textBox_last_name.Text = "";
            textBox_password.Text = "";
            comboBox_access_group.Text = "";
        }
    }
}
