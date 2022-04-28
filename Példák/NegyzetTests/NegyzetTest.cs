using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Negyzet;

namespace NegyzetTests
{
    [TestClass]
    public class NegyzetTest
    {
        // Teszt tagváltozói
        static double oldal = 2;
        Square objTest = new Square(oldal);

        // Átmérő
        [TestMethod]
        public void TestAtmero()
        {
            // Arrange: Beállítások és a várt eredmény megadása
            //double oldal = 2;
            //Square objTest = new Square(oldal);
            double vartEredm = Math.Sqrt(8);

            // Act: teszt futtatása
            double testEredm = objTest.Atmero();

            // Assert: Kiértékelés
            Assert.AreEqual(vartEredm, testEredm);
        }

        // Terület
        [TestMethod]
        public void TestTerulet()
        {
            // Arrange: Beállítások és a várt eredmény megadása
            //double oldal = 2;
            //Square objTest = new Square(oldal);
            double vartEredm = oldal*oldal;

            // Act: teszt futtatása
            double testEredm = objTest.Terulet();

            // Assert: Kiértékelés
            Assert.AreEqual(vartEredm, testEredm);
        }

        // Kerület
        [TestMethod]
        public void TestKerulet()
        {
            // Arrange: Beállítások és a várt eredmény megadása
            //double oldal = 2;
            //Square objTest = new Square(oldal);
            double vartEredm = 4 * oldal;

            // Act: teszt futtatása
            double testEredm = objTest.Kerulet();

            // Assert: Kiértékelés
            Assert.AreEqual(vartEredm, testEredm);
        }

        // Térfogat
        [TestMethod]
        public void TestTerfogat()
        {
            // Arrange: Beállítások és a várt eredmény megadása
            //double oldal = 2;
            //Square objTest = new Square(oldal);
            double magassag = 3;
            double vartEredm = oldal*oldal*magassag;

            // Act: teszt futtatása
            double testEredm = objTest.Oszlop(magassag);

            // Assert: Kiértékelés
            Assert.AreEqual(vartEredm, testEredm);
        }

        /* A következő tesztesetben azt ellenőrizzük, hogy rossz adat megadásakor kiváltódik-e a hiba. */
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void OszlopTest()
        {
            // Arrange: Beállítások és a várt eredmény megadása
            double magassag = 0;
            double vartEredm = 4;

            // Act: teszt futtatása
            double testEredm = objTest.Oszlop(magassag);

            // Assert: Kiértékelés
            Assert.AreEqual(vartEredm, testEredm);
        }
    }
}
