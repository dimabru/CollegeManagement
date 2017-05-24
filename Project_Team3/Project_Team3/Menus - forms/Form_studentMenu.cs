using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3.Menus___forms.StudentSubMenus;
using System.Data.SqlClient;

namespace Project_Team3
{
    public partial class Form_studentMenu : Form
    {
        private DBconnect dbcon;
        private string username;

        public Form_studentMenu()
        {    
            InitializeComponent();
            dbcon = new DBconnect();
            updateGlobalMessage();
        }

        private void updateGlobalMessage()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM GlobalMessages WHERE ID = ( SELECT MAX(ID) FROM GlobalMessages)";
            cmd.CommandType = CommandType.Text;

            DataSet ds = dbcon.generalCommand(cmd);
            textBox1.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        private void Form_studentMenu_Load(object sender, EventArgs e)
        {
            studentRequestResponsed();
        }

        private void Form_studentMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_login parent = (Form_login)this.Owner;
            parent.Show();
        }

        private void LogoutStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // checks if there at least one students request that have status R_Allowed or R_denied, if there are new 
        // responces found, rename them to Allowed or Denied
        private void studentRequestResponsed()
        {
            DBconnect db = new DBconnect();
                string query = "select COUNT(*) from StudentRequests  WHERE StudentUsername = '" + username + "' AND StatusOFRequest IN ('R_Allowed','R_Denied')";
                using (SqlCommand sqlCommand = new SqlCommand(query, db.getConnection()))
                {
                    db.OpenConn();

                    int userCount = (int)sqlCommand.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("You received responce to one or more of your student request\nCheck them in \" Student requests -> My requests\"");
                        removeRequestsPopup(db);
                    }
                }
            }

        private void removeRequestsPopup(DBconnect db) {
            try
            {
                db.executionQuery("UPDATE studentrequests SET STATUSOFREQUEST = 'Allowed' WHERE STATUSOFREQUEST='R_Allowed' and STUDENTUSERNAME='" + username + "'");
                db.executionQuery("UPDATE studentrequests SET STATUSOFREQUEST = 'Denied' WHERE STATUSOFREQUEST='R_Denied' and STUDENTUSERNAME='" + username + "'");
            }
            catch (Exception ex) { }
        }

        ///
        ///     COURSES MENU
        ///
        private void WatchCoursesbutton_Click_1(object sender, EventArgs e)
        {
            using (Form_studentRegisteredCourses studentRegCourses = new Form_studentRegisteredCourses(username))
            {
                this.Hide();
                studentRegCourses.ShowDialog(this);
            }
        }

        private void MandatoryCoursesbutton_Click(object sender, EventArgs e)
        {
            using (Form_studentRequiredCourses studentReqCourses = new Form_studentRequiredCourses(username))
            {
                this.Hide();
                studentReqCourses.ShowDialog(this);
            }
        }

        private void ChangeCourseTimebutton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }
        ///
        ///    ASSSOCIATION MENU
        ///
        private void AssociationMenubutton_Click_1(object sender, EventArgs e)
        {
            using (Form_studentWatchEvents studentWatchEvents = new Form_studentWatchEvents(username))
            {
                this.Hide();
                studentWatchEvents.ShowDialog(this);
            }
        }
        /// 
        /// REQUEST MENU
        ///
        private void AddNewReqbutton_Click(object sender, EventArgs e)
        {
            Form_studentAddRequest addRequest = new Form_studentAddRequest();
            addRequest.setUsername(username);
            addRequest.Show();
        }

        private void WatchReqbutton_Click(object sender, EventArgs e)
        {
            Form_studentViewRequests studentRequests = new Form_studentViewRequests();
            studentRequests.setUsername(username);
            studentRequests.Show();
        }
    }
}
