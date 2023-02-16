using Microsoft.VisualStudio.TestTools.UnitTesting;
using MastermindCore6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindCore6.Model.Tests
{
    [TestClass()]
    public class MMTests
    {
        MM mm = new MM();
        [TestMethod()]
        public void NieuwSpelTest()
        {
            mm.NieuwSpel();
            if (mm.TeRaden.Length != 4)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void NieuweBeurtTest()
        {
            int oudeBeurt = mm.Beurt;
            mm.NieuweBeurt();
            int nieuweBeurt = mm.Beurt;
            Assert.AreEqual(oudeBeurt, nieuweBeurt, 1, "De beurt is niet omhoog gegaan");
        }

        [TestMethod()]
        public void NieuwePogingTest()
        {
            mm.NieuwePoging("");
            Assert.AreEqual(4, mm.Poging.Length, "De lengte van de string is te lang");
        }

        [TestMethod()]
        public void PositiesOKTest()
        {
            mm.TeRaden = "1234";
            mm.Poging = "1098";
            Assert.AreEqual(1, mm.PositiesOK(), "Er ging iets fout bij PositiesOK");
        }

        [TestMethod()]
        public void AantalOKTest()
        {
            mm.TeRaden = "1234";
            mm.Poging = "4327";
            Assert.AreEqual(3, mm.AantalOK(), "Er ging iets fout bij AantalOK");
        }
    }
}