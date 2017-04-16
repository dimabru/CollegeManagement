using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Courses
{
    class Course
    {

        // List of courses that are mandatory for this course
        private Course[] parents;

        // List of child courses after this course
        private Course[] prerequisite;

        private Lab lab;
        private Lecture lecture;
        private PracticeLesson practice;

        private String name;
        private int id;
        private float creditPoints;
        private bool isMandatory;

        public Course(String n, int i, float credit, bool mand)
        {
            name = n;
            id = i;
            creditPoints = credit;
        }
    }
}


/* Course:
 * int room_number
 * 
 * 
 * 
 * Room
 * int id
 * bool projector
 * 