using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
{
    public class Abitazione:Immobile
    {
        private int numeroVani;
        private int numeroBagni;

        public Abitazione(string indirizzo, string cap, string città, double metratura, int numeroVani, int numeroBagni):base(indirizzo,cap,città,metratura)
        {
            this.numeroVani = numeroVani;
            this.numeroBagni = numeroBagni;
        }

        public int GetNumeroVani()
        {
            return numeroVani;
        }

        public int GetNumeroBagni()
        {
            return numeroBagni;
        }

        public override string ToString()
        {
            string stringaAbitazione = base.ToString();
            stringaAbitazione += "Numero Vani: " + this.numeroVani + "\nNumero Bagni: " + this.numeroBagni + "\n";
            return stringaAbitazione;
        }
    }
}
