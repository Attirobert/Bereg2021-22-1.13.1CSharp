using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HelloWorldTests
{
    [TestClass]
    public class HelloWorldPrTest
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange: Beállítások és a várt eredmény megadása
            string vartEredm = "Hello World!";

            // Act: Tesztelt metódus meghívása
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.HelloWorldPr.Main();
                var kapottEredm = sw.ToString().Trim();

                // Assert: Kiértékelés
                Assert.AreEqual(vartEredm, kapottEredm);
            }

        }
    }
}
