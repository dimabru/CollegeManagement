using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Team3.Classes;
using System.Windows.Forms;

namespace UnitTestsProject
{
    /// <summary>
    /// Summary description for Non_Interactive_System_Tests
    /// </summary>
    [TestClass]
    public class Non_Interactive_System_Tests
    {

        public Non_Interactive_System_Tests()
        {
            //
            // TODO: Add constructor logic here
            //
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
        public void CheckUserIDExists()
        {
            FunctionsForAllProgram funcs = new FunctionsForAllProgram();

            // existing user
            bool IDExists = funcs.ifUserIDinDatabase(3233);
            Assert.IsTrue(IDExists);

            // not existing user
            IDExists = funcs.ifUserIDinDatabase(99999);
            Assert.IsFalse(IDExists);
        }


        [TestMethod]
        public void CheckUsernameExists()
        {
            FunctionsForAllProgram funcs = new FunctionsForAllProgram();

            // existing user
            bool IDExists = funcs.ifUserInDatabase("roni");
            Assert.IsTrue(IDExists);

            // not existing user
            IDExists = funcs.ifUserInDatabase("Dudu Aharon");
            Assert.IsFalse(IDExists);
        }


        [TestMethod]
        public void CheckifIDinTable()
        {
            FunctionsForAllProgram funcs = new FunctionsForAllProgram();

            // existing user
            bool IDExists = funcs.ifIDinTable(3233,"Users");
            Assert.IsTrue(IDExists);

            // not existing user
            IDExists = funcs.ifIDinTable(99999,"Users");
            Assert.IsFalse(IDExists);
        }

        [TestMethod]
        public void CheckifIDinEvents()
        {
            FunctionsForAllProgram funcs = new FunctionsForAllProgram();

            // existing user
            bool IDExists = funcs.ifIDinEvents(1);
            Assert.IsTrue(IDExists);

            // not existing user
            IDExists = funcs.ifIDinEvents(99999);
            Assert.IsFalse(IDExists);
        }

    }
}
