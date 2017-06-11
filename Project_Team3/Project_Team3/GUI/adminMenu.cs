using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            this.Size = new System.Drawing.Size(800, 460);

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


            //set all staff in table
            set_data_gerid();

        }

        public void set_data_gerid()
        {
            //learn more about data table here: https://msdn.microsoft.com/en-us/library/system.data.datatable(v=vs.110).aspx
            //and here in the bottom you can find examples for data grid: https://msdn.microsoft.com/en-us/library/system.windows.forms.datagrid(v=vs.110).aspx

            DataTable tempTable = new DataTable();
            tempTable.Columns.Add("id", typeof(string));
            tempTable.Columns.Add("name", typeof(string));
            tempTable.Columns.Add("last name", typeof(string));
            tempTable.Columns.Add("type", typeof(string));

            string id = "";
            string name = "";
            string last_name = "";

            //learn more about enum here: https://msdn.microsoft.com/en-us/library/cc138362.aspx
            //set the first user;
            string type;
            for (int i = 0; i < 3; i++)
            {
                type = Enum.GetName(typeof(userType), i);

                try
                {
                    String str = "server=tcp:sce2017b.database.windows.net;database=Project3DB;UID=sceproject;password=2017Sce2017";
                    String query = "select * from dbo.Users where ACCESSGROUP = '" + type + "'";
                    SqlConnection con = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dbr;
                    con.Open();
                    dbr = cmd.ExecuteReader();

                    while (dbr.Read())
                    {
                        //here im getting all the fields of the users
                        id = dbr.GetValue(0).ToString();
                        id.Trim();
                        name = dbr.GetValue(1).ToString();
                        name.Trim();
                        last_name = dbr.GetValue(5).ToString();
                        last_name.Trim();

                        tempTable.Rows.Add(id, name, last_name, type);
                    }
                    con.Close();
                }
                catch
                {
                    throw;
                }
            }
            //insert everything to the datagrid;
            dataGridView1.DataSource = tempTable;
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

            //set data gerid;
            set_data_gerid();
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
            if(textBox_first_name.Text == "" || textBox_id.Text == "" || textBox_last_name.Text == "" || textBox_password.Text == "" || add_user_user_name.Text == "")
            {
                MessageBox.Show("you have to fill all fields");
                return;
            }

            if(dbo.userExist(textBox_password.Text,publicChecksAndOperations.convertToUlong(textBox_id.Text), comboBox_access_group.Text)){
                MessageBox.Show("user already exist");
                return;
            }

            string name = textBox_first_name.Text;
            string lname = textBox_last_name.Text;
            string id = textBox_id.Text;
            string password = textBox_password.Text;
            string accessGroup = comboBox_access_group.Text;
            string user_name = add_user_user_name.Text;

            ad.set_new_user(publicChecksAndOperations.convertToUlong(id), name, lname, password, accessGroup, user_name);
            MessageBox.Show("the user was successfully created");


            textBox_first_name.Text = "";
            textBox_id.Text = "";
            textBox_last_name.Text = "";
            textBox_password.Text = "";
            comboBox_access_group.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox_last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_user_user_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
