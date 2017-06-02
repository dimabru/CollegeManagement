using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Team3;
using Project_Team3.Courses;

namespace UnitTestsProject
{
    [TestClass]
    public class RoomsTests
    {
        int max_student = 100;
        string Rnumber = "test";

        [TestMethod]
        public void addRoom()
        {
            Room room = new Room(Rnumber, max_student);
            Assert.IsTrue(dataBaseOperations.addRoom(room));
        }


        [TestMethod]
        public void roomExist()
        {
            Assert.IsTrue(dataBaseOperations.roomExist(Rnumber));
        }

        [TestMethod]
        public void removeRoom()
        {
            Assert.IsTrue(dataBaseOperations.removeRoom(Rnumber));
        }
    }
}
