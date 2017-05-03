using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Courses
{
    class Course
    {

        int id;
        string name;
        ulong teacherID;
        int maxStudents;
        string room;
        string day;
        int start;
        int end;
        int semester;
        float creditPoints;

        public Course(int ID)
        {
            ID = id;
            name = "undefined";
        }

        public Course(int ID, string NAME, ulong TEACHERID, int MAXSTUDENTS, string ROOM, string DAY, int START, int END, int SEMESTER, float CREDITPOINTS)
        {
            id = ID;
            name = NAME;
            teacherID = TEACHERID;
            maxStudents = MAXSTUDENTS;
            room = ROOM;
            day = DAY;
            start = START;
            end = END;
            semester = SEMESTER;
            creditPoints = CREDITPOINTS;
        }
    }
}