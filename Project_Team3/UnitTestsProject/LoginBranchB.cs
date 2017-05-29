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

        // test student login
        [TestMethod]
        public void StudentLoginCheck()
        {
            loginForm.setDBConnection(new DBconnect());
            // input exists data for student
            username.Text = "alex";
            password.Text = "alex";

            // check correct fields filling
            Assert.AreEqual("alex", username.Text);
            Assert.AreEqual("alex", password.Text);

            // check correct status
            var result= loginObject.Invoke("getAccessGroup");
            Assert.AreEqual("Student", result);

            /////////////////////////////////////
            // input incorrect data for all users
            username.Text = "testuser";
            password.Text = "testpassword";

            // check correct status
            result = loginObject.Invoke("getAccessGroup");
            Assert.AreEqual("Bad Username/Password!", result);

        }

        // test associate login
        [TestMethod]
        public void AssociateLoginCheck()
        {
            loginForm.setDBConnection(new DBconnect());
            // input exists data for student
            username.Text = "johnny";
            password.Text = "johnny";

            // check correct fields filling
            Assert.AreEqual("johnny", username.Text);
            Assert.AreEqual("johnny", password.Text);

            // check correct status
            var result = loginObject.Invoke("getAccessGroup");
            Assert.AreEqual("Associate", result);


        }

        // test secretary login
        [TestMethod]
        public void SecretaryLoginCheck()
        {
            loginForm.setDBConnection(new DBconnect());
            // input exists data for student
            username.Text = "isabele";
            password.Text = "isabeme";

            // check correct fields filling
            Assert.AreEqual("isabele", username.Text);
            Assert.AreEqual("isabeme", password.Text);

            // check correct status
            var result = loginObject.Invoke("getAccessGroup");
            Assert.AreEqual("Secretary", result);


        }

        // test admin login
        [TestMethod]
        public void AdminLoginCheck()
        {
            loginForm.setDBConnection(new DBconnect());
            // input exists data for student
            username.Text = "Liran";
            password.Text = "Liran";

            // check correct fields filling
            Assert.AreEqual("Liran", username.Text);
            Assert.AreEqual("Liran", password.Text);

            // check correct status
            var result = loginObject.Invoke("getAccessGroup");
            Assert.AreEqual("Admin", result);

        }
    }
}
