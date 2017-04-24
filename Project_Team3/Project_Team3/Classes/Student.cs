using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Classes
{
    public class Student : User
    {
        private int semester;
        public Student(String id, String username, String name, String surename, String password,int semester): base(id, username, name, surename, password)
        {   
            Semester = semester;
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
            return this.Name + " " + this.Surename;
        }
    }
}
