using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3
{
    class Room
    {

        private bool board, projector;
        private int maxStudents;
        private String location;

        public Room(bool brd, bool proj, int max, String loc)
        {
            board = brd;
            projector = proj;
            maxStudents = max;
            location = loc;
        }

        public Room(Room r)
        {
            board = r.board;
            projector = r.projector;
            maxStudents = r.maxStudents;
            location = r.location;
        }

        public bool getBoard() { return board; }
        public bool getProjector() { return projector; }
        public int getMaxStudents() { return maxStudents; }
        public String getLocation() { return location; }

        public void setBoard(bool b) { board = b; }
        public void setProjector(bool p) { projector = p; }
        public bool setMaxStudents(int max)
        {
            if (max < 1) return false;
            maxStudents = max;
            return true;
        }
        public bool setLocation(String loc)
        {
            if (loc.Equals("")) return false;
            location = loc;
            return true;
        }
    }
}
