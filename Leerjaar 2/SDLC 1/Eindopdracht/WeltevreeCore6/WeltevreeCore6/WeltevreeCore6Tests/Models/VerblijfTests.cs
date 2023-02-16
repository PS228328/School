using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeltevreeCore6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WeltevreeCore6.Models.Tests
{
    [TestClass()]
    public class VerblijfTests
    {
        string naamEigenaar = "Joris";
        DateTime geboortedatum = new DateTime(2009, 10, 5);
        string naamDier = "Mevrouw Jansen";
        DateTime van = new DateTime(2022, 11, 2);
        DateTime tot = new DateTime(2022, 11, 16);

        [TestMethod()]
        public void AdministratiekostenTest()
        {
            Eigenaar eigenaar = new Eigenaar(naamEigenaar);
            Dier dier = new Dier(geboortedatum, naamDier);
            Verblijf vb = new Verblijf(eigenaar, dier, van, tot);

            DateTime tot2 = new DateTime(2022, 11, 20);

            vb.Verlengen(tot2);
            vb.Annuleren();

            Assert.AreEqual(15, vb.Administratiekosten, "Administratiekosten zijn niet goed");
        }
        [TestMethod()]
        public void BehandelingskostenTest()
        {
            Eigenaar eigenaar = new Eigenaar(naamEigenaar);
            Dier dier = new Dier(geboortedatum, naamDier);
            Verblijf vb = new Verblijf(eigenaar, dier, van, tot);

            vb.Behandelen(SoortBehandeling.Parasietbehandeling);
            vb.Behandelen(SoortBehandeling.Parasietbehandeling);
            vb.Behandelen(SoortBehandeling.Inenten);
            vb.Behandelen(SoortBehandeling.Chippen);
            vb.Behandelen(SoortBehandeling.Chippen);
            vb.Behandelen(SoortBehandeling.Chippen);

            Assert.AreEqual(80, vb.Behandelingskosten, "Behandelingskosten zijn niet goed");
        }
        [TestMethod()]
        public void TotaalPrijsTest()
        {
            Eigenaar eigenaar = new Eigenaar(naamEigenaar);
            Dier dier = new Dier(geboortedatum, naamDier);
            Verblijf vb = new Verblijf(eigenaar, dier, van, tot);

            vb.Behandelen(SoortBehandeling.Inenten);
            vb.Behandelen(SoortBehandeling.Chippen);

            DateTime tot2 = new DateTime(2022, 11, 20);

            vb.Verlengen(tot2);

            double verblijfkosten = vb.TotaalPrijs(Diersoort.Kat);

            Assert.AreEqual(176, verblijfkosten + vb.Behandelingskosten + vb.Administratiekosten, "Totaalprijs word onjuist berekend");
        }

        string naamEigenaar2 = "Bas";
        DateTime geboortedatum2 = new DateTime(2011, 8, 25);
        string naamDier2 = "Bloem";
        DateTime van2 = new DateTime(2022, 12, 30);
        DateTime tot2 = new DateTime(2023, 1, 10);

        [TestMethod()]
        public void AdministratiekostenTest2()
        {
            Eigenaar eigenaar = new Eigenaar(naamEigenaar2);
            Dier dier = new Dier(geboortedatum2, naamDier2);
            Verblijf vb = new Verblijf(eigenaar, dier, van2, tot2);

            vb.Annuleren();

            Assert.AreEqual(10, vb.Administratiekosten, "Administratiekosten zijn niet goed");
        }

        [TestMethod()]
        public void BehandelingskostenTest2()
        {
            Eigenaar eigenaar = new Eigenaar(naamEigenaar2);
            Dier dier = new Dier(geboortedatum2, naamDier2);
            Verblijf vb = new Verblijf(eigenaar, dier, van2, tot2);

            vb.Behandelen(SoortBehandeling.Parasietbehandeling);
            vb.Behandelen(SoortBehandeling.Inenten);
            vb.Behandelen(SoortBehandeling.Inenten);
            vb.Behandelen(SoortBehandeling.Chippen);
            vb.Behandelen(SoortBehandeling.Chippen);

            Assert.AreEqual(85, vb.Behandelingskosten, "Behandelingskosten zijn niet goed");
        }
        [TestMethod()]
        public void TotaalPrijsTest2()
        {
            Eigenaar eigenaar = new Eigenaar(naamEigenaar2);
            Dier dier = new Dier(geboortedatum2, naamDier2);
            Verblijf vb = new Verblijf(eigenaar, dier, van2, tot2);

            vb.Behandelen(SoortBehandeling.Inenten);
            vb.Behandelen(SoortBehandeling.Chippen);

            DateTime tot3 = new DateTime(2023, 1, 15);

            vb.Verlengen(tot3);

            double verblijfkosten = vb.TotaalPrijs(Diersoort.Konijn);

            Assert.AreEqual(130, verblijfkosten + vb.Behandelingskosten + vb.Administratiekosten, "Totaalprijs word onjuist berekend");
        }
    }
}