using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APITests
{
    [TestClass]
    public class APITests
    {
        [TestMethod]
        public void VerifyListOfUsers()
        {
            var a = new MethodImplementationSteps();
            var b = a.GetUsers();
            Assert.AreEqual(b.page, 2);
            
        }

        [TestMethod]
        public void VerifyCreateUsers()
        {
            var a = new MethodImplementationSteps();
            var b = a.CreateUsers();
            

        }
    }
}
