using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieBooking.Controllers;
using MovieBooking.Models;


namespace MyMovieUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomersController cc = new CustomersController();
            Customer c = cc.Details(1);
            Assert.AreEqual("Tom", c.FirstName);
        }
    }
}

