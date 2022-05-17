using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Per le ville è previsto,in aggiunta rispetto all’appartamento, la dimensione in mq di giardino.

namespace csharp_agenzia
{
    internal class Villa : Appartamento
    {
        int iMqGiardino { get; set; }

        public Villa(int iMqGiardino, int iNumeroVani, int iNumeroBagni, string sCodice, string sIndirizzo, string sCap, string sCitta, int iSuperficie) : base(iNumeroVani, iNumeroBagni, sCodice, sIndirizzo, sCap, sCitta, iSuperficie)
        {
            this.iMqGiardino = iMqGiardino;
        }
        public override string ToString()
        {
            return string.Format("Villa:\n{0}", Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\n Mq Giardino:{1}",
                base.Write(),
                iMqGiardino);
        }
        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (iMqGiardino.ToString().Contains(key)) return true;
            else return false;
        }

    }
}
