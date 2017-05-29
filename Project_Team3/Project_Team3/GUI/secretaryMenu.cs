using Project_Team3.Courses;
using Project_Team3.Users;
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

            this.sec = sec;

            foreach (int id in cList)
            {
                string name = dataBaseOperations.getCourse(id).getName().Split('_')[0];
                comboBox3.Items.Add(id + " " + name);
            }

            foreach (string r in rList)
            {
                room.Items.Add(dataBaseOperations.getRoom(r).getRoomNumber());
                comboBoxRoom.Items.Add(dataBaseOperations.getRoom(r).getRoomNumber());
            }

            createStaffList();
            foreach (Staff prof in profList)
            {
                comboBoxProfList.Items.Add(prof.getFirstName() + " " + prof.getLastName() + " " + prof.getId());
            }

            foreach (Staff inst in instList)
            {
                comboBoxInstList.Items.Add(inst.getFirstName() + " " + inst.getLastName() + " " + inst.getId());
            }

            FirstNameLabel.Text = sec.getUserName;
            LastNameLabel.Text = sec.getUserLastName;

        }
        secretary sec;

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
        bool changedBoxMandatory;
        bool changedBoxMandatoryPresence;

        //Add Room
        string changedBoxRoomList;
        string newRoomName;
        int? newRoomMaxStudents;

        //Remove Room
        string changedBoxRemoveR;

        //Room info
        List<string> rList = dataBaseOperations.getRoomIdList();

        //Remove Course
        string changedBoxRemove;

        //Teaching staff info
        List<Staff> profList;
        List<Staff> instList;

        public void createStaffList()
        {
            List<ulong> profID = dataBaseOperations.getProfessorIdList();
            List<ulong> instID = dataBaseOperations.getInstructorIdList();

            dataBaseOperations db = new dataBaseOperations();
            profList = new List<Staff>();
            instList = new List<Staff>();

            foreach (ulong id in profID)
            {
                profList.Add(new Staff(id, db.getUserNameById(id), db.getUserLastNameById(id), "Professor"));    
            }

            foreach (ulong id in instID)
            {
                instList.Add(new Staff(id, db.getUserNameById(id), db.getUserLastNameById(id), "Instructor"));
            }
        }

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
                info += select.getName().Split('_')[0] + "\n";

                info += "Teacher ID: ";
                info += select.getTeacherID().ToString() + "\n";

                info += "Course Type: ";
                info += select.getName().Split('_')[1] + "\n";

                info += "Max Students: ";
                info += select.getMaxStudents().ToString() + "\n";

                info += "Room: ";
                info += select.getRoom() + "\n";

                info += "Day: ";
                info += select.getDay() + "\n";

                info += "Start Time: ";
                info += select.getStart().ToString() + ":00\n";

                info += "End Time: ";
                info += select.getEnd().ToString() + ":00\n";

                info += "Semester: ";
                info += select.getSemester().ToString() + "\n";

                info += "Credit Points: ";
                info += select.getCreditPoints().ToString() + "\n";

                info += "Mandatory Course: ";
                if (select.getIsMandatory()) info += "Yes" + "\n";
                else info += "No" + "\n";

                info += "Mandatory Presence: ";
                if (select.getMandatoryPresence()) info += "Yes" + "\n";
                else info += "No" + "\n";
                
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
            else if (mandatoryCourse.Text == "") { MessageBox.Show("Error: Select mandatory or not"); isCorrect = false; }
            else if (mandatoryPresence.Text == "") { MessageBox.Show("Error: Select mandatory presence or not"); isCorrect = false; }

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

            string name = newCourseName + "_" + changedBoxCourseType + "_";
            bool found = false;
            foreach (int id in cList)
            {
                if (dataBaseOperations.getCourse(id).getName().Split('_')[0] == newCourseName)
                {
                    if (dataBaseOperations.getCourse(id).getName().Split('_')[2] == "A") name += "B";
                    else name += "A";
                    found = true;
                    continue;
                }

                if (found && dataBaseOperations.getCourse(id).getName().Split('_')[0] == newCourseName)
                {
                    MessageBox.Show("Error: There can only be up to 2 different times for a course");
                }
            }

            Course course = new Course(newCourseId.Value, name, newCourseTeacherId.Value, newCourseMaxStudents.Value, changedBoxRoom, changedBoxDay,
                Int32.Parse(changedBoxStartTime.Split(':')[0]), Int32.Parse(changedBoxEndTime.Split(':')[0]), Int32.Parse(changedBoxSemester), 
                newCourseCreditPoints.Value, changedBoxMandatory, changedBoxMandatoryPresence);

            if(!correctTimeForClass(course))
            {
                MessageBox.Show("Error: There already is a class at that time in that room");
                return;
            }

            //check if max students in room is at least as large as course's
            if (newCourseMaxStudents > dataBaseOperations.getRoom(changedBoxRoom).getMaxStudent())
            {
                MessageBox.Show("Error: The room's max student limit does not match the limit of the course. Must select a bigger room");
                return;
            }

            if (courseType.Text == "Lecture")
            {
                foreach (Staff prof in profList)
                {
                    if (prof.getId().ToString() == teacherId.Text)
                    {
                        int start = Int32.Parse(startTime.Text.Split(':')[0]);
                        int end = Int32.Parse(endTime.Text.Split(':')[0]);
                        int DAY = publicChecksAndOperations.convDayToInt(day.Text);

                        if (prof.getIsPublished())
                        {
                            MessageBox.Show("The schedule is already published for this teacher. Can't add more courses");
                            return;
                        }
                        foreach (techingStaffConstraints c in CreateConstraintList(prof.getId()))
                        {
                            if (c.getDay == DAY)
                            {
                                if (start >= c.getStart && start < c.getEnds)
                                {
                                    MessageBox.Show("Cannot set a lesson on this time due to teacher's constraints.\nPlease check contraints before setting up a course");
                                    return;
                                }
                                if (end <= c.getEnds && end > c.getStart)
                                {
                                    MessageBox.Show("Cannot set a lesson on this time due to teacher's constraints.\nPlease check contraints before setting up a course");
                                    return;
                                }
                                if (start < c.getStart && end > c.getEnds)
                                {
                                    MessageBox.Show("Cannot set a lesson on this time due to teacher's constraints.\nPlease check contraints before setting up a course");
                                    return;
                                }
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                foreach (Staff inst in instList)
                {
                    if (inst.getId().ToString() == teacherId.Text)
                    {
                        int start = Int32.Parse(startTime.Text.Split(':')[0]);
                        int end = Int32.Parse(endTime.Text.Split(':')[0]);
                        int DAY = publicChecksAndOperations.convDayToInt(day.Text);

                        if (inst.getIsPublished())
                        {
                            MessageBox.Show("The schedule is already published for this teacher. Can't add more courses");
                            return;
                        }

                        foreach (techingStaffConstraints c in CreateConstraintList(inst.getId()))
                        {
                            if (c.getDay == DAY)
                            {
                                if (start >= c.getStart && start < c.getEnds)
                                {
                                    MessageBox.Show("Cannot set a lesson on this time due to teacher's constraints.\nPlease check contraints before setting up a course");
                                    return;
                                }
                                if (end <= c.getEnds && end > c.getStart)
                                {
                                    MessageBox.Show("Cannot set a lesson on this time due to teacher's constraints.\nPlease check contraints before setting up a course");
                                    return;
                                }
                                if (start < c.getStart && end > c.getEnds)
                                {
                                    MessageBox.Show("Cannot set a lesson on this time due to teacher's constraints.\nPlease check contraints before setting up a course");
                                    return;
                                }
                            }
                        }
                        break;
                    }
                }
            }

            dataBaseOperations.addCourse(course);
            cleanFields();
            comboBox3.Items.Add(course.getID() + " " + course.getName().Split('_')[0]);
            
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
            newCourseMaxStudents = null;
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
            dataBaseOperations.addRoom(r);
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

        private void removeR_Click(object sender, EventArgs e)
        {
            foreach (int id in cList)
            {
                if (dataBaseOperations.getCourse(id).getRoom() == changedBoxRoomList)
                {
                    MessageBox.Show("Error: Unable to delete room. First remove all courses assigned to room");
                    return;
                }
            }
            comboBoxRemoveR.Visible = true;
            confirmR.Visible = true;
        }

        private void comboBoxRemoveR_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedBoxRemoveR = comboBoxRemoveR.Text;
        }

        private void confirmR_Click(object sender, EventArgs e)
        {
            if (changedBoxRemoveR == null || (changedBoxRemoveR != "Yes" && changedBoxRemoveR != "No"))
            {
                MessageBox.Show("Error: Must select Yes or No");
                return;
            }

            if (changedBoxRemoveR == "No")
            {
                comboBoxRemoveR.Visible = false;
                confirmR.Visible = false;
            }
            else
            {
                comboBoxRemoveR.Visible = false;
                confirmR.Visible = false;
                dataBaseOperations.removeRoom(changedBoxRoomList);
                comboBoxRoom.Items.Remove(changedBoxRoomList);
                room.Items.Remove(changedBoxRoomList);
            }
        }

        private void oldPassTextBox_TextChanged(object sender, EventArgs e)
        {
            oldPassTextBox.PasswordChar = '*';
        }

        private void newPassChange_TextChanged(object sender, EventArgs e)
        {
            newPassChange.PasswordChar = '*';
        }

        private void newPassConfirm_TextChanged(object sender, EventArgs e)
        {
            newPassConfirm.PasswordChar = '*';
        }

        private void changeMyPassbutton_Click(object sender, EventArgs e)
        {
            if (newPassConfirm.Text == "" || newPassChange.Text == "" || oldPassTextBox.Text == "")
            {
                MessageBox.Show("Error: Must fill all fields");
                return;
            }

            if (newPassChange.Text != newPassConfirm.Text)
            {
                MessageBox.Show("Error: Passwords doesn't match");
                return;
            }

            if (oldPassTextBox.Text != sec.getPassword())
            {
                MessageBox.Show("Error: Incorrect old password");
                return;
            }

            if (newPassChange.Text == oldPassTextBox.Text)
            {
                MessageBox.Show("Error: New password must be different than old password");
                return;
            }

            dataBaseOperations db = new dataBaseOperations();
            db.updateUserPassword(newPassChange.Text, sec.getid());
            MessageBox.Show("Password changed succesfully");
            oldPassTextBox.Text = "";
            newPassChange.Text = "";
            newPassConfirm.Text = "";
            return;
        }

        private void mandatoryCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mandatoryCourse.Text == "Yes") changedBoxMandatory = true;
            else changedBoxMandatory = false;
        }

        private void mandatoryPresence_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mandatoryPresence.Text == "Yes") changedBoxMandatoryPresence = true;
            else changedBoxMandatoryPresence = false;
        }

        private void profInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxProfList.Text == "") MessageBox.Show("Please select a professor to view information");
            else
            {
                ulong id = UInt64.Parse(comboBoxProfList.Text.Split()[comboBoxProfList.Text.Split().Length-1]);
                foreach (Staff prof in profList)
                {
                    if (prof.getId() == id)
                    {
                        string info;
                        List<techingStaffConstraints> constList = CreateConstraintList(id);

                        info = "First Name: ";
                        info += prof.getFirstName();
                        info += "\nLast Name: ";
                        info += prof.getLastName();
                        info += "\nID: ";
                        info += prof.getId();

                        if (constList.Count != 0)
                        {
                            info += "\n\nList of Constraints:\n";

                            foreach (techingStaffConstraints c in constList)
                            {
                                info += "Start: " + c.getStart + ":00 End: " + c.getEnds + ":00\n";
                                info += publicChecksAndOperations.dayConvert(c.getDay) + "\n\n";
                            }
                        }
                        MessageBox.Show(info);
                        break;
                    }
                }
            }
        }

        public List<techingStaffConstraints> CreateConstraintList(ulong id)
        {
            List<techingStaffConstraints> constList = new List<techingStaffConstraints>();
            dataBaseOperations db = new dataBaseOperations();
            int[] cList = db.getConstraints(id);
            db.CloseConn(true);

            if (cList.Length > 1)
            {
                for (int i = 0; i < cList.Length; i += 4)
                {
                    constList.Add(new techingStaffConstraints(cList[i + 1], cList[i + 2], cList[i + 3]));
                }
            }

            return constList;
        }

        private void instInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxInstList.Text == "") MessageBox.Show("Please select an instructor to view information");
            else
            {
                ulong id = UInt64.Parse(comboBoxInstList.Text.Split()[comboBoxInstList.Text.Split().Length - 1]);
                foreach (Staff inst in instList)
                {
                    if (inst.getId() == id)
                    {
                        string info;
                        List<techingStaffConstraints> constList = CreateConstraintList(id);

                        info = "First Name: ";
                        info += inst.getFirstName();
                        info += "\nLast Name: ";
                        info += inst.getLastName();
                        info += "\nID: ";
                        info += inst.getId();

                        if (constList.Count != 0)
                        {
                            info += "\n\nList of Constraints:\n";

                            foreach (techingStaffConstraints c in constList)
                            {
                                info += "Start: " + c.getStart + ":00 End: " + c.getEnds + ":00\n";
                                info += publicChecksAndOperations.dayConvert(c.getDay) + "\n\n";
                            }
                        }
                        MessageBox.Show(info);
                        break;
                    }
                }
            }
        }

        private void profSchedule_Click(object sender, EventArgs e)
        {
            if (comboBoxProfList.Text == "")
            {
                MessageBox.Show("Please select a professor to view schedule");
                return;
            }
            buildSchedule("Professor");
        }

        private void instSchedule_Click(object sender, EventArgs e)
        {
            if (comboBoxInstList.Text == "")
            {
                MessageBox.Show("Please select an instructor to view schedule");
                return;
            }
            buildSchedule("Instructor");
        }

        public void buildSchedule(string type)
        {
            ulong id;
            List<string> courseList;
            dataBaseOperations dataOp = new dataBaseOperations();

            if (type == "Professor")
            {
                id = UInt64.Parse(comboBoxProfList.Text.Split()[comboBoxProfList.Text.Split().Length - 1]);
                professor prof = new professor(id);
                courseList = prof.getCoursesList();
            }
            else
            {
                id = UInt64.Parse(comboBoxInstList.Text.Split()[comboBoxInstList.Text.Split().Length - 1]);
                instructor inst = new instructor(id);
                courseList = inst.getCoursesList();
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
            for (int i = 0; i < courseList.Count; i++)
            {
                //get the attributes of the lecture from DB
                day = dataOp.getAttrByName(courseList[i], 5);
                start = dataOp.getAttrByName(courseList[i], 6);
                end = dataOp.getAttrByName(courseList[i], 7);
                room = dataOp.getAttrByName(courseList[i], 4);
                //convert to location in DataTable
                int location_x = publicChecksAndOperations.convDayToInt(day);
                int location_y_s = publicChecksAndOperations.hourConvertFromStringToInt(start);
                int location_y_e = publicChecksAndOperations.hourConvertFromStringToInt(end);
                string name = courseList[i];
                if ((tempTable.Rows[location_y_s][location_x] != null && !tempTable.Rows[location_y_s][location_x].Equals("System.String") && !string.IsNullOrEmpty(tempTable.Rows[location_y_s][location_x].ToString())))
                    tempTable.Rows[location_y_s][location_x] = "Collision courses!Contact the Secretary";
                else
                    tempTable.Rows[location_y_s][location_x] = courseList[i] + " ( " + room + " )";
                for (int j = location_y_s + 1; j <= (location_y_e); j++)
                {
                    if ((tempTable.Rows[j][location_x] != null && !tempTable.Rows[j][location_x].Equals("System.String") && !string.IsNullOrEmpty(tempTable.Rows[j][location_x].ToString())))
                        tempTable.Rows[j][location_x] = "Collision courses!Contact the Secretary";
                    else
                        tempTable.Rows[j][location_x] = name + " ( " + room + " )";

                }
            }
            //define empty value in cells which dont have lecture 
            for (int i = 0; i < 15; i++)
                for (int j = 1; j < 6; j++)
                {
                    if (tempTable.Rows[i][j] == null || tempTable.Rows[i][j].Equals("System.String") || string.IsNullOrEmpty(tempTable.Rows[i][j].ToString()))

                        tempTable.Rows[i][j] = " ";
                }

            dataGridSchedule.DataSource = tempTable;
            dataGridSchedule.RowHeadersVisible = false;
        }

        private void publishSchedProf_Click(object sender, EventArgs e)
        {
            if (comboBoxProfList.Text == "")
            {
                MessageBox.Show("Please select a professor from the list");
                return;
            }
            new dataBaseOperations().publishSched(UInt64.Parse(comboBoxProfList.Text.Split()[comboBoxProfList.Text.Split().Length-1]));
            foreach (Staff prof in profList)
            {
                if (prof.getId() == UInt64.Parse(comboBoxProfList.Text.Split()[comboBoxProfList.Text.Split().Length - 1])) prof.publishSched();
            }
            MessageBox.Show("Schedule published succesfully");
        }

        private void publishSchedInst_Click(object sender, EventArgs e)
        {
            if (comboBoxInstList.Text == "")
            {
                MessageBox.Show("Please select an instructor from the list");
                return;
            }
            new dataBaseOperations().publishSched(UInt64.Parse(comboBoxInstList.Text.Split()[comboBoxInstList.Text.Split().Length - 1]));
            foreach (Staff inst in instList)
            {
                if (inst.getId() == UInt64.Parse(comboBoxInstList.Text.Split()[comboBoxInstList.Text.Split().Length - 1])) inst.publishSched();
            }
            MessageBox.Show("Schedule published succesfully");
        }

        private void comboBoxProfList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
