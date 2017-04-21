using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Classes
{
    abstract class User
    {

        private String username, name, surename, password,ID;

        public User(String ID, String username, String name, String surename, String password)
        {
            Username = username;
            Name = name;
            Surename = surename;
            Password = password;
            ID_setters = ID;

        }
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
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

        public string Surename
        {
            get
            {
                return surename;
            }

            set
            {
                surename = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public String ID_setters
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }
    }

    
}
