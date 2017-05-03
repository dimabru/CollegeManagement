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

        }

        private void retreiveData()
        {
            DBconnect db = new DBconnect();
            db.OpenConn();

            //create data adapter
            var dataAdapter = new SqlDataAdapter("select EVENT_NAME from Event", db.ConnectionStringGet());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            //try to fill sataset with query result
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
