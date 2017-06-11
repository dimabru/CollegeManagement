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

        /// <summary>
        /// get the first name
        /// </summary>
        /// <returns></returns>
        public string getFirstName() { return firstName; }

        /// <summary>
        /// get the last name
        /// </summary>
        /// <returns></returns>
        public string getLastName() { return lastName; }

        /// <summary>
        /// get the id
        /// </summary>
        /// <returns></returns>
        public ulong getId() { return id; }

        /// <summary>
        /// get the type
        /// </summary>
        /// <returns></returns>
        public string getType() { return type; }

        /// <summary>
        /// get if is published
        /// </summary>
        /// <returns></returns>
        public bool getIsPublished() { return isPublished; }

        /// <summary>
        /// set that schedule is published
        /// </summary>
        /// <returns></returns>
        public void publishSched() { isPublished = true; }

    }
}
