using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3.Menus___forms.AssociateSubMenus;
using System.Data.SqlClient;

namespace Project_Team3.Menus___forms
{
    public partial class Form_associateMenu : Form
    {
        private DBconnect dbcon;
        private DataSet allEvents;

        public Form_associateMenu()
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
            globalMessageLabel.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        }

        private void Form_associateMenu_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewWeeklyPlanButton_Click(object sender, EventArgs e)
        {
            retreiveData();
        }

        private void defineNewEventButton_Click(object sender, EventArgs e)
        {
            using (Form_associateDefineNewEvent defineNewEvent = new Form_associateDefineNewEvent())
            {
                this.Hide();
                defineNewEvent.ShowDialog(this);
            }

        }

        private void retreiveData()
        {
            dbcon.OpenConn();

            //create data adapter
            var dataAdapter = new SqlDataAdapter("select EVENT_DAY, EVENT_START, EVENT_END, EVENT_ID, EVENT_NAME, EVENT_DESC from Event", dbcon.ConnectionStringGet());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            //try to fill dataset with query result
            try
            {
                dataAdapter.Fill(ds);
                associationEventsGrid.ReadOnly = true;
                associationEventsGrid.DataSource = ds.Tables[0];
                allEvents = ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Query not returned any data");
            }

            ds.Tables[0].DefaultView.Sort = "EVENT_DAY ASC";
            dbcon.CloseConn(dbcon.ConnStatus());
        }

        private void viewAllEventsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Available");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_associateMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_login parent = (Form_login)this.Owner;
            parent.Show();
        }
    }
}
