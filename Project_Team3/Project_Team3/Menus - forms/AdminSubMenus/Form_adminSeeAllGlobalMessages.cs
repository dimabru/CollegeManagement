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

namespace Project_Team3.Menus___forms.AdminSubMenus
{
    public partial class Form_adminSeeAllGlobalMessages : Form
    {
        public Form_adminSeeAllGlobalMessages()
        {
            InitializeComponent();
        }

        private void viewAllMessages_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_adminSeeAllGlobalMessages_Load(object sender, EventArgs e)
        {

            retireveData();
        }

        private void refreshBotton_Click(object sender, EventArgs e)
        {

            retireveData();
        }

        public void retireveData()
        {
            DBconnect db = new DBconnect();
            DataSet dataSet;

            try
            {
                dataSet = db.LoadAllTable("GlobalMEssages");
                viewAllMessages_grid.ReadOnly = true;
                viewAllMessages_grid.DataSource = dataSet.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Query not returned any data");
            }
        }
    }
}
