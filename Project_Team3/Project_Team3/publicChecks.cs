using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3
{
    class publicChecks
    {
        private static Boolean userExit = false;

        public Boolean isNumeric(String StringToCheck)
        {
            int n;
            bool isNumeric = int.TryParse(StringToCheck, out n);

            if (int.TryParse(StringToCheck, out n))
            {
                return true;
            }
            return false;
        }

        public Boolean didUserExit()
        {
            return userExit;
        }

        public void setUserExit()
        {
            userExit = true;
        }
    }
}
