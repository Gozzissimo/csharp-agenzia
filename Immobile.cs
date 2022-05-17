using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Gli immobili sono caratterizzati da:
- un codice alfanumerico,
- indirizzo,
- cap,
- città 
- una superficie espressa in mq attraverso un numero intero. 
*/

namespace csharp_agenzia
{
    internal class Immobile
    {
        public string sCodice { get; set; }
        public string sIndirizzo { get; set; }
        public string sCap { get; set; }
        public string sCitta { get; set; }
        public int iSuperficie { get; set; }

        public Immobile(string sCodice, string sIndirizzo, string sCap, string sCitta, int iSuperficie)
        {
            this.sCodice = sCodice;
            this.sIndirizzo = sIndirizzo;
            this.sCap = sCap;
            this.sCitta = sCitta;
            this.iSuperficie = iSuperficie;
        }

        public override string ToString()
        {
            return string.Format("Immobile:\n{0}", Write());
        }

        protected virtual string Write()
        {
            return string.Format("Codice: {0}\nIndirizzo: {1}\nCap: {2}\nCittà: {3}\nSuperficie: {4} mq\n",
                this.sCodice,
                this.sIndirizzo,
                this.sCap,
                this.sCitta,
                this.iSuperficie);
        }
        public virtual bool Contains(string key)
        {
            if (sCodice.Contains(key)) return true;
            else if (sIndirizzo.Contains(key)) return true;
            else if (sCap.Contains(key)) return true;
            else if (sCitta.Contains(key)) return true;
            else if (iSuperficie.ToString().Contains(key)) return true;
            else return false;
        }

    }
}
