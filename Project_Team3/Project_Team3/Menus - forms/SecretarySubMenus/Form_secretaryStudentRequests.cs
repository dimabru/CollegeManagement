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
    public partial class Form_secretaryStudentRequests : Form
    {

        DBconnect connection;
        SqlCommand command;

        public Form_secretaryStudentRequests()
        {
            InitializeComponent();
            Init();
            UpdateGrid();
        }



        private void Init()
        {
            connection = new DBconnect();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection.getConnection();
            connection = new DBconnect();
            command.CommandText = "SELECT * FROM StudentRequests";
        }


        private void UpdateGrid()
        {
            try
            {
                DataSet ds = connection.generalCommand(command);
                if (ds.Tables.Count > 0)
                {
                    StudentReqGrid.AutoGenerateColumns = true;
                    StudentReqGrid.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void updateRequest(string status, string requestID)
        {
            
            string query = "UPDATE StudentRequests SET StatusOFRequest ='" + status + "' WHERE ID = " + requestID;
            Console.Out.WriteLine(query);
            connection.executionQuery(query);
            UpdateGrid();
        }



        private void Form_secretaryStudentRequests_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryMenu parent = (Form_secretaryMenu)this.Owner;
            parent.Show();
        }


        private string getSelectedRequestID()
        {
            return StudentReqGrid.SelectedCells[0].Value.ToString();
        }


        private void acceptRequestButton_Click(object sender, EventArgs e)
        {
            string ID = getSelectedRequestID();
            updateRequest("R_Allowed", ID);
        }


        private void denyRequestButton_Click(object sender, EventArgs e)
        {
            string ID = getSelectedRequestID();
            updateRequest("R_Denied", ID);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
