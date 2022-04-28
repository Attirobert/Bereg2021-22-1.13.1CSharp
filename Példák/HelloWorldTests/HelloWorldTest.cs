using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace HelloWorldTests
{
    [TestClass]
    public class HelloWorldTest
    {
        // Arrange: Beállítások és a várt eredmény megadása
        private const string Expected = "Hello World!";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act: Tesztelt metódus meghívása
                HelloWorldCore.Program.Main();

                var result = sw.ToString().Trim();

                // Assert: Kiértékelés
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
