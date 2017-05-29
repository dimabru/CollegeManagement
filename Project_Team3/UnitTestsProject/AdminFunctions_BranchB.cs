using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Project_Team3.Menus___forms.AdminSubMenus;

namespace UnitTestsProject
{
    /// <summary>
    /// Summary description for AdminFunctions_BranchB
    /// </summary>
    [TestClass]
    public class AdminFunctions_BranchB
    {

        Form_adminAccountsMenu adminForm;
        PrivateObject adminObject;
        Object[] clickParamaters;
        TextBox topTextBox;

        public AdminFunctions_BranchB()
        {
            adminForm = new Form_adminAccountsMenu();
            adminObject = new PrivateObject(adminForm);
            clickParamaters = new Object[2];
            clickParamaters[0] = this;
            clickParamaters[1] = new EventArgs();
            topTextBox = adminForm.getTextBox();

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
        public void AmountOfStudents()
        {
            adminObject.Invoke("getStudentsNumber_Click", clickParamaters);
            string boxMessage = topTextBox.Text;
            string expectedText = "There are total of 5 Students in system";
            Assert.AreEqual(expectedText, boxMessage);
        }


        [TestMethod]
        public void AmountOfCourses()
        {
            Form_adminCoursesMenu CoursesForm = new Form_adminCoursesMenu();
            PrivateObject courseFormObj = new PrivateObject(CoursesForm);
            topTextBox = CoursesForm.getCoursesBox();
            courseFormObj.Invoke("recieveAmountClick", clickParamaters);
            string boxMessage = topTextBox.Text;
            string expectedText = "There are total of 9 courses in system";
            Assert.AreEqual(expectedText, boxMessage);
        }
    }
}
