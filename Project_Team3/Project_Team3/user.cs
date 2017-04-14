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
        private string name;
        private ulong id;
        private string password;
        //cAo = checks and operations;
        publicChecksAndOperations cAo = new publicChecksAndOperations();

        public user()
        {

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
                this.id = cAo.convertToUlong(idcheck);
                return true;
            }
            return false;
        }
    }
}
