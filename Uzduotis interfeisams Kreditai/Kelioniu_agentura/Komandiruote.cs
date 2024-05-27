using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzduotis_interfeisams_Kreditai;

namespace Finansu_kreditai
{
    public class Komandiruote : Kelione, IKelionesUzsakymas
    {
        private  const double Nuolaida = 0.2;
        public override void UzsakytiKelione(string kryptis, int dienuSk)
        {
            Kryptis = kryptis;
            DienuSkaicius = dienuSk;
        }
        public override double GautiKelionesKaina()
        { return Nuolaida * BazinesKainos * DienuSkaicius; }


    }
}
