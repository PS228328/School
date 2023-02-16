using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDLCOpdracht1Week5Unittest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLCOpdracht1Week5Unittest.Tests
{
    [TestClass()]
    public class BankrekeningTests
    {
        [TestMethod()]
        public void Storten_Geldig_Bedrag()
        {
            Bankrekening rekening = new Bankrekening(11.99);        // Arrange
            rekening.Storten(4.55);                                 // Act
                                                                    // Assert.AreEqual(expected, actual, precision, error message)
            Assert.AreEqual(16.54, rekening.Saldo, 0.001, "Storten niet gelukt");
        }


        [TestMethod()]
        public void Opnemen_Geldig_Bedrag()
        {
            Bankrekening rekening = new Bankrekening(11.99);        // Arrange
            rekening.Opnemen(4.55);                                 // Act
                                                                    // Assert.AreEqual(expected, actual, precision, error message)
            Assert.AreEqual(7.44, rekening.Saldo, 0.001, "Opnemen niet gelukt");
        }

        [TestMethod()]
        public void Storten_Negatief()
        {
            Bankrekening rekening = new Bankrekening(11.99);            // Arrange
            rekening.Storten(-4.55);                            // Act
            Assert.AreEqual(11.99, rekening.Saldo, 0.001,
                   "Negatieve waarde in storting");                 // Assert
        }

        [TestMethod()]
        public void Opnemen_Negatief()
        {
            Bankrekening rekening = new Bankrekening(11.99);            // Arrange
            rekening.Opnemen(-4.55);                                // Act
            Assert.AreEqual(11.99, rekening.Saldo, 0.001, "Negatieve waarde in opname");
        }

        [TestMethod()]
        public void Storten_Bevroren_Rekening()
        {
            Bankrekening rekening = new Bankrekening();
            rekening.Bevroren = true;
            rekening.Storten(4.55);
        }

        [TestMethod()]
        public void Opnemen_Bevroren_Rekening()
        {
            Bankrekening rekening = new Bankrekening();
            rekening.Bevroren = true;
            rekening.Opnemen(4.55);
        }
    }
}