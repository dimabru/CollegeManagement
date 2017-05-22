using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Project_Team3.Menus___forms;


namespace Project_Team3
{

    public partial class Form_login : Form
    {
        private DBconnect db;
        private string username;
        private string password;

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public Form_login()
        {
            InitializeComponent();
        }
        private string getAccessGroup() {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.getConnection();
            if (username == null || username == "") { return "Enter username"; }
            if (password == null || password == "") { return "Enter password"; }
            cmd.CommandText = "SELECT accessgroup FROM USERS WHERE USERNAME = @username and PASS = @password";
            cmd.Parameters.AddWithValue("username", Username);
            cmd.Parameters.AddWithValue("password", password);

            try
            {
                DataSet ds = db.generalCommand(cmd);
                return ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "Bad Username/Password!";
            }
            
        }

        private void userName_Text(object sender, EventArgs e)
        {
            Username = this.userNameBox.Text;
        }

        private void password_Text(object sender, EventArgs e)
        {
            password = this.passwordBox.Text;
        }

        private void loginButton_click(object sender, EventArgs e)
        {
            db = new DBconnect();
            db.OpenConn();
            Boolean error = false;
            switch (getAccessGroup())
            {
                case "Admin":
                    using (Form_adminMenu admin_menu = new Form_adminMenu())
                    {
                        this.Hide();
                        admin_menu.ShowDialog(this);
                    }
                    break;
                case "Student":
                    using (Form_studentMenu student_menu = new Form_studentMenu())
                    {
                        student_menu.setUsername(Username);
                        this.Hide();
                        student_menu.ShowDialog(this);
                    }
                    break;
                case "Associate":
                    using (Form_associateMenu associate_menu = new Form_associateMenu())
                    {
                        this.Hide();
                        associate_menu.ShowDialog(this);
                    }
                    break;
                case "Secretary":
                    using (Form_secretaryMenu secretary_menu = new Form_secretaryMenu())
                    {
                        this.Hide();
                        secretary_menu.ShowDialog(this);
                    }
                    break;
                default:
                    MessageBox.Show(getAccessGroup());
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

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // close application
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(0);
            }
        }

        private void Form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close application
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(0);
            }
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!passwordBox.AcceptsReturn)
                {
                    button2.PerformClick();
                }
            }
        }
    }
}
