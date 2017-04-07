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
    public partial class Form_adminAccountsMenu : Form
    {
        public Form_adminAccountsMenu()
        {
            InitializeComponent();
        }

        private void watchStudents_Click(object sender, EventArgs e)
        {
            ////
            //// Print all students in system
            ////

            DBconnect db = new DBconnect();
            db.OpenConn();
            //create data adapter
            var dataAdapter = new SqlDataAdapter("select USers.ID,Users.username,Users.Pass,Users.UName,Users.SName,Student.Semester from Users join Student on Users.username = Student.username", db.ConnectionStringGet());
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

        private void watchAssociates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }


        private void getStudentsNumber_Click(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            db.OpenConn();

            ////
            //// Print amount to Text box
            ////
            //create data adapter, count amount of courses in system
            var dataAdapter = new SqlDataAdapter("select count(username) from Student", db.ConnectionStringGet());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();

            //try to fill dataset with query result
            try
            {
                dataAdapter.Fill(ds);
                int Courses_amount = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());

                //print result in textBox

                textBox.Text += "There are total of " + Courses_amount.ToString() + " Students in system";
            }
            catch (Exception _)
            {
                MessageBox.Show("There is problem with your querry, check it!");
            }

            ////
            //// Print all students in system
            ////
            //create data adapter
            dataAdapter = new SqlDataAdapter("select * from Student", db.ConnectionStringGet());
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds2 = new DataSet();
            //try to fill sataset with query result
            try
            {
                dataAdapter.Fill(ds2);
                dataGrid.ReadOnly = true;
                dataGrid.DataSource = ds2.Tables[0];
            }
            catch (Exception _)
            {
                MessageBox.Show("Query not returned any data");
            }

            db.CloseConn(db.ConnStatus());      // close connection
        }


        private void getAssociatesNumberClick(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }


        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataIndexNo = dataGrid.Rows[e.RowIndex].Index.ToString();
            string cellValue1 = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            string cellValue2 = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            string cellValue3 = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            string cellValue4 = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            string cellValue5 = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            string cellValue6 = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();



            MessageBox.Show(
                                         "\n ID: " +
                 cellValue1.ToString() + "\n UserName: " +
                 cellValue2.ToString() + "\n Password:  " +
                 cellValue3.ToString() + "\n First name:  " +
                 cellValue4.ToString() + "\n Second name:  " +
                 cellValue5.ToString() + "\n Semester:  " +
                 cellValue6.ToString());
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }
    }
}
