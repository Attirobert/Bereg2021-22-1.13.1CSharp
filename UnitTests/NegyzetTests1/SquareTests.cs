﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negyzet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negyzet.Tests
{
    [TestClass()]
    public class SquareTests
    {
        // Tagváltozók
        static double oldal = 2;
        Square objTest = new Square(oldal);

        [TestMethod()]
        public void AtmeroTest()
        {
            // Arrange
            double vartEredm = Math.Sqrt(8);

            // Act
            double kapottEredm = objTest.Atmero();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod()]
        public void KeruletTest()
        {
            // Arrange
            double vartEredm = 8;

            // Act
            double kapottEredm = objTest.Kerulet();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod()]
        public void TeruletTest()
        {
            // Arrange
            double vartEredm = 4;

            // Act
            double kapottEredm = objTest.Terulet();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod()]
        public void OszlopTest()
        {
            // Arrange
            double magas = 3;
            double vartEredm = 12;

            // Act
            double kapottEredm = objTest.Oszlop(magas);

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod(), ExpectedException(typeof(ArgumentException))]
        public void OszlopHibaTest()
        {
            // Arrange
            double magas = 0;
            double vartEredm = 12;

            // Act
            double kapottEredm = objTest.Oszlop(magas);

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }
    }
}