using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3.Users
{
    class Staff
    {

        string firstName;
        string lastName;
        int id;

        public Staff(int ID, string FIRSTNAME, string LASTNAME)
        {
            id = ID;
            firstName = FIRSTNAME;
            lastName = LASTNAME;
        }

        public string getFirstName() { return firstName; }

        public string getLastName() { return lastName; }

        public int getId() { return id; }

    }
}
