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
            bool test = Tri.validateLenth(10);      
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void TestAngleValid()
        {
            Triangle Tri = new Triangle();
            bool test = Tri.validateAngles(15, 150, 15);
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void TestHypotenuse()
        {
            Triangle Tri = new Triangle();
            double sum = Tri.getHypotenuse(4, 6);
            Assert.AreEqual(sum, 7.211);

            sum = Tri.getHypotenuse(3, 4);
            Assert.AreEqual(sum, 5);
        }

    }
}

