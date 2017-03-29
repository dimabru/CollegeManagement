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
            getInfo();
            db.CloseConn(db.ConnStatus());
        }
        private void getInfo() {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.getConnection();
            cmd.CommandText = "SELECT ID FROM USERS WHERE USERNAME = @username and PASS = @password";
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            try
            {

                sda.Fill(ds, "Check");
                MessageBox.Show("ID: " + Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Data!");
            }
        }
    }
}
