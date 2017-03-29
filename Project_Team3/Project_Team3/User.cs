using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team3
{
    class User
    {
        private int userID;
        private String username;
        private String password;
        private String accessGroup;


        public User()
        {
            userID = 0;
            username = "NULL";
            password = "NULL";
            accessGroup = "NULL";
        }
      public  User(int id, String username, String password, String accessGroup)
        {
            this.userID = id;
            this.username = username;
            this.password = password;
            this.accessGroup = accessGroup;
        }


    }



}
