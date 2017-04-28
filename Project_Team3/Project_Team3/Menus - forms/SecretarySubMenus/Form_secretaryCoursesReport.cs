using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    public partial class Form_secretaryCoursesReport : Form
    {
        DBconnect connection;
        SqlCommand command;
        public Form_secretaryCoursesReport()
        {
            InitializeComponent();
            Init();
            UpdateListView();
        }
        private void Init()
        {
            connection = new DBconnect();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection.getConnection();
            connection = new DBconnect();
            command.CommandText = "SELECT * FROM Course";
        }

        private void UpdateListView()
        {
            try
            {
                DataSet ds = connection.generalCommand(command);
                if (ds.Tables.Count > 0)
                {
                    CoursesGridView.AutoGenerateColumns = true;
                    CoursesGridView.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No Record Found");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form_secretaryCoursesReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryMenu parent = (Form_secretaryMenu)this.Owner;
            parent.Show();
        }

        private void GoBackClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
