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

        private DataSet allCourses;

        public Form_adminCoursesMenu()
        {
            InitializeComponent();
        }

        private void ListCoursesClick(object sender, EventArgs e)
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
                allCourses = ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Query not returned any data");
            }

            db.CloseConn(db.ConnStatus());      // close connection

        }


        private void watchInfoClick(object sender, EventArgs e)
        {
            MessageBox.Show("UNDER CONSTRUCTION");
        }



        private void recieveAmountClick(object sender, EventArgs e)
        {

            DBconnect db = new DBconnect();
            db.OpenConn();

            //create data adapter, count amount of courses in system
            var dataAdapter = new SqlDataAdapter("SELECT COUNT(COURSE_ID)FROM Course", db.ConnectionStringGet());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();

            //try to fill dataset with query result
            try
            {
                dataAdapter.Fill(ds);
                int Courses_amount = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());

                //print result in textBox

                textBox.Text += "There are total of " + Courses_amount.ToString() + " courses in system";
            }
            catch (Exception)
            {
                MessageBox.Show("There is problem with your querry, check it!");
            }

            db.CloseConn(db.ConnStatus());      // close connection



        }


        private void BackClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_adminCoursesMenu_Load(object sender, EventArgs e)
        {

        }

    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dBconnectBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
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
            string cellValue7 = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            string cellValue8 = dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            string cellValue9 = dataGrid.Rows[e.RowIndex].Cells[8].Value.ToString();


            MessageBox.Show(
                                         "\n ID: " +
                 cellValue1.ToString() + "\n Name: " +
                 cellValue2.ToString() + "\n TeacherID:  " +
                 cellValue3.ToString() + "\n MaxStudents:  " +
                 cellValue4.ToString() + "\n Room#:  " +
                 cellValue5.ToString() + "\n Course Day:  " +
                 cellValue6.ToString() + "\n Start Hour:  " +
                 cellValue7.ToString() + "\n End Hour:  " +
                 cellValue8.ToString() + "\n Semester:  " +
                 cellValue9.ToString());
        }

        private void Form_adminCoursesMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_adminMenu parent = (Form_adminMenu)this.Owner;
            parent.Show();
        }
    }
}
