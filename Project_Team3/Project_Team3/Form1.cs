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


namespace Project_Team3
{
    public partial class Form1 : Form
    {

        private DBconnect db;
        private string username;
        private string password;
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new DBconnect();
            db.OpenConn();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = this.textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = this.textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db = new DBconnect();
            db.OpenConn();
            //getAccessGroup();
            Boolean error = false;
            switch (getAccessGroup())
            {
                case "Admin":
                    //Admin admin = new Admin();
                    this.Hide();
                    Form admin_menu = new Form_adminMenu();
                    admin_menu.ShowDialog();
                    break;
                case "Student":
                    //Student student = new Student();
                    this.Hide();
                    Form student_menu = new Form_studentMenu();
                    student_menu.ShowDialog();
                    break;
                case "Assosicate":
                    //Assosicate assosicate = new Assosicate();
                    this.Hide();
                    Form assosicate_menu = new Form_AssosicateMenu();
                    assosicate_menu.ShowDialog();
                    break;
                case "Secretary":
                    //Secretary secretary = new Secretary();
                    this.Hide();
                    Form secretary_menu = new Form_secretaryMenu();
                    secretary_menu.ShowDialog();
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
                this.textBox1.Clear();
                this.textBox2.Clear();
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
            SqlDataAdapter sda = new SqlDataAdapter();
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
            }
            return Regex.Replace(ds.Tables[0].Rows[0].ItemArray[0].ToString(), @"\s+", "");
        }
    }
}
