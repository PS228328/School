using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppOpdracht2Verhuurbedrijf.Assets
{
    internal class myClass
    {
        public class VerhuurBedrijf
        {
            private List<VerhuurStation> verhuurStations;
            public void NieuwVerhuurStation(VerhuurStation verhuurstation) { }
        }

        public class VerhuurStation
        {
            public string Locatie { get; }
            private List<HuurAuto> huurautos;
            public VerhuurStation(string locatie) { }
            public void NieuweHuurauto(string kenteken) { }
        }

        public class HuurAuto
        {
            public string kenteken { get; }
            private VerhuurStation verhuurStation;
            public HuurAuto(string kenteken, VerhuurStation verhuurStation) { }
            public bool VerhuurAuto() { }
        }
    }
}
