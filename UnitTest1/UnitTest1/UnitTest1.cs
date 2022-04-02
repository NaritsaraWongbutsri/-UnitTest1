using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;//Add Library
using System;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMathod_Add()
        {
            //Arrange
            MyMath myMath = new MyMath();
            //Act
            int result = myMath.Add(1, 2);
            //Assert
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void TestMethod_Add2()
        {
            //Arrange
            MyMath myMath = new MyMath();
            //Act
            int result = myMath.Add(11, 22);
            //Assert
            Assert.AreEqual(result, 33);
        }
    }
}
