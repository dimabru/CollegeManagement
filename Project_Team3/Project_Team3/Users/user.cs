using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team3
{
    public abstract class user
    {
        private string Lname;
        private string name;
        private ulong id;
        private string password;
        //cAo = checks and operations;
        publicChecksAndOperations cAo = new publicChecksAndOperations();
        dataBaseOperations dbo = new dataBaseOperations();

        public user()
        {
            this.password = dbo.getUserPasswordById(id);
        }

        public user(ulong id)
        {
            this.id = id;
            this.password = dbo.getUserPasswordById(id);
            this.Lname = dbo.getUserLastNameById(id);
            this.name = dbo.getUserNameById(id);
        }

        public user(ulong id,string name,string pass)
        {

        }

        public string getUserName { get { return this.name; } }
        public string getUserLastName { get { return this.Lname; } }

        /// <summary>
        /// change the user password
        /// </summary>
        /// <param name="newPass"></param>
        public void changePassword(string newPass)
        {
            dbo.updateUserPassword(newPass, this.id);
            this.password = newPass;
        }

        /// <summary>
        /// return id
        /// this is how you define getters and setters in c#
        /// learn more in this video here: https://www.youtube.com/watch?v=gvQziNULkdY
        /// and microsoft doc here: https://msdn.microsoft.com/en-us/library/w86s7x04.aspx
        /// </summary>
        public string getPassword()
        {
            return this.password;
        }

        public Boolean setname(string name)
        {
            if(name != null)
            {
                this.name = name;
                return true;
            }
            return false;
        }

        public ulong getid()
        {
            return this.id;
        }

        public void setid(ulong id)
        {
            this.id = id;
        }

        public Boolean setid(string idcheck)
        {
            if(cAo.isNumericUlong(idcheck))
            {
                this.id = publicChecksAndOperations.convertToUlong(idcheck);
                return true;
            }
            return false;
        }
    }
}
