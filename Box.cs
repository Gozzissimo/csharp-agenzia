using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Per il box è riportato il numero di posti auto. 

namespace csharp_agenzia
{
    internal class Box : Immobile
    {
        public int iPostiAuto { get; set; }

        public Box(int iPostiAuto, string sCodice, string sIndirizzo, string sCap, string sCitta, int iSuperficie) : base (sCodice, sIndirizzo, sCap, sCitta, iSuperficie)
        {
            this.iPostiAuto = iPostiAuto;
        }
        public override string ToString()
        {
            return string.Format("Box:\n{0}", Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\n Posti Auto:{1}",
                base.Write(),
                this.iPostiAuto);
        }
        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (iPostiAuto.ToString().Contains(key)) return true;
            else return false;
        }

    }

}
}
