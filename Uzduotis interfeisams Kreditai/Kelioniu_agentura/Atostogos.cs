using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finansu_kreditai
{
    public class Atostogos : Kelione, IKelionesUzsakymas
       
    {
        private double PapildomasMokestis = 50.0;
        public override void UzsakytiKelione(string kryptis, int dienuSk)
        {
            Kryptis = kryptis;
            DienuSkaicius = dienuSk;

        }
        public override double GautiKelionesKaina()
        {
            return BazinesKainos * DienuSkaicius + PapildomasMokestis;

        }
    }
}
