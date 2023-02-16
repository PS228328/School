using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDLCOpdrachtWeek7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLCOpdrachtWeek7.Tests
{
    [TestClass()]
    public class ValutaconverterTests
    {
        [TestMethod()]

        public void WijzigBedragLinksTest()
        {
            Valutaconverter converter = new Valutaconverter();
            converter.ValutaLinks = Valutaconverter.Koers.Euro;
            converter.ValutaRechts = Valutaconverter.Koers.USDollar;

            decimal bedragRechts = converter.WijzigBedragLinks(1);
            Assert.AreEqual((decimal)1.17, bedragRechts, "Test gefaald, het bedrag rechts is niet goed");
        }
        [TestMethod()]

        public void WijzigBedragRechtsTest()
        {
            Valutaconverter converter = new Valutaconverter();
            converter.ValutaLinks = Valutaconverter.Koers.Yen;
            converter.ValutaRechts = Valutaconverter.Koers.USDollar;

            decimal bedragLinks = converter.WijzigBedragRechts((decimal)6.52);
            Assert.AreEqual((decimal)714.58, bedragLinks, "Test gefaald, het bedrag links is niet goed");
        }
        [TestMethod()]
        public void WijzigValutaLinksTest()
        {
            Valutaconverter converter = new Valutaconverter();
            converter.ValutaLinks = Valutaconverter.Koers.Yen;
            converter.ValutaRechts = Valutaconverter.Koers.Yen;
            converter.WijzigValutaLinks(1);
            decimal bedragLinks = converter.WijzigBedragLinks((decimal)7.20);
            Assert.AreEqual((decimal)789.11, bedragLinks, "Test gefaald, het bedrag links is niet goed");
        }
        [TestMethod()]
        public void WijzigValutaRechtsTest()
        {
            Valutaconverter converter = new Valutaconverter();
            converter.ValutaLinks = Valutaconverter.Koers.Euro;
            converter.ValutaRechts = Valutaconverter.Koers.Euro;
            converter.WijzigValutaRechts(2);
            decimal bedragRechts = converter.WijzigBedragLinks((decimal)7.20);
            Assert.AreEqual((decimal)923.26, bedragRechts, "Test gefaald, het bedrag rechts is niet goed");
        }
    }
}