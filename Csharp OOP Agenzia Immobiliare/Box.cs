using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
{
    public class Box:Immobile
    {
        private int postiAuto;

        public Box(int postiAuto, string indirizzo, string cap, string città, double metratura) :base(indirizzo,cap,città,metratura)
        {
            this.postiAuto = postiAuto;
        }

        public int GetPostiAuto()
        {
            return this.postiAuto;
        }

        public void SetPostiAuto(int postiAuto)
        {
            this.postiAuto=postiAuto;
        }

        public override string ToString()
        {
            string StringaBox= base.ToString();
            StringaBox += "Posti Auto: " + this.postiAuto;
            return StringaBox;
        }
    }
}
