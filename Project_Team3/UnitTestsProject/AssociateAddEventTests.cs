﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Team3;
using Project_Team3.Menus___forms;
using Project_Team3.Menus___forms.AssociateSubMenus;
using System.Windows.Forms;

namespace UnitTestsProject
{
    /// <summary>
    /// Summary description for AssociateTests
    /// </summary>
    [TestClass]
    public class AssociateAddEventTests
    {
        Form_associateDefineNewEvent defineNewEventForm;
        PrivateObject defineNewEventObject;
        Object[] clickParamaters;
        TextBox eventName;
        RichTextBox eventDescription;
        DateTimePicker eventStartTime;
        DateTimePicker eventEndTime;

        public AssociateAddEventTests()
        {
            //
            // TODO: Add constructor logic here
            //
            defineNewEventForm = new Form_associateDefineNewEvent();
            defineNewEventObject = new PrivateObject(defineNewEventForm);
            clickParamaters =  new Object[2];
            clickParamaters[0] = this;
            clickParamaters[1] = new EventArgs();
            eventName = defineNewEventForm.getEventName();
            eventDescription = defineNewEventForm.getEventDescription();
            eventStartTime = defineNewEventForm.getStartTime();
            eventEndTime = defineNewEventForm.getEndTime();
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
        public void checkFieldsClearButtons()
        {
            //Setting fields values to be non empty:
            eventName.Text = "testName";
            eventDescription.Text = "testDescription";

            //Checking fields attained that value:

            Assert.AreEqual(eventName.Text, "testName");
            Assert.AreEqual(eventDescription.Text, "testDescription");

            //Checking fields are empty after clicking the clear button:
            defineNewEventObject.Invoke("clearNameButton_Click",clickParamaters);
            defineNewEventObject.Invoke("clearDescription_Click", clickParamaters);

            Assert.AreEqual(eventName.Text, "");
            Assert.AreEqual(eventDescription.Text, "");
        }
    }
}