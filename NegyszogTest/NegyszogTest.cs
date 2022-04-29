using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Negyszog;

namespace NegyszogTest
{
    [TestClass]
    public class NegyszogTest
    {
        // Arrange
        static double s = 2.0;
        Szognegy objSzogNegy = new Szognegy(s);

        [TestMethod]
        public void TestKerulet()
        {
            // Arrange
            double vartEredm = 8.0;

            // Act
            double kapottEredm = objSzogNegy.Kerulet();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod]
        public void TestTerulet()
        {
            // Arrange
            double vartEredm = 4.0;

            // Act
            double kapottEredm = objSzogNegy.Terulet();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod]
        public void TestAtlo()
        {
            // Arrange
            double vartEredm = Math.Sqrt(8);

            // Act
            double kapottEredm = objSzogNegy.Atlo();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void TestOszlop()
        {
            double m = -10;
            objSzogNegy.setOszlop(m);
        }
    }
}
