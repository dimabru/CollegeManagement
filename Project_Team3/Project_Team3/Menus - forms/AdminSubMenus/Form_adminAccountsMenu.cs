﻿using System;
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
        DataSet ds;
        private int studentsInSystem = -1;
        private int associatesInSystem = -1;

        public int StudentsInSystem
        {
            get
            {
                return studentsInSystem;
            }
        }

        public int AssociatesInSystem
        {
            get
            {
                return associatesInSystem;
            }
        }

        public DataSet Ds
        {
            get
            {
                return ds;
            }
        }

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
           ds = new DataSet();
            //try to fill sataset with query result
            try
            {
                dataAdapter.Fill(ds);
                dataGrid.ReadOnly = true;
                dataGrid.DataSource = Ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Query not returned any data");
            }

            db.CloseConn(db.ConnStatus());      // close connection
        }

        private void watchAssociates_Click(object sender, EventArgs e)
        {
            ////
            //// Print all associates in system
            ////

            DBconnect db = new DBconnect();
            db.OpenConn();
            //create data adapter
            var dataAdapter = new SqlDataAdapter("SELECT * from Users WHERE ACCESSGROUP='Associate'", db.ConnectionStringGet());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            ds = new DataSet();
            //try to fill sataset with query result
            try
            {
                dataAdapter.Fill(ds);
                dataGrid.ReadOnly = true;
                dataGrid.DataSource = Ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Query not returned any data");
            }

            db.CloseConn(db.ConnStatus());      // close connection
        }


        private void getStudentsNumber_Click(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            db.OpenConn();

            ////
            //// Print amount to Text box
            ////
            //create data adapter, count amount of students in system
            var dataAdapter = new SqlDataAdapter("select count(username) from Student", db.ConnectionStringGet());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();

            //try to fill dataset with query result
            try
            {
                dataAdapter.Fill(ds);
                studentsInSystem = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());

                //print result in textBox

                textBox.Text = "There are total of " + studentsInSystem.ToString() + " Students in system";
            }
            catch (Exception)
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
            catch (Exception)
            {
                MessageBox.Show("Query not returned any data");
            }

            db.CloseConn(db.ConnStatus());      // close connection
        }


        private void getAssociatesNumberClick(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            db.OpenConn();

            ////
            //// Print amount to Text box
            ////
            //create data adapter, count amount of associates in system
            var dataAdapter = new SqlDataAdapter("SELECT count(*) from Users WHERE ACCESSGROUP='Associate'", db.ConnectionStringGet());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();

            //try to fill dataset with query result
            try
            {
                dataAdapter.Fill(ds);
                associatesInSystem = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());

                //print result in textBox

                textBox.Text = "There are total of " + associatesInSystem.ToString() + " Associates in system";
            }
            catch (Exception)
            {
                MessageBox.Show("There is problem with your querry, check it!");
            }

            ////
            //// Print all associates in system
            ////
            //create data adapter
            dataAdapter = new SqlDataAdapter("SELECT * from Users WHERE ACCESSGROUP='Associate'", db.ConnectionStringGet());
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds2 = new DataSet();
            //try to fill sataset with query result
            try
            {
                dataAdapter.Fill(ds2);
                dataGrid.ReadOnly = true;
                dataGrid.DataSource = ds2.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Query not returned any data");
            }

            db.CloseConn(db.ConnStatus());      // close connection
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
            this.Close();
        }

        private void Form_adminAccountsMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_adminMenu parent = (Form_adminMenu)this.Owner;
            parent.Show();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_adminAccountsMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
