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
        string type;
        ulong id;
        List <techingStaffConstraints> constList;
        bool isPublished;

        public Staff(ulong ID, string FIRSTNAME, string LASTNAME, string TYPE)
        {
            id = ID;
            firstName = FIRSTNAME;
            lastName = LASTNAME;
            type = TYPE;

            if (type == "Professor")
            {
                professor prof = new professor(id);
                constList = prof.getConstraintsList();
            }
            else
            {
                instructor inst = new instructor(id);
                constList = inst.getConstraintsList();
            }

            isPublished = new dataBaseOperations().getPublishedSched(id);
        }

        public string getFirstName() { return firstName; }

        public string getLastName() { return lastName; }

        public ulong getId() { return id; }

        public string getType() { return type; }

        public bool getIsPublished() { return isPublished; }

        public void publishSched() { isPublished = true; }

    }
}
