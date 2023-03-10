using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDLCDemoTestenWeek5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLCDemoTestenWeek5.Tests
{
    [TestClass()]
    public class RekenaarTests
    {
        [TestMethod()]
        public void TestMethod()
        {
            Assert.Fail("niet goed");
        }
        [TestMethod()]
        public void TestMethodSom()
        {
            Rekenaar r = new Rekenaar();
            r.A = 1;
            r.B = 2;
            r.Operator = Operator.Plus;
            int u = r.Uitslag();
            Assert.AreEqual(3, u, "Optelling mislukt");
        }
        [TestMethod()]
        public void TestMethodVerschil()
        {
            Rekenaar r = new Rekenaar();
            r.A = 1;
            r.B = 2;
            r.Operator = Operator.Min;
            int u = r.Uitslag();
            Assert.AreEqual(-1, u, "Aftrekking mislukt");
        }
        [TestMethod()]
        public void TestMethodMaal()
        {
            Rekenaar r = new Rekenaar();
            r.A = 5;
            r.B = 2;
            r.Operator = Operator.Maal;
            int u = r.Uitslag();
            Assert.AreEqual(10, u, "Vermenigvuldiging mislukt");
        }

    }
}