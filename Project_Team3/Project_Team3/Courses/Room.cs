using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Courses
{
    class Room
    {
        string roomNumber;
        int maxStudent;

        public Room(string Rnumber,int max_student)
        {
            roomNumber = Rnumber;
            this.maxStudent = max_student;
        }

        public void setRoomNumber(string Rnumber)
        {
            this.roomNumber = Rnumber;
        }

        public string getRoomNumber()
        {
            return roomNumber;
        }

        public void setMaxStudent(int max_student)
        {
            this.maxStudent = max_student;
        }

        public int getMaxStudent()
        {
            return this.maxStudent;
        }
    }
}
