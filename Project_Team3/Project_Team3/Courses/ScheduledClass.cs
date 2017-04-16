using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Courses
{
    class ScheduledClass
    {
        private Room room;
        private DayOfWeek day;
        private int start;
        private int end;

        public ScheduledClass(Room r, DayOfWeek d, int s, int e)
        {
            room = new Room(r);
            day = d;
            if (s < 0 || s > 23) s=0;
            else start = s;
            if (e < 1 || e > 24 || e <= start) e = 24;
            else end = e;
        }

        public ScheduledClass(ScheduledClass sched)
        {
            room = sched.room;
            day = sched.day;
            start = sched.start;
            end = sched.end;
        }
        
        public Room getRoom() { return room; }
        public DayOfWeek getDay() { return day; }
        public int getStart() { return start; }
        public int getEnd() { return end; }

        public void setRoom(Room r) { room = r; }

        public void setDay(DayOfWeek d) { day = d; }
        public bool setStart(int s)
        {
            if (s < 0 || s > 23) return false;
            start = s;
            return true;
        }

        public bool setEnd(int e)
        {
            if (e < 1 || e > 24 || e <= start) return false;
            end = e;
            return true;
        }
    }
}
