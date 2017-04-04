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
using System.Data;
using System.Text.RegularExpressions;
using Project_Team3.Menus___forms;


namespace Project_Team3
{
    public partial class Form_login : Form
    {

        private DBconnect db;
        private string username;
        private string password;
        public Form_login()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = this.userNameBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = this.passwordBox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db = new DBconnect();
            db.OpenConn();
            Boolean error = false;
            switch (getAccessGroup())
            {
                case "Admin":
                    this.Hide();
                    using (Form_adminMenu admin_menu = new Form_adminMenu())
                    {
                        this.Hide();
                        admin_menu.ShowDialog(this);
                    }
                    break;
                case "Student":
                    this.Hide();
                    using (Form_studentMenu student_menu = new Form_studentMenu())
                    {
                        this.Hide();
                        student_menu.ShowDialog(this);
                    }
                    break;            
                case "Associate":
                    this.Hide();
                    using (Form_associateMenu associate_menu = new Form_associateMenu())
                    {
                        this.Hide();
                        associate_menu.ShowDialog(this);
                    }
                    break;
                case "Secretary":
                    this.Hide();
                    using (Form_secretaryMenu secretary_menu = new Form_secretaryMenu())
                    {
                        this.Hide();
                        secretary_menu.ShowDialog(this);
                    }
                    break;
                default:
                    MessageBox.Show("Wrong access group!");
                    error = true;
                    break;
            }
            if (!error)
            {
                this.Show();
                this.BringToFront();
                this.userNameBox.Clear();
                this.passwordBox.Clear();
            }

            db.CloseConn(db.ConnStatus());
        }
        private string getAccessGroup() {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.getConnection();
            cmd.CommandText = "SELECT accessgroup FROM USERS WHERE USERNAME = @username and PASS = @password";
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            /*SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            try
            {
                sda.Fill(ds, "Check");
                MessageBox.Show("Group: " + ds.Tables[0].Rows[0].ItemArray[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Data!");
                return null;
            }*/
            DataSet ds = db.generalCommand(cmd);
            return Regex.Replace(ds.Tables[0].Rows[0].ItemArray[0].ToString(), @"\s+", "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
