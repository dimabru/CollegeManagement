using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3
{
    public class techingStaffConstraints
    {
        private int start = 0;
        private int ends = 0;
        private int day = 0;

        /// <summary>
        /// return the start hour 
        /// this is how you define getters and setters in c#
        /// learn more in this video here: https://www.youtube.com/watch?v=gvQziNULkdY
        /// and microsoft doc here: https://msdn.microsoft.com/en-us/library/w86s7x04.aspx
        /// </summary>
        public int getStart { get { return start; } }

        /// <summary>
        /// return ends hour of constraint
        /// </summary>
        public int getEnds { get { return ends; } }

        /// <summary>
        /// return day of constariant
        /// </summary>
        public int getDay { get { return day; } }


        public techingStaffConstraints(int start, int ends, int day)
        {
            this.setStart(start);
            this.setEnds(ends);
            this.setDay(day);
        }

        //this setters are not made properly by ruls but its works
        //you can refactor it if you want
        
        public void setStart(int toSet)
        {
            this.start = toSet;
        }

        public void setEnds(int toSet)
        {
            this.ends = toSet;
        }

        public void setDay(int toSet)
        {
            this.day = toSet;
        }
    }
}
