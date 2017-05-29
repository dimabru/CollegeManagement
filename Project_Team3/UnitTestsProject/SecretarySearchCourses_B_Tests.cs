using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Team3.Menus___forms.SecretarySubMenus;
using System.Windows.Forms;
using Project_Team3;


namespace UnitTestsProject
{
    /// <summary>
    /// Summary description for SecretarySearchCourses_B_Tests
    /// </summary>
    [TestClass]
    public class SecretarySearchCourses_B_Tests
    {

        Form_secretaryCourseSearch courseSearchForm;
        PrivateObject courseSearchObject;
        ListBox resultsBox;

        public SecretarySearchCourses_B_Tests()
        {
            courseSearchForm = new Form_secretaryCourseSearch();
            courseSearchObject = new PrivateObject(courseSearchForm);
            resultsBox = courseSearchForm.getCoursesResults();
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
            string onlyNumbersMessage = (string) courseSearchObject.Invoke("searchByID", paramsArray);
            Assert.AreEqual("ID Can be represented only by numbers", onlyNumbersMessage);

            //ID can not be empty:
            paramsArray[0] = "";
            string notEmptyMessage = (string)courseSearchObject.Invoke("searchByID", paramsArray);
            Assert.AreEqual("ID Cannot be empty", notEmptyMessage);

        }

        [TestMethod]
        public void checkInvalidName()
        {
            Object[] paramsArray = new Object[1];
            paramsArray[0] = "";
            //Course Name cannot be empty:
            bool retVal = (bool)courseSearchObject.Invoke("searchByName", paramsArray);
            Assert.IsFalse(retVal);
        }

        [TestMethod]
        public void checkCoursesUpdated()
        {
            Object[] searchParam = new Object[1];
            searchParam[0] = "test";

            DBconnect dbCon = new DBconnect();

            dbCon.executionQuery("INSERT INTO Course VALUES(7357,'test',73,73,73,3,7,73,7,'test',7,0,0)");

            courseSearchObject.Invoke("searchByName", searchParam);
            Assert.AreEqual(1, resultsBox.Items.Count);
            dbCon.executionQuery("DELETE FROM Course WHERE COURSE_NAME='test'");

        }

    }
}
