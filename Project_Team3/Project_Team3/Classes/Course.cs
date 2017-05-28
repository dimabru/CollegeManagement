using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Classes
{
    public class Course
    {
        private int id, teacher_id, max_students, start_hour, end_hour, semester;
        private string name, room, day, track;
        public Course(int _id, string _name, int _teacher_id, int _max_student, string room_num, string _day, int sHour, int eHour, int sem, string _track)
        {
            id = _id;
            name = _name;
            teacher_id = _teacher_id;
            max_students = _max_student;
            room = room_num;
            day = _day;
            start_hour = sHour;
            end_hour = eHour;
            semester = sem;
            track = _track;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Room
        {
            get
            {
                return room;
            }

            set
            {
                room = value;
            }
        }
        public string Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }
        public string Track
        {
            get
            {
                return track;
            }

            set
            {
                track = value;
            }
        }
        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public int Teacher_id
        {
            get
            {
                return teacher_id;
            }

            set
            {
                teacher_id = value;
            }
        }
        public int Max_students
        {
            get
            {
                return max_students;
            }

            set
            {
                max_students = value;
            }
        }
        public int Start_hour
        {
            get
            {
                return start_hour;
            }

            set
            {
                start_hour = value;
            }
        }
        public int End_hour
        {
            get
            {
                return end_hour;
            }

            set
            {
                end_hour = value;
            }
        }
        public int Semester
        {
            get
            {
                return semester;
            }

            set
            {
                semester = value;
            }
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
