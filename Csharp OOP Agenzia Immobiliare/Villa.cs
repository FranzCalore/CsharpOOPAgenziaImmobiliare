using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
{
    public class Villa:Abitazione
    {
        private double metraturaGiardino;

        public Villa(string codice, string indirizzo, string cap, string città, double metratura, int numeroVani, int numeroBagni, double metraturaGiardino):base(codice,indirizzo,cap,città,metratura,numeroVani,numeroBagni)
        {
            this.metraturaGiardino = metraturaGiardino;
        }

        public double GetMetraturaGiardino()
        {
            return this.metraturaGiardino;
        }

        public override string ToString()
        {
            string StringaVilla = base.ToString();
            StringaVilla += "Metratura del Giardino: " + this.metraturaGiardino + "mq";
            return StringaVilla;
        }
    }
}
