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
using Project_Team3.Menus___forms.AssociateSubMenus;

namespace Project_Team3.Menus___forms.AdminSubMenus
{

    public partial class adminRemoveStudent : Form
    {
        private DBconnect dbcon;
        private DataSet students;

        public adminRemoveStudent()
        {
            InitializeComponent();
            dbcon = new DBconnect();
        }

        private void removeStudent_Click(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            string idToRemove = this.textBox1.Text;
            string commandString = "DELETE FROM Users WHERE Users.ID = " + idToRemove;
            if(checkFieldText())
            {
                db.OpenConn();
                db.executionQuery(commandString);
                MessageBox.Show("User Deleted.\n");
            }
        }

        private bool checkFieldText()
        {
            Project_Team3.Classes.FunctionsForAllProgram funcs = new Classes.FunctionsForAllProgram();
            int idInt = -1;

            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                MessageBox.Show("The ID field cannot be empty.\n");
                return false;
            }

            try
            {
                idInt = Convert.ToInt32(this.textBox1.Text);
            }
            catch
            {
                MessageBox.Show("ID must contain numerical digits only.");
                return false;
            }

            if (!(funcs.ifUserIDinDatabase(idInt)))
            {
                MessageBox.Show("Such user doesn't exist.\n");
                return false;
            }

            return true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentList_Click(object sender, EventArgs e)
        {
            retrieveData();
        }

        private void adminRemoveStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_adminManageAccountMenu parent = (Form_adminManageAccountMenu)this.Owner;
            parent.Show();
        }

        private void retrieveData()
        {
            dbcon.OpenConn();

            //create data adapter
            var dataAdapter = new SqlDataAdapter("select ID, USERNAME, ACCESSGROUP, MAIL from Users WHERE ACCESSGROUP='Student'", dbcon.ConnectionStringGet());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            //try to fill dataset with query result
            try
            {
                dataAdapter.Fill(ds);
                studentDataGrid.ReadOnly = true;
                studentDataGrid.DataSource = ds.Tables[0];
                students = ds;
            }

            catch (Exception)
            {
                MessageBox.Show("Query not returned any data");
            }

            ds.Tables[0].DefaultView.Sort = "ID ASC";
            dbcon.CloseConn(dbcon.ConnStatus());
        }
    }
}
