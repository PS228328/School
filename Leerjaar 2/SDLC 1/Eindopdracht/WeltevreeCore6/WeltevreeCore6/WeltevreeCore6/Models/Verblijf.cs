using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeltevreeCore6.Models
{
    public class Verblijf
    {
        public DateTime Van { get; } = default;
        public DateTime Tot { get; private set; } = default;
        public double Administratiekosten { get; private set; } = 0.0;
        public double Behandelingskosten { get; private set; } = 0.0;
        public bool Betaald { get; set; } = false;
        private Eigenaar? eigenaar = null;
        private Dier? dier = null;
        public Verblijf(Eigenaar eigenaar, Dier dier, DateTime van, DateTime tot)
        {
            this.eigenaar = eigenaar;
            this.dier = dier;
            Van = van;
            Tot = tot;
            Administratiekosten += Tarieven.Administratiekosten;
        }
        public void Verlengen(DateTime tot)
        {
            Tot = tot;
            Administratiekosten += Tarieven.Administratiekosten;
        }
        public void Annuleren()
        {
            Tot = DateTime.Now;
            if (Van > Tot) Tot = Van;
            Administratiekosten += Tarieven.Administratiekosten;
        }
        public void Behandelen(SoortBehandeling soort)
        {
            switch (soort)
            {
                case SoortBehandeling.Parasietbehandeling: Behandelingskosten += Tarieven.Parasietbehandeling; break;
                case SoortBehandeling.Inenten: Behandelingskosten += Tarieven.Inenting; break;
                case SoortBehandeling.Chippen: Behandelingskosten += Tarieven.Chippen; break;
            }
        }
        public double TotaalPrijs(Diersoort soort)
        {
            double verblijfkosten = (Tot - Van).Days;
            switch (soort)
            {
                case Diersoort.Hond: verblijfkosten = verblijfkosten * Tarieven.DagprijsHond; break;
                case Diersoort.Kat: verblijfkosten = verblijfkosten * Tarieven.DagprijsKat; break;
                case Diersoort.Konijn: verblijfkosten = verblijfkosten * Tarieven.DagprijsKonijn; break;
                default:
                    break;
            }      
            return verblijfkosten;
        }
    }
}
