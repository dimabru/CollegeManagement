using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Classes
{
    public class User
    {

        private String username, name, surename, password,ID, Email;

        public User(String ID, String username, String name, String surename, String password, String mail)
        {
            Username = username;
            Name = name;
            Surename = surename;
            Password = password;
            ID_setters = ID;
            Email = mail;

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
        public string email
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
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
