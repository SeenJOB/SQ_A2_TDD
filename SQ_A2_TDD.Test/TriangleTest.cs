﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQ_A2_TDD;
using System.Text.RegularExpressions;

namespace SQ_A2_TDD.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestClassExist()
        {
            var Tri = new Triangle();
        }

        [TestMethod]
        public void TestSideValid()
        {
            Triangle Tri = new Triangle();
            bool test = Tri.validateLenth(-5);      
            Assert.IsTrue(test);
        }
    }
}