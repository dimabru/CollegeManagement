using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Team3;

namespace UnitTestsProject
{
    //Login
    [TestClass]
    public class LoginBranchA
    {
        ulong id = 123;
        string pass = "abc";

        //Professor login_1
        [TestMethod]
        public void professorLogin()
        {
            professor prof = new professor(id);
            teachingStaffMenu porfMen = new teachingStaffMenu(prof);
            Assert.IsTrue(prof is professor && porfMen is teachingStaffMenu);
        }

        //Instructor login_2
        [TestMethod]
        public void instructorLogin()
        {
            instructor inst = new instructor(id);
            teachingStaffMenu instMen = new teachingStaffMenu(inst);
            Assert.IsTrue(pass is string && inst is instructor && instMen is teachingStaffMenu);
        }

        //Admin login_3
        [TestMethod]
        public void adminLogin()
        {
            admin ad = new admin(id);
            teachingStaffMenu adfMen = new teachingStaffMenu(ad);
            Assert.IsTrue(pass is string && ad is admin && adfMen is teachingStaffMenu);
        }

        //Secretary login_4
        [TestMethod]
        public void secretaryLogin()
        {
            secretary secr = new secretary(id);
            teachingStaffMenu secrMen = new teachingStaffMenu(secr);
            Assert.IsTrue(pass is string && secr is secretary && secrMen is teachingStaffMenu);
        }
    }


    //Logoff
    [TestClass]
    public class LogoffBranchA
    {
        //Professor logoff_5
        [TestMethod]
        public void professorLogoff()
        {

        }

        //Instructor logoff_6
        [TestMethod]
        public void instructorLogoff()
        {

        }

        //Admin logoff_7
        [TestMethod]
        public void adminLogoff()
        {

        }

        //Secretary logoff_8
        [TestMethod]
        public void secretaryLogoff()
        {

        }
    }
}