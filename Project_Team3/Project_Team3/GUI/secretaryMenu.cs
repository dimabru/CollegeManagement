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

        public secretaryMenu(secretary sec)
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(760, 460);


            
            foreach (int id in cList)
            {
                string name = dataBaseOperations.getCourse(id).getName().Split('_')[0];
                comboBox3.Items.Add(id + " " + dataBaseOperations.getCourse(id).getName());
            }

            foreach (string r in rList)
            {
                room.Items.Add(dataBaseOperations.getRoom(r).getRoomNumber());
                comboBoxRoom.Items.Add(dataBaseOperations.getRoom(r).getRoomNumber());
            }

        }
        //Constraints tab
        string changedBoxProf;
        string changedBoxInst;

        //Manage Courses tab
        //Course Info
        string changedBoxCourseList;
        List<int> cList = dataBaseOperations.getCourseIdList();

        //Add Course
        string newCourseName;
        int? newCourseId;
        ulong? newCourseTeacherId;
        string changedBoxCourseType;
        int? newCourseMaxStudents;
        string changedBoxRoom;
        string changedBoxDay;
        string changedBoxStartTime;
        string changedBoxEndTime;
        string changedBoxSemester;
        float? newCourseCreditPoints;

        //Add Room
        string changedBoxRoomList;
        string newRoomName;
        int? newRoomMaxStudents;

        //Room info
        List<string> rList = dataBaseOperations.getRoomIdList();

        //Remove Course
        string changedBoxRemove;

        private void checkConstraintStatus(object sender, EventArgs e)
        {
            bool statusProf = true, statusInst = true;
            statusProf = dataBaseOperations.getConstraintStatusProf();
            statusInst = dataBaseOperations.getConstraintStatusInst();
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
                if (changedBoxProf == "Open") dataBaseOperations.setConstraintStatusProf(true);
                else dataBaseOperations.setConstraintStatusProf(false);
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
                if (changedBoxInst == "Open") dataBaseOperations.setConstraintStatusInst(true);
                else dataBaseOperations.setConstraintStatusInst(false);
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
                Course select = dataBaseOperations.getCourse(id);
                
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
                
                MessageBox.Show(info);
            }
        }

        private void courseType_TextChanged(object sender, EventArgs e)
        {
            changedBoxCourseType = courseType.Text;
        }

        private void addCourseName(object sender, EventArgs e)
        {
            newCourseName = courseName.Text;
        }

        private void courseID_TextChanged(object sender, EventArgs e)
        {
            int check;
            if (Int32.TryParse(courseID.Text, out check)) newCourseId = new int?(check);
        }

        private void teacherId_TextChanged(object sender, EventArgs e)
        {
            int check;
            if (Int32.TryParse(teacherId.Text, out check)) newCourseTeacherId = publicChecksAndOperations.convertToUlong(teacherId.Text);
        }

        private void maxStudents_TextChanged(object sender, EventArgs e)
        {
            int check;
            if (Int32.TryParse(maxStudents.Text, out check)) newCourseMaxStudents = new int?(check);
        }

        private void room_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxRoom = room.Text;
        }

        private void day_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxDay = day.Text;
        }

        private void startTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxStartTime = startTime.Text;
        }

        private void endTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxEndTime = endTime.Text;
        }

        private void semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxSemester = semester.Text;
        }

        private void creditPoints_TextChanged(object sender, EventArgs e)
        {
            float check;
            if (float.TryParse(creditPoints.Text, out check)) newCourseCreditPoints = new float?(check);
        }

        private void submitNewCourse_Click(object sender, EventArgs e)
        {
            bool isCorrect = true;

            //check if all data filled correctly
            if (newCourseName == null) { MessageBox.Show("Error: invalid name"); isCorrect = false; }
            else if (newCourseId == null) { MessageBox.Show("Error: invalid course ID"); isCorrect = false; }
            else if (newCourseTeacherId == null) { MessageBox.Show("Error: invalid teacher ID"); isCorrect = false; }
            else if (changedBoxCourseType == null) { MessageBox.Show("Error: invalid course type"); isCorrect = false; }
            else if (newCourseMaxStudents == null) { MessageBox.Show("Error: invalid max students"); isCorrect = false; }
            else if (changedBoxRoom == null) { MessageBox.Show("Error: invalid room"); isCorrect = false; }
            else if (changedBoxDay == null) { MessageBox.Show("Error: invalid day"); isCorrect = false; }
            else if (changedBoxStartTime == null) { MessageBox.Show("Error: invalid start time"); isCorrect = false; }
            else if (changedBoxEndTime == null) { MessageBox.Show("Error: invalid end time"); isCorrect = false; }
            else if (changedBoxSemester == null) { MessageBox.Show("Error: invalid semester"); isCorrect = false; }
            else if (newCourseCreditPoints == null) { MessageBox.Show("Error: invalid credit points"); isCorrect = false; }

            if (!isCorrect) return;

            //check if course already exist
            Course isExist = dataBaseOperations.getCourse(newCourseId.Value);
            if (isExist != null) { MessageBox.Show("Error: The current Course ID already exist"); return; }

            //check if teacher exists and fits type of course
            if (changedBoxCourseType == "Lecture")
            {
                List<ulong> profList = dataBaseOperations.getProfessorIdList();
                isCorrect = false;
                foreach (ulong value in profList)
                {
                    if (value == newCourseTeacherId)
                    {
                        isCorrect = true;
                        break;
                    }
                }
            }

            else if (changedBoxCourseType == "Practice Lesson")
            {
                List<ulong> instList = dataBaseOperations.getInstructorIdList();
                isCorrect = false;
                foreach (ulong value in instList)
                {
                    if (value == newCourseTeacherId)
                    {
                        isCorrect = true;
                        break;
                    }
                }
            }

            if (!isCorrect) MessageBox.Show("Error: No such teacher");

            //check for positive numbers
            if (newCourseMaxStudents <= 0) { MessageBox.Show("Error: Max students must be a positive number"); return; }
            if (newCourseCreditPoints<= 0) { MessageBox.Show("Error: Credit points must be a positive number"); return; }

            //check if start and end set correctly
            if (!correctStartEnd(changedBoxStartTime, changedBoxEndTime))
            {
                MessageBox.Show("Error: End time must be larger than start time");
                return;
            }

            Course course = new Course(newCourseId.Value, newCourseName, newCourseTeacherId.Value, newCourseMaxStudents.Value, changedBoxRoom, changedBoxDay,
                Int32.Parse(changedBoxStartTime.Split(':')[0]), Int32.Parse(changedBoxEndTime.Split(':')[0]), Int32.Parse(changedBoxSemester), 
                newCourseCreditPoints.Value);

            if(!correctTimeForClass(course))
            {
                MessageBox.Show("Error: There already is a class at that time in that room");
                return;
            }

            dataBaseOperations.addCourse(course);
            cleanFields();
            comboBox3.Items.Add(course.getID() + " " + dataBaseOperations.getCourse(course.getID()).getName());

        }

        private bool correctTimeForClass(Course course)
        {
            foreach (int c in cList)
            {
                Course check = dataBaseOperations.getCourse(c);
                if (check.getDay() == course.getDay())
                {
                    if (!checkDifferentTime(check.getStart(),check.getEnd(),course.getStart(),course.getEnd()))
                    {
                        if (check.getRoom() == course.getRoom()) return false;
                    }
                }
            }
            return true;
        }

        private bool checkDifferentTime(int start1, int end1, int start2, int end2)
        {
            if (start2 >= start1 && start2 < end1) return false;
            if (end2 > start1 && end2 <= end1) return false;
            return true;
        }

        private bool correctStartEnd(string start, string end)
        {
            int istart, iend;
            istart = Int32.Parse(start.Split(':')[0]);
            iend = Int32.Parse(end.Split(':')[0]);
            if (iend <= istart) return false;
            return true;
        }

         private void cleanFields()
        {
            courseName.Text = "";
            courseID.Text = "";
            teacherId.Text = "";
            courseType.Text = "";
            maxStudents.Text = "";
            room.Text = "";
            day.Text = "";
            startTime.Text = "";
            endTime.Text = "";
            semester.Text = "";
            creditPoints.Text = "";
            newCourseName = null;
            newCourseId = null;
            newCourseTeacherId = null;
            changedBoxCourseType = null;
            newCourseMaxStudents = null;
            changedBoxRoom = null;
            changedBoxDay = null;
            changedBoxStartTime = null;
            changedBoxEndTime = null;
            changedBoxSemester = null;
            newCourseCreditPoints = null;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            comboBoxRemove.Visible = true;
            confirm.Visible = true;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (changedBoxRemove == null) MessageBox.Show("Error: Must select Yes or No");
            else if (changedBoxRemove == "No")
            {
                comboBoxRemove.Visible = false;
                confirm.Visible = false;
            }
            else if (changedBoxRemove == "Yes")
            {
                dataBaseOperations.removeCourse(Int32.Parse(changedBoxCourseList.Split()[0]));
                comboBox3.Items.Remove(changedBoxCourseList);
                comboBoxRemove.Visible = false;
                confirm.Visible = false;
            }

            else MessageBox.Show("Error: Must select Yes or No");
        }

        private void comboBoxRemove_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxRemove = comboBoxRemove.Text;
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxRoomList = comboBoxRoom.Text;
        }

        private void roomNumber_TextChanged(object sender, EventArgs e)
        {
            newRoomName = roomNumber.Text;
        }

        private void roomMaxStudents_TextChanged(object sender, EventArgs e)
        {
            int check;
            if (Int32.TryParse(roomMaxStudents.Text, out check)) newRoomMaxStudents = check;
        }

        private void submitRoom_Click(object sender, EventArgs e)
        {
            if (newRoomMaxStudents == null || newRoomName == null)
            {
                MessageBox.Show("Error: Not all fields are filled correctly");
                return;
            }

            Room r = new Room(newRoomName, newRoomMaxStudents.Value);
            room.Items.Add(r.getRoomNumber());
            comboBoxRoom.Items.Add(r.getRoomNumber());
            cleanRFields();
        }

        private void roomInfo_Click(object sender, EventArgs e)
        {
            string info;
            Room r = dataBaseOperations.getRoom(changedBoxRoomList);
            if (r == null)
            {
                MessageBox.Show("Error: Must select a room");
                return;
            }

            info = "Room Number: ";
            info += r.getRoomNumber() + "\n";

            info += "Max Students: ";
            info += r.getMaxStudent();

            MessageBox.Show(info);
        }

        private void cleanRFields()
        {
            roomMaxStudents.Text = "";
            roomNumber.Text = "";
            newRoomMaxStudents = null;
            newRoomName = null;
        }
    }
}
