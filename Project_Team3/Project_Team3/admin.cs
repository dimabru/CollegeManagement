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
        public admin()
        {

        }

        public admin(ulong id, string username, string name, string password, string accessGroup)
        {

        }

        /// <summary>
        /// in spting 3 this is come to set new user;
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
