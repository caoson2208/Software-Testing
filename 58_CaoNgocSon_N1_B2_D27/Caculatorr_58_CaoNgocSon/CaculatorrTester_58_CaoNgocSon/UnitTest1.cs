using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculatorr_58_CaoNgocSon;

namespace CaculatorrTester_58_CaoNgocSon
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation_58_CaoNgocSon c;
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp()
        {
            c = new Caculation_58_CaoNgocSon(5, 2);
        }
        [TestMethod] //TC1: a = 5, b = 2, kq = 7
        public void Test_Cong_58_CaoNgocSon()
        {
            int expected, actual;
            expected = 7;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Tru_58_CaoNgocSon()
        {
            int expected, actual;
            expected = 3;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Nhan_58_CaoNgocSon()
        {
            int expected, actual;
            expected = 10;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Chia_58_CaoNgocSon()
        {
            int expected, actual;
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero_58_CaoNgocSon()
        {
            c = new Caculation_58_CaoNgocSon(5, 0);
            c.Execute("/");
        }

        public TestContext TestContext { get; set; }
            
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\Data\TestData_CaoNgocSon.csv", "TestData_58_CaoNgocSon#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource_58_CaoNgocSon()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            Caculation_58_CaoNgocSon c = new Caculation_58_CaoNgocSon(a, b);
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
       @".\Data\DataTest_cotToanTu_58_CaoNgocSon.csv", "DataTest_cotToanTu_58_CaoNgocSon#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestCong_DataSource_58_CaoNgocSon()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string operation = TestContext.DataRow[2].ToString();
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            Caculation_58_CaoNgocSon c = new Caculation_58_CaoNgocSon(a, b);
            int actual = c.Execute(operation);
            Assert.AreEqual(expected, actual);
            Console.WriteLine(operation);
        }
    }
}
