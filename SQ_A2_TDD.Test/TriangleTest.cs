﻿/*
*  FILE          : TriangleTest.cs
*  PROJECT       : SQ Assignment 2 TDD
*  PROGRAMMER    : Sean O'Brien
*  FIRST VERSION : 2018-11-22
*  DESCRIPTION   : This file contains all of the test used to ensure the quality 
*                  uints in the SQ_A2_TDD project.
*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void TestArea()
        {
            Triangle Tri = new Triangle();
            double sum = Tri.getArea(7, 5);
            Assert.AreEqual(sum, 17.5);

            sum = Tri.getArea(9, 2);
            Assert.AreEqual(sum, 9);
        }
        [TestMethod]
        public void TestAngle()
        {
            Triangle Tri = new Triangle();
            double sum = Tri.getAngle(100, 40);
            Assert.AreEqual(sum, 40);

            sum = Tri.getAngle(55, 55);
            Assert.AreEqual(sum, 70);
        }

    }
}

