using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace SDLCOpdrachtWeek7
{
    public class Valutaconverter
    {
        public enum Koers { Euro = 100, USDollar = 117, Yen = 12823 }
        public Koers? ValutaLinks { get; set; } = Koers.Euro;
        public decimal BedragLinks { get; set; } = 1;
        public Koers? ValutaRechts { get; set; } = Koers.Euro;
        public decimal BedragRechts { get; set; } = 1;
        public decimal WijzigBedragLinks(decimal bedragLinks)
        {
            BedragLinks = bedragLinks;
            BedragRechts = BedragLinks / Convert.ToDecimal(ValutaLinks) * Convert.ToDecimal(ValutaRechts);
            return Math.Round(BedragRechts, 2);
        }
        public void WijzigValutaLinks(int index)
        {
            if (index == 0)
            {
                ValutaLinks = Koers.Euro;
            }
            else if (index == 1)
            {
                ValutaLinks = Koers.USDollar;
            }
            else if (index == 2)
            {
                ValutaLinks = Koers.Yen;
            }
            else
            {
                ValutaLinks = Koers.Euro;
            }
            BedragLinks = BedragRechts / Convert.ToDecimal(ValutaRechts) * Convert.ToDecimal(ValutaLinks);
        }
        public decimal WijzigBedragRechts(decimal bedragRechts)
        {
            BedragRechts = bedragRechts;
            BedragLinks = BedragRechts / Convert.ToDecimal(ValutaRechts) * Convert.ToDecimal(ValutaLinks);
            return Math.Round(BedragLinks, 2);
        }
        public void WijzigValutaRechts(int index)
        {
            if (index == 0)
            {
                ValutaRechts = Koers.Euro;
            }
            else if (index == 1)
            {
                ValutaRechts = Koers.USDollar;
            }
            else if (index == 2)
            {
                ValutaRechts = Koers.Yen;
            }
            else
            {
                ValutaRechts = Koers.Euro;
            }
            BedragRechts = BedragLinks / Convert.ToDecimal(ValutaLinks) * Convert.ToDecimal(ValutaRechts);
        }
    }
}
