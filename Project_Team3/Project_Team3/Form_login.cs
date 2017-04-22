using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Project_Team3.Menus___forms;
using Project_Team3.Classes;


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
        private string getAccessGroup() {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.getConnection();
            cmd.CommandText = "SELECT accessgroup FROM USERS WHERE USERNAME = @username and PASS = @password";
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

            DataSet ds = db.generalCommand(cmd);
            return Regex.Replace(ds.Tables[0].Rows[0].ItemArray[0].ToString(), @"\s+", "");
        }

        private void userName_Text(object sender, EventArgs e)
        {
            username = this.userNameBox.Text;
        }

        private void password_Text(object sender, EventArgs e)
        {
            password = this.passwordBox.Text;
        }

        public void loginButton_click(object sender, EventArgs e)
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
                    FunctionsForAllProgram funcs = new FunctionsForAllProgram();
                    Student studentObject = funcs.studentFromDB(db, this.userNameBox.Text, this.passwordBox.Text);
                    using (Form_studentMenu student_menu = new Form_studentMenu())
                    {
                        this.Hide();
                        student_menu.StudentProfile = studentObject;
                        student_menu.Show(this);
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
                System.Environment.Exit(1);
            }
        }

        
    }
}
