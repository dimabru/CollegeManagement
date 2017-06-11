using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Project_Team3.Menus___forms.AdminSubMenus;
using System.Data;

namespace UnitTestsProject
{
    /// <summary>
    /// Summary description for AdminFunctions_BranchB
    /// </summary>
    [TestClass]
    public class AdminFunctions_BranchB
    {

        PrivateObject adminObject;
        Object[] clickParamaters;

        public AdminFunctions_BranchB()
        {
            clickParamaters = new Object[2];
            clickParamaters[0] = this;
            clickParamaters[1] = new EventArgs();
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

        // check amount of students
        [TestMethod]
        public void AmountOfStudents()
        {
            Form_adminAccountsMenu adminForm = new Form_adminAccountsMenu();
            adminObject = new PrivateObject(adminForm);
            adminObject.Invoke("getStudentsNumber_Click", clickParamaters);

            int expectedAtLeast = 5;
            int receivedValue = adminForm.StudentsInSystem;
            Assert.IsTrue(expectedAtLeast <= receivedValue);   // chack that at least 5 students (actually to writing test time)
            Assert.IsTrue(0 <= receivedValue);   // chack that not negative number
        }

        //check amount of cources
        [TestMethod]
        public void AmountOfCourses()
        {
            Form_adminCoursesMenu CoursesForm = new Form_adminCoursesMenu();
            PrivateObject courseFormObj = new PrivateObject(CoursesForm);
            courseFormObj.Invoke("recieveAmountClick", clickParamaters);
            int amountOfCources = CoursesForm.CoursesAmount;    // getter for private field
            int expectedAmountAtLeast = 4;
            Assert.IsTrue(expectedAmountAtLeast <= amountOfCources);   // chack that at least 9 courses (actually to writing test time)
            Assert.IsTrue(0 <= amountOfCources);   // chack that not negative number
        }

        [TestMethod]
        public void viewStudentProfile()
        {
            Form_adminAccountsMenu adminForm = new Form_adminAccountsMenu();
            adminObject = new PrivateObject(adminForm);
            adminObject.Invoke("watchStudents_Click", clickParamaters);
            DataSet dataSetMock = adminForm.Ds;

            Assert.IsNotNull(dataSetMock);  // check not null DataSet

            int id = Convert.ToInt32(dataSetMock.Tables[0].Rows[0][0]);
            string username = dataSetMock.Tables[0].Rows[0][1].ToString();
            string password = dataSetMock.Tables[0].Rows[0][2].ToString();
            string firstName = dataSetMock.Tables[0].Rows[0][3].ToString();
            string secondName = dataSetMock.Tables[0].Rows[0][4].ToString();
            int semester = Convert.ToInt32(dataSetMock.Tables[0].Rows[0][5]);

            Assert.AreEqual(2, id);
            Assert.AreEqual("alex", username);
            Assert.AreEqual("alex", password);
            Assert.AreEqual("alex", firstName);
            Assert.AreEqual(" ", secondName);
            Assert.AreEqual(1, semester);
        }

        public void viewCourseInformation()
        {
            Form_adminAccountsMenu adminForm = new Form_adminAccountsMenu();
            adminObject = new PrivateObject(adminForm);
            adminObject.Invoke("watchStudents_Click", clickParamaters);
            DataSet dataSetMock = adminForm.Ds;

            Assert.IsNotNull(dataSetMock);  // check not null DataSet

            int id = Convert.ToInt32(dataSetMock.Tables[0].Rows[0][0]);
            string username = dataSetMock.Tables[0].Rows[0][1].ToString();
            string password = dataSetMock.Tables[0].Rows[0][2].ToString();
            string firstName = dataSetMock.Tables[0].Rows[0][3].ToString();
            string secondName = dataSetMock.Tables[0].Rows[0][4].ToString();
            int semester = Convert.ToInt32(dataSetMock.Tables[0].Rows[0][5]);

            Assert.AreEqual(2, id);
            Assert.AreEqual("alex", username);
            Assert.AreEqual("alex", password);
            Assert.AreEqual("alex", firstName);
            Assert.AreEqual(" ", secondName);
            Assert.AreEqual(1, semester);
        }

    }
}
