﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Courses
{
    public class Course
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
        bool isMandatory;
        bool mandatoryPresence;
        
        public Course(int ID)
        {
            ID = id;
            name = "undefined";
        }

        public Course(int ID, string NAME, ulong TEACHERID, int MAXSTUDENTS, string ROOM, string DAY, int START, int END, int SEMESTER, float CREDITPOINTS, bool ISMANDATORY, bool MANDATORYPRESENCE)
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
            isMandatory = ISMANDATORY;
            mandatoryPresence = MANDATORYPRESENCE;
        }

        public void setId(int newId)
        {
            id = newId;
        }

        public string getName() { return name; }

        public int getID() { return id; }

        public ulong getTeacherID() { return teacherID; }

        public int getMaxStudents() { return maxStudents; }

        public string getRoom() { return room; }

        public string getDay() { return day; }

        public int getStart() { return start; }

        public int getEnd() { return end; }

        public int getSemester() { return semester; }

        public float getCreditPoints() { return creditPoints; }

        public bool getIsMandatory() { return isMandatory; }

        public bool getMandatoryPresence() { return mandatoryPresence; }
    } 
}