using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestOne;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddEntrySQLRequest1()
        {
            string table = "TestTable";
            string id = "03J";
            string name = "Buster";
            string work = "Mannequin";
            string expected = "INSERT INTO TestTable(ID, Name, Work) VALUES (03J, Buster, Mannequin)";
            string rvalue = UnitTestOne.WorkFromDB.AddEntrySQLRequest(table, id, name, work);
            Assert.AreEqual(expected, rvalue);
        }

        [TestMethod]
        public void TestAddEntrySQLRequest2()
        {
            string table = "Void";
            string id = " ";
            string name = "Striker";
            string work = " ";
            string expected = "INSERT INTO Void(ID, Name, Work) VALUES ( , Striker,  )";
            string rvalue = UnitTestOne.WorkFromDB.AddEntrySQLRequest(table, id, name, work);
            Assert.AreEqual(expected, rvalue);
        }

        [TestMethod]
        public void TestLogInToTheSystem1()
        {
            string login = "Kramer03";
            string password = "20he7ame8as19tarted";
            bool expected = true;
            bool rvalue = UnitTestOne.WorkFromDB.LogInToTheSystem(login, password);
            Assert.AreEqual(expected, rvalue);
        }

        [TestMethod]
        public void TestLogInToTheSystem2()
        {
            string login = "03Kramer";
            string password = "20he7ame8as19tarted";
            bool expected = false;
            bool rvalue = UnitTestOne.WorkFromDB.LogInToTheSystem(login, password);
            Assert.AreEqual(expected, rvalue);
        }

        [TestMethod]
        public void TestLogInToTheSystem3()
        {
            string login = " Kramer03";
            string password = "20he";
            bool expected = false;
            bool rvalue = UnitTestOne.WorkFromDB.LogInToTheSystem(login, password);
            Assert.AreEqual(expected, rvalue);
        }

        [TestMethod]
        public void TestLogInToTheSystem4()
        {
            string login = "Kramer_03";
            string password = "20he";
            bool expected = false;
            bool rvalue = UnitTestOne.WorkFromDB.LogInToTheSystem(login, password);
            Assert.AreEqual(expected, rvalue);
        }

        [TestMethod]
        public void TestLogInToTheSystem5()
        {
            string login = "Kramer03";
            string password = "20 he";
            bool expected = false;
            bool rvalue = UnitTestOne.WorkFromDB.LogInToTheSystem(login, password);
            Assert.AreEqual(expected, rvalue);
        }
    }
}