using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Team3;
using Project_Team3.Menus___forms.SecretarySubMenus;
using System.Windows.Forms;


namespace UnitTestsProject
{
    /// <summary>
    /// Summary description for SecretarySearchStudents
    /// </summary>
    [TestClass]
    public class SecretarySearchStudents
    {
        Form_secretaryStudentSearch studentSearchForm;
        PrivateObject studentSearchObject;
        ListBox resultsBox;
        public SecretarySearchStudents()
        {
            studentSearchForm = new Form_secretaryStudentSearch();
            studentSearchObject = new PrivateObject(studentSearchForm);
            resultsBox = studentSearchForm.getStudentsResults();
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
        public void checkInvalidID()
        {

            Object[] paramsArray = new Object[1];
            paramsArray[0] = "Test";

            //ID can be represented only by numbers:
            string onlyNumbersMessage = (string)studentSearchObject.Invoke("searchByID", paramsArray);
            Assert.AreEqual("ID Can be represented only by numbers", onlyNumbersMessage);

            //ID can not be empty:
            paramsArray[0] = "";
            string notEmptyMessage = (string)studentSearchObject.Invoke("searchByID", paramsArray);
            Assert.AreEqual("ID Cannot be empty", notEmptyMessage);

        }

        [TestMethod]
        public void checkInvalidName()
        {
            Object[] paramsArray = new Object[1];
            paramsArray[0] = "";
            //Student Name cannot be empty:
            bool retVal = (bool)studentSearchObject.Invoke("searchByName", paramsArray);
            Assert.IsFalse(retVal);
        }

        [TestMethod]
        public void checkStudentUpdated()
        {
            Object[] searchParam = new Object[1];
            searchParam[0] = "alex";

            studentSearchObject.Invoke("searchByName", searchParam);
            Assert.AreEqual(1, resultsBox.Items.Count);

        }

    }
}
