using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Per gli appartamenti è riportato in numero di vani e il numero di bagni.

namespace csharp_agenzia
{
    internal class Appartamento : Immobile
    {
        public int iNumeroVani { get; set; }
        public int iNumeroBagni { get; set; }

        public Appartamento(int iNumeroVani, int iNumeroBagni, string sCodice, string sIndirizzo, string sCap, string sCitta, int iSuperficie) : base(sCodice, sIndirizzo, sCap, sCitta, iSuperficie)
        {
            this.iNumeroVani = iNumeroVani;
            this.iNumeroBagni = iNumeroBagni;
        }
        public override string ToString()
        {
            return string.Format("Appartamento:\n{0}", Write());
        }

        protected override string Write()
        {
            return string.Format("{0}Numero Vani:{1}\nNumero Bagni:{2}",
                base.Write(),
                iNumeroVani,
                iNumeroBagni);
        }
        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (iNumeroVani.ToString().Contains(key)) return true;
            else if (iNumeroBagni.ToString().Contains(key)) return true;
            else return false;
        }

    }
}
