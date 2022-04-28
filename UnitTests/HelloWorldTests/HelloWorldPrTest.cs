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
            // Arrange: Be�ll�t�sok �s a v�rt eredm�ny megad�sa
            string vartEredm = "Hello World!";

            // Act: Tesztelt met�dus megh�v�sa
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.HelloWorldPr.Main();
                var kapottEredm = sw.ToString().Trim();

                // Assert: Ki�rt�kel�s
                Assert.AreEqual(vartEredm, kapottEredm);
            }

        }
    }
}
