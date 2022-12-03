using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
{
    public class Immobile
    {   
        static private List<Immobile> ListaImmobili = new List<Immobile>();
        private string codice;
        private string indirizzo;
        private string cap;
        private string città;
        private double metratura;

        public Immobile(string indirizzo, string cap, string città, double metratura)
        {
            this.codice = "";
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.città = città;
            this.metratura = metratura;
            ListaImmobili.Add(this);
        }

        public List<Immobile> GetListaImmobili()
        {
            return ListaImmobili;
        }

        public string GetCodice()
        {
            return this.codice;
        }

        public string GetIndirizzo()
        {
            return this.indirizzo;
        }

        public string GetCap()
        {
            return this.cap;
        }

        public string GetCittà()
        {
            return this.città;
        }

        public double GetMetratura()
        {
            return this.metratura;
        }

        public void SetCodice(string codice)
        {
            bool invalidazione=ImmobileDoppio(codice);
            if (invalidazione)
            {
                return;
            }
            else
            {
                this.codice = codice;
            }
        }

        public bool VerificaImmobile(string codiceImmobile)
        {
            if (codiceImmobile == this.codice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string ImmobileStringa="\n---------- "
                + this.codice
                + " ----------\n\nindirizzo: "
                + this.indirizzo
                + "\nCAP: "
                + this.cap
                + "\nCittà: "
                + this.città
                + "\nMetratura: "
                + this.metratura
                + "mq\n";
            return ImmobileStringa;
        }

        private bool ImmobileDoppio(string codice)
        {
            {
                foreach (Immobile immobile in ListaImmobili)
                {
                    if (immobile.VerificaImmobile(codice))
                    {
                        Console.WriteLine("ATTENZIONE, IL CODICE INSERITO E' GIA' PRESENTE, PER NON INCORRERE IN ERRORI IMPOSTA UN CODICE DISPONIBILE");
                        return true;
                    }
                }
                return false;
            }
        }
    }

}
