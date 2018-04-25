using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge;

namespace CodingChallenge.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string test1 = "scrap";
            string test2 = "1991";
            string test3 = "5never ODd,...., orEv en.5";
            CodingChallenge.CCLib tester = new CodingChallenge.CCLib();
            //Act
            tester.Check(test1);
            tester.Check(test2);
            tester.Check(test3);
            //Assert
            Assert.AreEqual(test1, "scrap");
            Assert.AreEqual(test2, "1991");
            Assert.AreEqual(test3, "5never ODd,...., orEv en.5");
        }
    }
}
