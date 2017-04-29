using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Classes
{
    class Course
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

        public string Name { get; set; }
        public string Room { get; set; }
        public string Day { get; set; }
        public string Track { get; set; }
        public int ID { get; set; }
        public int Teacher_id { get; set; }
        public int Max_students { get; set; }
        public int Start_hour { get; set; }
        public int End_hour { get; set; }
        public int Semester { get; set; }
    }
}
