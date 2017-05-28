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

namespace Project_Team3.Menus___forms.SecretarySubMenus
{
    public partial class Form_secretaryAssociationEventsNew : Form
    {
        private DataSet allEvents;

        public Form_secretaryAssociationEventsNew()
        {
            InitializeComponent();
        }

        private void associationEventsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds;
            DBconnect db = new DBconnect();
            SqlCommand command = new SqlCommand();
            db.OpenConn();

            var dataIndexNo = associationEventsGrid.Rows[e.RowIndex].Index.ToString();
            string cellValue1 = associationEventsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            string cellValue2 = associationEventsGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            command.CommandType = CommandType.Text;
            command.Connection = db.getConnection();
            command.CommandText = "SELECT * FROM Event WHERE Event.EVENT_ID = @cellValue";
            command.Parameters.AddWithValue("cellValue", cellValue1);
            ds = db.generalCommand(command);

            MessageBox.Show(
                                         "\n ID: " +
                 ds.Tables[0].Rows[0].ItemArray[0].ToString() + "\n Name: " +
                 ds.Tables[0].Rows[0].ItemArray[1].ToString() + "\n Creator:  " +
                 ds.Tables[0].Rows[0].ItemArray[2].ToString() + "\n Start:  " +
                 ds.Tables[0].Rows[0].ItemArray[3].ToString() + "\n End:  " +
                 ds.Tables[0].Rows[0].ItemArray[4].ToString() + "\n Day:  " +
                 ds.Tables[0].Rows[0].ItemArray[5].ToString() + "\n Description:  " +
                 ds.Tables[0].Rows[0].ItemArray[6].ToString());
                 
        }

        private void retreiveData()
        {
            DBconnect db = new DBconnect();
            db.OpenConn();

            //create data adapter
            var dataAdapter = new SqlDataAdapter("select EVENT_ID, EVENT_NAME from Event", db.ConnectionStringGet());
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

            db.CloseConn(db.ConnStatus());
        }

        private void RefreshData_Click(object sender, EventArgs e)
        {
            retreiveData();
        }

        private void Form_secretaryAssociationEventsNew_Load(object sender, EventArgs e)
        {
            retreiveData();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_secretaryAssociationEventsNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_secretaryMenu parent = (Form_secretaryMenu)this.Owner;
            parent.Show();
        }
    }
}
