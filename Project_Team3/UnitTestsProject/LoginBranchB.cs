using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Team3;
using System.Windows.Forms;

namespace UnitTestsProject
{
    /// <summary>
    /// Summary description for LoginBranchB
    /// </summary>
    [TestClass]
    public class LoginBranchB
    {
        Form_login loginForm;
        PrivateObject loginObject;
        Object[] clickParamaters;
        TextBox username;
        TextBox password;

        public LoginBranchB()
        {
            loginForm = new Form_login();
            loginObject = new PrivateObject(loginForm);
            clickParamaters = new Object[2];
            clickParamaters[0] = this;
            clickParamaters[1] = new EventArgs();
            username = loginForm.getUsername();
            password = loginForm.getPassword();



        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            // input exists data for student
            username.Text = "alex";
            password.Text = "alex";

            string result = Convert.ToString(loginObject.Invoke("getAccessGroup", clickParamaters));
            Assert.AreEqual("Student", result);

        }
    }
}
