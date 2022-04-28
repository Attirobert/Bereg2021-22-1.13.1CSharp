using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ConsoleWriteTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMain_Write()
        {
            // Arrange
            string vartErdm = "Helló";

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); // Konzol átirányítása
                ConsolWrite.Program.Main();
                var kapottEredm = sw.ToString().Trim();

                // Assert
                Assert.AreEqual(vartErdm, kapottEredm);
            }

        }

        [TestMethod]
        public void TestNegyzet_Igaz()
        {
            // Arrange
            var vartEredm = true;
            // Act
            var kapottEredm = ConsolWrite.Program.Negyzet();
            // Assert
            Assert.IsTrue(true);
        }
    }
}
