using Project_Team3.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3.GUI
{
    public partial class secretaryMenu : Form
    {

        dataBaseOperations db = new dataBaseOperations();
        public secretaryMenu(secretary sec)
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(760, 460);


            
            /*foreach (int id in cList)
            {
                comboBox3.Items.Add(id + " " + db.getCourse(id).getName());
            }*/

        }
        //Constraints tab
        string changedBoxProf;
        string changedBoxInst;

        //Manage Courses tab
        string changedBoxCourseList;
        //List<int> cList = db.getCourseList();

        //Manage Rooms tab
        string changedBoxRoomList;

        private void checkConstraintStatus(object sender, EventArgs e)
        {
            bool statusProf = true, statusInst = true;
            statusProf = db.getConstraintStatusProf();
            statusInst = db.getConstraintStatusInst();
            string strProf = "Close", strInst = "Close";
            if (statusProf) strProf = "Open";
            if (statusInst) strInst = "Open";
            MessageBox.Show("Professor: " + strProf + "\nInstructor: " + strInst + "\n");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxProf = comboBox1.Text;
        }

        private void ApplyProf(object sender, EventArgs e)
        {
            if (changedBoxProf == null) MessageBox.Show("Must select value first");
            else
            {
                if (changedBoxProf == "Open") db.setConstraintStatusProf(true);
                else db.setConstraintStatusProf(false);
            }
            comboBox1.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxInst = comboBox2.Text;
        }

        private void ApplyInst(object sender, EventArgs e)
        {
            if (changedBoxInst == null) MessageBox.Show("Must select value first");
            else
            {
                if (changedBoxInst == "Open") db.setConstraintStatusInst(true);
                else db.setConstraintStatusInst(false);
            }
            comboBox2.Text = "";
        }

        private void courseList(object sender, EventArgs e)
        {
            changedBoxCourseList = comboBox3.Text;
        }

        private void courseInfo(object sender, EventArgs e)
        {
            if (changedBoxCourseList == null) MessageBox.Show("No course selected");
            else
            {
                string info = "undefined";
                string[] words = changedBoxCourseList.Split();
                int id = Int32.Parse(words[0]);
                Course select;
                //Course select = getCourse(id);
                /*
                info = "ID: ";
                info += select.getID().ToString() + "\n";

                info += "Name: ";
                info += select.getName() + "\n";

                info += "Teacher ID: ";
                info += select.getTeacherID().ToString() + "\n";

                info += "Max Students: ";
                info += select.getMaxStudents().ToString() + "\n";

                info += "Room: ";
                info += select.getRoom() + "\n";

                info += "Day: ";
                info += select.getDay() + "\n";

                info += "Start Time: ";
                info += select.getStart().ToString() + "\n";

                info += "End Time: ";
                info += select.getEnd().ToString() + "\n";

                info += "Semester: ";
                info += select.getSemester().ToString() + "\n";

                info += "Credit Points: ";
                info += select.getCreditPoints().ToString() + "\n";
                */
                MessageBox.Show(info);
            }
        }

        private void roomList(object sender, EventArgs e)
        {
            changedBoxRoomList = comboBox4.Text;
        }

        private void roomInfo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
