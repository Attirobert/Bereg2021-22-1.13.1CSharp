using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Henger;
using System.IO;

namespace HengerTest
{
    

    [TestClass]
    public class HengerTest_Uni
    {
        Hengerclass henger = new Hengerclass();
        double vartEredm, kapottEredm;
        
        [TestMethod]
        public void TestsetSugar()
        {

            // Arrange
            vartEredm = 2.0;
            Console.SetIn(new StringReader("2,0"));

            // Act
            henger.setSugar();

            // Assert
            kapottEredm = henger.getSugar();
            StringAssert.Equals(vartEredm, kapottEredm);
        }
    }
}
