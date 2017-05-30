using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Project_Team3.Menus___forms;
using Project_Team3.GUI;

namespace Project_Team3
{

    public partial class Form_login : Form
    {
        private DBconnect db;
        private string username;
        private string password;
        private ulong id;
        private GetTheMail facebook_mail;
        publicChecksAndOperations checkIfUserExit = new publicChecksAndOperations();
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
            login();
        }

        private void login()
        {
            db = new DBconnect();
            db.OpenConn();
            Boolean error = false;
            switch (getAccessGroup())
            {
                case "Admin":
                    if (ManagementButton.Checked)
                    {
                        getID();
                        using (adminMenu adMenu = new adminMenu(new admin(id)))
                        {
                            this.Hide();
                            adMenu.ShowDialog(this);
                        }
                    }
                    else if (StudentButton.Checked)
                    {
                        using (Form_adminMenu admin_menu = new Form_adminMenu())
                        {
                            this.Hide();
                            admin_menu.ShowDialog(this);
                        }
                    }
                    else
                        MessageBox.Show("You must choose a button!");
                    break;
                case "Student":
                    if (StudentButton.Checked)
                    {
                        using (Form_studentMenu student_menu = new Form_studentMenu())
                        {
                            student_menu.setUsername(Username);
                            this.Hide();
                            student_menu.ShowDialog(this);
                        }
                    }
                    else
                        MessageBox.Show("You must choose your right type!");
                    break;
                case "Associate":
                    if (StudentButton.Checked)
                    {
                        using (Form_associateMenu associate_menu = new Form_associateMenu())
                        {
                            this.Hide();
                            associate_menu.ShowDialog(this);
                        }
                    }
                    else
                        MessageBox.Show("You must choose your right type!");
                    break;
                case "Secretary":
                    if (ManagementButton.Checked)
                    {
                        getID();
                        using (secretaryMenu secMenu = new secretaryMenu(new secretary(id)))
                        {
                            this.Hide();
                            secMenu.ShowDialog(this);
                        }
                    }
                    else if (StudentButton.Checked)
                    {
                        using (Form_secretaryMenu secretary_menu = new Form_secretaryMenu())
                        {
                            this.Hide();
                            secretary_menu.ShowDialog(this);
                        }
                    }
                    else
                        MessageBox.Show("You must choose a button!");
                    break;
                case "instructor":
                    if (ManagementButton.Checked)
                    {
                        getID();
                        using (teachingStaffMenu instrfMen = new teachingStaffMenu(new professor(id)))
                        {
                            this.Hide();
                            instrfMen.ShowDialog(this);
                        }
                    }
                    else
                        MessageBox.Show("You must choose your right type!");
                    break;
                case "Professor":
                    if (ManagementButton.Checked)
                    {
                        getID();
                        using (teachingStaffMenu porfMen = new teachingStaffMenu(new professor(id)))
                        {
                            this.Hide();
                            porfMen.ShowDialog(this);
                        }
                    }
                    else
                        MessageBox.Show("You must choose your right type!");
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
                this.ManagementButton.Checked = false;
                this.StudentButton.Checked = false;
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
        private void getID()
        {
            if (db.ConnStatus() == false)
                db.OpenConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.getConnection();
            cmd.CommandText = "SELECT id FROM USERS WHERE USERNAME = @username and PASS = @password";
            cmd.Parameters.AddWithValue("username", Username);
            cmd.Parameters.AddWithValue("password", password);
            DataSet ds = db.generalCommand(cmd);
            id = Convert.ToUInt32(ds.Tables[0].Rows[0].ItemArray[0]);
            db.CloseConn(db.ConnStatus());
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

        private void facebookButton_Click(object sender, EventArgs e)
        {
            facebook();
        }
        [STAThread]
        public void facebook()
        {
            Application.EnableVisualStyles();
            facebook_mail = new GetTheMail();
            string mail = facebook_mail.getMail();

            try
            { 
                id = dataBaseOperations.getIdByMail(mail);
                if (db.ConnStatus() == false)
                    db.OpenConn();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.getConnection();
                cmd.CommandText = "SELECT username, password FROM USERS WHERE id = @id";
                cmd.Parameters.AddWithValue("id", id);
                DataSet ds = db.generalCommand(cmd);
                username = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                password = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                db.CloseConn(db.ConnStatus());
                login();
            }
            catch(Exception)
            {
                MessageBox.Show("the user not exist");
            }
            facebook_mail.logout();
        }
    }
}
