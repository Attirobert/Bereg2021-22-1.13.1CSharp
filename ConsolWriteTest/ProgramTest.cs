using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ConsolWriteTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestConsoleWrite()
        {
            // Arrange
            string vartEredm = "Helló";

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); // Konzol átirányítása sw-be
                ConsolWrite.Program.Main();
                var kapottEredm = sw.ToString().Trim();

                // Assert
                Assert.AreEqual(kapottEredm, vartEredm);
            }

        }
    }
}
