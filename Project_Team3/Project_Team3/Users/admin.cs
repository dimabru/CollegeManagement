using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team3;

namespace Project_Team3
{
    //it's important that the all users be public 
    public class admin : user
    {
        dataBaseOperations dbo = new dataBaseOperations();

        public admin()
        {

        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="accessGroup"></param>
        public admin(ulong id, string username, string name, string password, string accessGroup):base(id,name,password)
        {

        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="id"></param>
        public admin(ulong id):base(id)
        {

        }


        public int how_many_from_this_type(string accessGroup)
        {
            return dbo.how_many_from_this_type(accessGroup);
        }

        /// <summary>
        /// to add new user to the database
        /// </summary>
        /// <param name="userType"></param>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="accessGroup"></param>
        /// <returns></returns>
        public user addUser(userType userType,ulong id,string username,string name,string password,string accessGroup)
        {
            switch (userType)
            {
                case userType.Admin:
                    admin a = new admin(id,username,name,password,accessGroup);
                    return a;
                case userType.Secretary:
                    secretary s = new secretary();
                    return s;
                case userType.professor:
                    break;
                case userType.Instructor:
                    break;
            }
            return null;
        }

    }
}
