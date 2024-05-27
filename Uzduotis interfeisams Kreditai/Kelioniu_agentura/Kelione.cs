using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzduotis_interfeisams_Kreditai;

namespace Finansu_kreditai
{
    public abstract class Kelione : IKelionesUzsakymas
    {
        public string Kryptis { get; protected set; }
        protected int DienuSkaicius { get; set; }
        protected double BazinesKainos { get; set; } = 100.0;
        public double GautiBazinesKainos()

        {
            return BazinesKainos;
        }
        public abstract void UzsakytiKelione(string kryptis, int dienuSk);
        public abstract double GautiKelionesKaina();
    }
}
    

