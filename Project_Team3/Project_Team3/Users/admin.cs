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

        /// <summary>
        /// delete user by his id
        /// </summary>
        /// <param name="id"></param>
        public void deleteUserById(ulong id)
        {
            try
            {
                dbo.deleteUser(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// return the user access group
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getUserAccessGroup(ulong id)
        {
            return dbo.getUserAccessGroupById(id);
        }

        /// <summary>
        /// set new user in data base
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="pass"></param>
        /// <param name="accessGroup"></param>
        public void set_new_user(ulong id, string name, string lastName, string pass, string accessGroup)
        {
            dbo.setNewUser(id,name,lastName,pass,accessGroup);
        }

        /// <summary>
        /// this function get number of user from data base and return it
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <returns></returns>
        public int how_many_from_this_type(string accessGroup)
        {
            return dbo.how_many_from_this_type(accessGroup);
        }
    }
}
