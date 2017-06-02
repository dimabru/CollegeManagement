using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Team3;
using Project_Team3.Classes;

namespace UnitTestsProject
{
    [TestClass]
    public class DBconnectTests
    {
        DBconnect connect = new DBconnect();

        [TestMethod]
        public void OpenConnction()
        {
            Assert.IsTrue(connect.OpenConn());
        }

        [TestMethod]
        public void ConnectionStatus()
        {
            Assert.IsFalse(connect.ConnStatus());
        }

        [TestMethod]
        public void CloseConnection()
        {
            Assert.IsTrue(connect.CloseConn(true));
        }
    }
}
