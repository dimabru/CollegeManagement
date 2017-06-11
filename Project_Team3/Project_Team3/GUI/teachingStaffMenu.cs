using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3
{
    public partial class teachingStaffMenu : Form
    {
        professor prof;
        instructor inst;
        userType theUserWeGot;

        //font size
        //learn more here: https://msdn.microsoft.com/en-us/library/system.drawing.font.size(v=vs.110).aspx
        const float fSize = 12.0F;

        private List<techingStaffConstraints> constraints_List = new List<techingStaffConstraints>();
        private List<string> courses_List = new List<string>();
        publicChecksAndOperations opration = new publicChecksAndOperations();
        dataBaseOperations dataOp = new dataBaseOperations();
        public teachingStaffMenu(user someUser)
        {
            InitializeComponent();

            labelNoSched.Hide();
            //learn more about downcasting here http://stackoverflow.com/questions/1524197/downcast-and-upcast

            if (someUser is professor)
            {
                //make reperance to the object we get
                this.prof = (professor)someUser;
                theUserWeGot = userType.Professor;
            }

            if (someUser is instructor)
            {
                //make reperance to the object we get
                this.inst = (instructor)someUser;
                theUserWeGot = userType.Instructor;
            }

            //change this form size 
            //see also: https://msdn.microsoft.com/en-us/library/ms229606(v=vs.110).aspx 
            this.Size = new System.Drawing.Size(1000, 550);

            //set position in the center;
            //see also: https://msdn.microsoft.com/en-us/library/system.windows.forms.form.startposition(v=vs.110).aspx
            this.StartPosition = FormStartPosition.CenterScreen;

            //set the item in the combo boxes
            setComboBoxes();

            set_account_Management();

            //hide constraints panel;
            panel1.Hide();

            //build schedule if the schedule is published by the secretary
            if (new dataBaseOperations().getPublishedSched(someUser.getid())) build_schedule(someUser);
            else labelNoSched.Show();

            watch_your_constraints(null, null);
        }

        //build schedule to professor or instructor
        private void build_schedule(user someUser)
        {

            if (someUser is professor)
            {
                //make reperance to the object we get
                this.prof = (professor)someUser;
                courses_List = this.prof.getCoursesList();
            }

            if (someUser is instructor)
            {
                //make reperance to the object we get
                this.inst = (instructor)someUser;
                courses_List = this.inst.getCoursesList();
            }



            //build DataTable 
            DataTable tempTable = new DataTable();
            tempTable.Columns.Add(" ", typeof(string));
            tempTable.Columns.Add("Sunday", typeof(string));
            tempTable.Columns.Add("Monday", typeof(string));
            tempTable.Columns.Add("Tuesday", typeof(string));
            tempTable.Columns.Add("Wednesday", typeof(string));
            tempTable.Columns.Add("Thursday", typeof(string));
            tempTable.Columns.Add("Friday", typeof(string));
            tempTable.Rows.Add("07:00", typeof(string));
            tempTable.Rows.Add("08:00", typeof(string));
            tempTable.Rows.Add("09:00", typeof(string));
            tempTable.Rows.Add("10:00", typeof(string));
            tempTable.Rows.Add("11:00", typeof(string));
            tempTable.Rows.Add("12:00", typeof(string));
            tempTable.Rows.Add("13:00", typeof(string));
            tempTable.Rows.Add("14:00", typeof(string));
            tempTable.Rows.Add("15:00", typeof(string));
            tempTable.Rows.Add("16:00", typeof(string));
            tempTable.Rows.Add("17:00", typeof(string));
            tempTable.Rows.Add("18:00", typeof(string));
            tempTable.Rows.Add("19:00", typeof(string));
            tempTable.Rows.Add("20:00", typeof(string));
            tempTable.Rows.Add("21:00", typeof(string));
            string day = "";
            string start = "";
            string end = "";
            string room = "";
            //enter lectures to DataTable
            for (int i = 0; i < courses_List.Count; i++)
            {
                //get the attributes of the lecture from DB
                day = dataOp.getAttrByName(courses_List[i], 5);
                start = dataOp.getAttrByName(courses_List[i], 6);
                end = dataOp.getAttrByName(courses_List[i], 7);
                room = dataOp.getAttrByName(courses_List[i], 4);
                //convert to location in DataTable
                int location_x = publicChecksAndOperations.convDayToInt(day);
                int location_y_s = publicChecksAndOperations.hourConvertFromStringToInt(start);
                int location_y_e = publicChecksAndOperations.hourConvertFromStringToInt(end);
                string name = courses_List[i];
                if ((tempTable.Rows[location_y_s][location_x] != null && !tempTable.Rows[location_y_s][location_x].Equals("System.String") && !string.IsNullOrEmpty(tempTable.Rows[location_y_s][location_x].ToString())))
                    tempTable.Rows[location_y_s][location_x] = "Collision courses!Contact the Secretary";
               else
                    tempTable.Rows[location_y_s][location_x] = courses_List[i]+ " ( " +room+ " )";
                for(int j=location_y_s+1; j<=(location_y_e); j++)
                {
                    if ((tempTable.Rows[j][location_x] != null && !tempTable.Rows[j][location_x].Equals("System.String") && !string.IsNullOrEmpty(tempTable.Rows[j][location_x].ToString())))
                        tempTable.Rows[j][location_x] = "Collision courses!Contact the Secretary";
                    else
                        tempTable.Rows[j][location_x] = name + " ( " + room + " )";

                }
            }
            //define empty value in cells which dont have lecture 
            for (int i=0; i<15; i++)
                for(int j=1; j<6; j++)
                {
                    if (tempTable.Rows[i][j] == null || tempTable.Rows[i][j].Equals("System.String") || string.IsNullOrEmpty(tempTable.Rows[i][j].ToString()))
                     
                    tempTable.Rows[i][j] = " ";
                }
          
            dataGridView2.DataSource = tempTable;
            dataGridView2.RowHeadersVisible = false;

        }

        private void set_account_Management()
        {
            //here you can learn how to set fonts: https://msdn.microsoft.com/en-us/library/system.drawing.font.size(v=vs.110).aspx
            nameLable.Text = "name:";
            lastNameLabel.Text = "last name:";

            //with enum we can know the type of user we have to customize the menu for him
            if (theUserWeGot == userType.Professor)
            {
                lNameLable.Text = prof.getUserLastName;
                UnameLable.Text = prof.getUserName;
            }

            if (theUserWeGot == userType.Instructor)
            {
                lNameLable.Text = inst.getUserLastName;
                UnameLable.Text = inst.getUserName;
            }

            lastNameLabel.Font = new Font(lastNameLabel.Font.Name, fSize, lastNameLabel.Font.Style, lastNameLabel.Font.Unit);
            nameLable.Font = new Font(nameLable.Font.Name, fSize, nameLable.Font.Style, nameLable.Font.Unit);
        }

        private void professorMenu_Load(object sender, EventArgs e)
        {

        }
        
        private void watch_your_constraints(object sender, EventArgs e)
        {
            //with enum we can know the type of user we have to customize the menu for him
            if (theUserWeGot == userType.Professor)
            {
                constraints_List = prof.getConstraintsList();
            }

            if (theUserWeGot == userType.Instructor)
            {
                constraints_List = inst.getConstraintsList();
            }


            //learn more about data table here: https://msdn.microsoft.com/en-us/library/system.data.datatable(v=vs.110).aspx
            //and here in the bottom you can find examples for data grid: https://msdn.microsoft.com/en-us/library/system.windows.forms.datagrid(v=vs.110).aspx

            DataTable tempTable = new DataTable();
            tempTable.Columns.Add("start", typeof(string));
            tempTable.Columns.Add("ends", typeof(string));
            tempTable.Columns.Add("day", typeof(string));

            string conv1 = "";
            string conv2 = "";
            string conv3 = "";

            for (int i = 0; i < constraints_List.Count; i++)
            {
                //i made this function static and i think we should do it for all the function in "publicChecksAnd Operations"
                //but we have to remember to replace all the places we create an instance
                conv1 = publicChecksAndOperations.hourConvertFromIntToString(constraints_List[i].getStart);
                conv2 = publicChecksAndOperations.hourConvertFromIntToString(constraints_List[i].getEnds);
                conv3 = publicChecksAndOperations.dayConvert(constraints_List[i].getDay);
                
                tempTable.Rows.Add(conv1,conv2,conv3);
            }
            
            dataGridView1.DataSource = tempTable;
            
        }


        public void clearMyConstraints(object sender, EventArgs e)
        {
            //with enum we can know the type of user we have to customize the menu for him
            if (theUserWeGot == userType.Professor)
            {
                prof.deleteAllConstraints();
            }

            if (theUserWeGot == userType.Instructor)
            {
                inst.deleteAllConstraints();
            }
            watch_your_constraints(sender,e);
        }

        private void addConstraintsButton(object sender, EventArgs e)
        {
            panel1.Show();
            watch_your_constraints(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// enter the constraints to user constaraints list and to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enter_constraints_to_user_and_database(object sender, EventArgs e)
        {
            //learn more about trim here: https://msdn.microsoft.com/en-us/library/kxbw3kwc(v=vs.110).aspx

            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("you have to enter constraint");
                panel1.Hide();
                return;
            }

            int conv1 = publicChecksAndOperations.convDayToInt(comboBox1.Text);
            char toTrim1 = '0';
            char toTrim2 = ':';
            string start = comboBox2.Text.Trim(toTrim1).Trim(toTrim2);
            string end = comboBox3.Text.Trim(toTrim1).Trim(toTrim2);

            //with enum we can know the type of user we have to customize the menu for him
            if (theUserWeGot == userType.Professor)
            {
                prof.insertConstrints(Convert.ToInt32(start), Convert.ToInt32(end), conv1);
            }

            if (theUserWeGot == userType.Instructor)
            {
                inst.insertConstrints(Convert.ToInt32(start), Convert.ToInt32(end), conv1);
            }
            panel1.Hide();
        }


        private void changeMyPassbutton_Click(object sender, EventArgs e)
        {
            if (oldPassTextBox.Text == "" || newPassTextBox.Text == "" || confPassTextBox.Text == "")
            {
                MessageBox.Show("you have to fill all fields");
                return;
            }
            if (newPassTextBox.Text != confPassTextBox.Text)
            {
                MessageBox.Show("Password does not match the confirm password.");
                return;
            }

            //with enum we can know the type of user we have to customize the menu for him
            if (theUserWeGot == userType.Professor)
            {
                if (oldPassTextBox.Text ==  prof.getPassword())
                {
                    prof.changePassword(newPassTextBox.Text);
                    MessageBox.Show("the password has changed");
                    return;
                }
                MessageBox.Show("the old password is not correct");
                return;
            }

            //change the password
            if (theUserWeGot == userType.Instructor)
            {
                if (oldPassTextBox.Text == inst.getPassword())
                {
                    inst.changePassword(newPassTextBox.Text);
                    MessageBox.Show("the password has changed");
                    return;
                }
                MessageBox.Show("the old password is not correct");
                return;
            }
        }


        /// <summary>
        /// initialize all comboBox items
        /// </summary>
        private void setComboBoxes()
        {
            //learn more form here https://social.msdn.microsoft.com/Forums/windows/en-US/c7a82a6a-763e-424b-84e0-496caa9cfb4d/how-add-a-item-to-combobox?forum=winforms
            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Monday");
            comboBox1.Items.Add("Tuesday");
            comboBox1.Items.Add("Wednesday");
            comboBox1.Items.Add("Thursday");
            comboBox1.Items.Add("Friday");
            comboBox1.Items.Add("Saturday");

            comboBox2.Items.Add("07:00");
            comboBox2.Items.Add("08:00");
            comboBox2.Items.Add("09:00");
            comboBox2.Items.Add("10:00");
            comboBox2.Items.Add("11:00");
            comboBox2.Items.Add("12:00");
            comboBox2.Items.Add("13:00");
            comboBox2.Items.Add("14:00");
            comboBox2.Items.Add("15:00");
            comboBox2.Items.Add("16:00");
            comboBox2.Items.Add("17:00");
            comboBox2.Items.Add("18:00");
            comboBox2.Items.Add("19:00");
            comboBox2.Items.Add("20:00");
            comboBox2.Items.Add("21:00");
            comboBox2.Items.Add("22:00");
            comboBox2.Items.Add("23:00");

            comboBox3.Items.Add("07:00");
            comboBox3.Items.Add("08:00");
            comboBox3.Items.Add("09:00");
            comboBox3.Items.Add("10:00");
            comboBox3.Items.Add("11:00");
            comboBox3.Items.Add("12:00");
            comboBox3.Items.Add("13:00");
            comboBox3.Items.Add("14:00");
            comboBox3.Items.Add("15:00");
            comboBox3.Items.Add("16:00");
            comboBox3.Items.Add("17:00");
            comboBox3.Items.Add("18:00");
            comboBox3.Items.Add("19:00");
            comboBox3.Items.Add("20:00");
            comboBox3.Items.Add("21:00");
            comboBox3.Items.Add("22:00");
            comboBox3.Items.Add("23:00");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void oldPassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
