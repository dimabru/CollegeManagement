using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.Menus___forms.StudentSubMenus
{
    public partial class Form_studentViewRequests : Form
    {

        private string username;
        DBconnect db;
        DataSet dataSet;

        public void setUsername(string username)
        {
            this.username = username;
        }
        public Form_studentViewRequests()
        {
            InitializeComponent();
        }

        private void Form_studentViewRequests_Load(object sender, EventArgs e)
        {
            db = new DBconnect();
            retrieveData();
        }

        private void retrieveData()
        {

            try
            {
                dataGrid.DataSource = null;
                dataGrid.Rows.Clear();
                dataSet = db.LoadTableByFreeQuerry("select messagebody, StatusOFRequest, Assignedto from StudentRequests where StudentUsername = '" + username + "'");
                dataGrid.ReadOnly = true;
                dataGrid.DataSource = dataSet.Tables[0];


                // rename columns default names in datagrid
                dataGrid.Columns[0].HeaderText = "Request message";
                dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid.Columns[1].HeaderText = "Request status";
                dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGrid.Columns[2].HeaderText = "Assigned to secretary";
                dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception)
            {
                MessageBox.Show("Query not returned any data");
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            retrieveData();
        }
    }
}
