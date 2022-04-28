using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace HelloWorldTests
{
    [TestClass]
    public class HelloWorldTest
    {
        // Arrange: Be�ll�t�sok �s a v�rt eredm�ny megad�sa
        private const string Expected = "Hello World!";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act: Tesztelt met�dus megh�v�sa
                HelloWorldCore.Program.Main();

                var result = sw.ToString().Trim();

                // Assert: Ki�rt�kel�s
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
