using System;

/*
 * Esercizio 2: Agenzia immobiliare

Si vuole progettare un’applicazione in grado di gestire un’agenzia 
immobiliare. 

Gli immobili sono caratterizzati da:
- un codice alfanumerico,
- indirizzo,
- cap,
- città 
- una superficie espressa in mq attraverso un numero intero. 


L’agenzia gestisce diverse tipologie di immobili: 
- Box, 
- Appartamenti
- Ville.

Per i box è riportato il numero di posti auto. 
Per gli appartamenti è 
riportato in numero di vani e il numero di bagni.

Per le ville è previsto,
in aggiunta rispetto all’appartamento, la dimensione in mq di giardino.

Ridefinire per ciascuna delle tre classi il metodo ToString in modo da fornire 
una descrizione completa dell'immobile. StampaSchedaImmobile

Provare a pensare ad una funzione di ricerca.
*/


namespace csharp_agenzia // Note: actual namespace depends on the project name.
{
    internal class Agenzia
    {
        public string sNomeAgenzia { get; set; }

        public List<Immobile> lImmobili { get; set; } //LISTA IMMOBILI

        public Agenzia(string sNomeAgenzia) //COSTRUTTORE
        {
            this.sNomeAgenzia = sNomeAgenzia;
            this.lImmobili = new List<Immobile>();
        }

        public void AddImmobile(Immobile immobile)
        {
            lImmobili.Add(immobile);
        }

        public List<Immobile> SearchImmobili(string key)
        {
            //return lImmobili.FindAll(i => i.Contains(key)); PRIMA OPZIONE

            List<Immobile> lSottoLista = new List<Immobile>(); //SECONDA OPZIONE
            foreach (Immobile mioImmobile in lImmobili)
            {
                if (mioImmobile.Contains(key))
                {
                    lSottoLista.Add(mioImmobile);
                }
                else
                {
                    return lSottoLista;
                }
                
            }
        }

    }
}