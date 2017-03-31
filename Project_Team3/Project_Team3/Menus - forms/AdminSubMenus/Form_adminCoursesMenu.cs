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

namespace Project_Team3.Menus___forms.AdminSubMenus
{
    public partial class Form_adminCoursesMenu : Form
    {

        public Form_adminCoursesMenu()
        {
            InitializeComponent();
        }

        /**
         * Print all courses from database
         * */
        private void button1_Click(object sender, EventArgs e)
        {

            DBconnect db = new DBconnect();
            db.OpenConn();

            //create data adapter
            var dataAdapter = new SqlDataAdapter("select * from Course", db.ConnectionStringGet());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            //try to fill sataset with query result
            try
            {
                dataAdapter.Fill(ds);
                dataGrid.ReadOnly = true;
                dataGrid.DataSource = ds.Tables[0];
            }
            catch (Exception _)
            {
                MessageBox.Show("Query not returned any data");
            }

            db.CloseConn(db.ConnStatus());      // close connection
       
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }

        private void Form_adminCoursesMenu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dBconnectBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
