using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Team3.Menus___forms.SecretarySubMenus;
using Project_Team3;
using System.Data;

namespace UnitTestsProject
{
    /// <summary>
    /// Summary description for Secretary_student_request
    /// </summary>
    [TestClass]
    public class Secretary_student_request
    {
        Object[] clickParamaters;
        public Secretary_student_request()
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

        [TestMethod]
        public void SecretaryAcceptsRequest()
        {
            Form_secretaryStudentRequests secretaryForm = new Form_secretaryStudentRequests();
            PrivateObject secretaryPrivateObject = new PrivateObject(secretaryForm);
            DBconnect db = new DBconnect();
            db.OpenConn();
            //create new request
            db.executionQuery("insert into studentrequests values('alex', 'unittest','R_Allowed','isabele')");
            DataSet ds = new DataSet();
            ds = db.LoadTableByFreeQuerry("select * from studentrequests where MESSAGEBODY='unittest'");
            Assert.IsNotNull(ds);

            string requestID = ds.Tables[0].Rows[0][0].ToString();

            string requestFromStrudent = ds.Tables[0].Rows[0][1].ToString();
            string expectedRequestFromStrudent = "alex";
            Assert.AreEqual(requestFromStrudent, expectedRequestFromStrudent);

            string messagebody = ds.Tables[0].Rows[0][2].ToString();
            string expectedMessageBody = "unittest";
            Assert.AreEqual(messagebody, expectedMessageBody);

            string requestStatus = ds.Tables[0].Rows[0][3].ToString();
            string expectedRequestStatus = "R_Allowed";
            Assert.AreEqual(requestStatus, expectedRequestStatus);

            String[] args = new String[2];
            string expectedNewStatus = "R_Allowed";
            args[0] = "R_Allowed";
            args[1] = requestID;

            secretaryPrivateObject.Invoke("updateRequest", args);

            ds = db.LoadTableByFreeQuerry("select * from studentRequests where MESSAGEBODY='unittest' and ID="+ requestID);
            Assert.IsNotNull(ds);

            string newStatus = ds.Tables[0].Rows[0][3].ToString();

            try { Assert.AreEqual(expectedNewStatus, newStatus); }
            finally{
                db.executionQuery("delete from StudentRequests where MESSAGEBODY='unittest'");              //remove created request
                db.CloseConn(db.ConnStatus());
            }



            

        }


        [TestMethod]
        public void SecretaryDeniesRequest()
        {
            Form_secretaryStudentRequests secretaryForm = new Form_secretaryStudentRequests();
            PrivateObject secretaryPrivateObject = new PrivateObject(secretaryForm);
            DBconnect db = new DBconnect();
            db.OpenConn();
            //create new request
            db.executionQuery("insert into studentrequests values('alex', 'unittest','R_Denied','isabele')");
            DataSet ds = new DataSet();
            ds = db.LoadTableByFreeQuerry("select * from studentrequests where MESSAGEBODY='unittest'");
            Assert.IsNotNull(ds);

            string requestID = ds.Tables[0].Rows[0][0].ToString();

            string requestFromStrudent = ds.Tables[0].Rows[0][1].ToString();
            string expectedRequestFromStrudent = "alex";
            Assert.AreEqual(requestFromStrudent, expectedRequestFromStrudent);

            string messagebody = ds.Tables[0].Rows[0][2].ToString();
            string expectedMessageBody = "unittest";
            Assert.AreEqual(messagebody, expectedMessageBody);

            string requestStatus = ds.Tables[0].Rows[0][3].ToString();
            string expectedRequestStatus = "R_Denied";
            Assert.AreEqual(requestStatus, expectedRequestStatus);

            String[] args = new String[2];
            string expectedNewStatus = "R_Denied";
            args[0] = "R_Denied";
            args[1] = requestID;

            secretaryPrivateObject.Invoke("updateRequest", args);

            ds = db.LoadTableByFreeQuerry("select * from studentRequests where MESSAGEBODY='unittest' and ID=" + requestID);
            Assert.IsNotNull(ds);

            string newStatus = ds.Tables[0].Rows[0][3].ToString();

            try { Assert.AreEqual(expectedNewStatus, newStatus); }
            finally
            {
                db.executionQuery("delete from StudentRequests where MESSAGEBODY='unittest'");              //remove created request
                db.CloseConn(db.ConnStatus());
            }





        }
    }
}
