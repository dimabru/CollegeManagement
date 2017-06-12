using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Team3;
using Project_Team3.GUI;
using System;

namespace UnitTestsProject
{
    //Login
    [TestClass]
    public class LoginBranchA
    {
        ulong id = 123456789;

        //Professor login_1
        [TestMethod]
        public void professorLogin()
        {
            professor professor = new professor(id);
            teachingStaffMenu professorMenu = new teachingStaffMenu(professor);
            Assert.IsTrue(professor is professor && professorMenu is teachingStaffMenu);
        }

        //Instructor login_2
        [TestMethod]
        public void instructorLogin()
        {
            instructor instructor = new instructor(id);
            teachingStaffMenu instructorMenu = new teachingStaffMenu(instructor);
            Assert.IsTrue(instructor is instructor && instructorMenu is teachingStaffMenu);
        }

        //Admin login_3
        [TestMethod]
        public void adminLogin()
        {
            admin admin = new admin(id);
            teachingStaffMenu adminMenu = new teachingStaffMenu(admin);
            Assert.IsTrue(admin is admin && adminMenu is teachingStaffMenu);
        }

        //Secretary login_4
        [TestMethod]
        public void secretaryLogin()
        {
            secretary secretary = new secretary(id);
            teachingStaffMenu secretaryMenu = new teachingStaffMenu(secretary);
            Assert.IsTrue(secretary is secretary && secretaryMenu is teachingStaffMenu);
        }
    }


    //Logoff
    [TestClass]
    public class LogoffBranchA
    {
        ulong id = 123456789;

        //Professor logoff_5
        [TestMethod]
        public void professorLogoff()
        {
            professor professor = new professor(id);
            teachingStaffMenu professorMenu = new teachingStaffMenu(professor);
            professorMenu.Close();
            Assert.IsNotNull(professorMenu);
        }

        //Instructor logoff_6
        [TestMethod]
        public void instructorLogoff()
        {
            instructor instructor = new instructor(id);
            teachingStaffMenu instructorMenu = new teachingStaffMenu(instructor);
            instructorMenu.Close();
            Assert.IsNotNull(instructorMenu);
        }

        //Admin logoff_7
        [TestMethod]
        public void adminLogoff()
        {
            admin admin = new admin(id);
            adminMenu adminMenu = new adminMenu(admin);
            adminMenu.Close();
            Assert.IsNotNull(adminMenu);
        }

        //Secretary logoff_8
        [TestMethod]
        public void secretaryLogoff()
        {
            secretary secretary = new secretary(id);
            secretaryMenu secretaryMenu = new secretaryMenu(secretary);
            secretaryMenu.Close();
            Assert.IsNotNull(secretaryMenu);
        }
    }

    //Sign in
    [TestClass]
    public class SignInBranchA
    {
        dataBaseOperations DB = new dataBaseOperations();
        int id = 123456789;
        string name = "test", password = "test", userType;

        //Professor signin_9
        [TestMethod]
        public void signInProfessor()
        {
            userType = "Professor";
            Assert.IsTrue(DB.signPerson(name, password, id, userType));
        }

        //Instructor signin_10
        [TestMethod]
        public void signInInstructor()
        {
            userType = "Instructor";
            Assert.IsTrue(DB.signPerson(name, password, id, userType));
        }

        //Admin signin_11
        [TestMethod]
        public void signInAdmin()
        {
            userType = "Admin";
            Assert.IsTrue(DB.signPerson(name, password, id, userType));
        }

        //Secretary signin_12
        [TestMethod]
        public void signInSecretary()
        {
            userType = "Secretary";
            Assert.IsTrue(DB.signPerson(name, password, id, userType));
        }
    }


    //Conection to SQL - Data Base
    [TestClass]
    public class ConectionBranchA
    {
        ulong id = 123456789;
        string name = "test", lastName = "test", pass = "test", accessGroup, user_name = "test";
        dataBaseOperations DB = new dataBaseOperations();
        String userType;

        //Professor connect_13
        [TestMethod]
        public void connectWithProfessor()
        {
            accessGroup = "Professor";
            userType = "Professor";
            DB.setNewUser(id, name, lastName, pass, accessGroup, user_name);
            Assert.IsTrue(DB.userExist(pass, id, userType));
            DB.deleteUser(id);
        }

        //Instructor connect_14
        [TestMethod]
        public void connectWithInstructor()
        {
            accessGroup = "Instructor";
            userType = "Instructor";
            DB.setNewUser(id, name, lastName, pass, accessGroup, user_name);
            Assert.IsTrue(DB.userExist(pass, id, userType));
            DB.deleteUser(id);
        }

        //Administrator connect_15
        [TestMethod]
        public void connectWithAdmin()
        {
            accessGroup = "Admin";
            userType = "Admin";
            DB.setNewUser(id, name, lastName, pass, accessGroup, user_name);
            Assert.IsTrue(DB.userExist(pass, id, userType));
            DB.deleteUser(id);
        }

        //Secretary connect_16
        [TestMethod]
        public void connectWithSecretary()
        {
            accessGroup = "Secretary";
            userType = "Secretary";
            DB.setNewUser(id, name, lastName, pass, accessGroup, user_name);
            Assert.IsTrue(DB.userExist(pass, id, userType));
            DB.deleteUser(id);
        }
    }
}