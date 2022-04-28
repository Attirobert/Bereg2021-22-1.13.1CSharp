using Microsoft.VisualStudio.TestTools.UnitTesting;
using NegyzetTDD;
using System;
using System.Collections.Generic;
using System.Text;

namespace NegyzetTDD.Tests
{
    [TestClass()]
    public class NegyzetTests
    {
        static double oldal = 2;
        Negyzet objTest = new Negyzet(oldal);

        [TestMethod()]
        public void AtmeroTest()
        {
            // Arrange - Beállítás
            double vartEredm = Math.Sqrt(8);

            // Act - Metódus futtatása
            double kapottEredm = objTest.Atmero();

            // Assert - kiértékelés
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod()]
        public void KeruletTest()
        {
            double vartEredm = 8;

            double kapottEredm = objTest.Kerulet();

            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod()]
        public void TeruletTest()
        {
            double vartEredm = 4;

            double kapottEredm = objTest.Terulet();

            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod()]
        public void OszlopTest()
        {
            double vartEredm = 12;

            double kapottEredm = objTest.Oszlop(3);

            Assert.AreEqual(vartEredm, kapottEredm);
        }
        [TestMethod(), ExpectedException(typeof(ArgumentException))]
        public void OszlopKivetelTest()
        {
            double vartEredm = 12;

            double kapottEredm = objTest.Oszlop(0);

            Assert.AreEqual(vartEredm, kapottEredm);
        }
    }
}