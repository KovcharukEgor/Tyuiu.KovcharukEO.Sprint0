﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KovcharukEO.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KovcharukEO.Sprint0.Task2.V0.Test
{ 
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Егор";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Егор", res);
        }
    }
}
