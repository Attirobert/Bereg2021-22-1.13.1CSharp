using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TeglaTDD;

namespace TeglaTDD_UT
{
    [TestClass]
    public class UnitTest1
    {
        // Arrange
        int vart, kapott;
        Tegla tegla = new Tegla();

        [TestMethod]
        public void Felszin_TestMethod()
        {
            // Arrange
            tegla.setTegla(1, 2, 3);
            vart = 6;

            // Act
            kapott = tegla.getTerfogat();

            // Assert
            Assert.AreEqual(vart, kapott);
        }

        [TestMethod]
        public void Felszin_TestMethod2()
        {
            // Arrange
            tegla.setTegla(4, 2, 3);
            vart = 24;

            // Act
            kapott = tegla.getTerfogat();

            // Assert
            Assert.AreEqual(vart, kapott);
        }

        [TestMethod]
        public void Felszin_TestMethod_Rossz()
        {
            // Arrange
            tegla.setTegla(4, 2, 3);
            vart = 48;

            // Act
            kapott = tegla.getTerfogat();

            // Assert
            Assert.AreNotEqual(vart, kapott);
        }
    }
}
