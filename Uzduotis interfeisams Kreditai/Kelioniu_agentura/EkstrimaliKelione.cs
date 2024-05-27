using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Finansu_kreditai
{
    public class EkstrimaliKelione : Kelione, IKelionesUzsakymas
    {
        private double PapildomasMokestis = 100;
        public override void UzsakytiKelione(string kryptis, int dienuSk)
        {
            Kryptis = kryptis;
            DienuSkaicius = dienuSk;
        }
        public override double GautiKelionesKaina()
        {
            return BazinesKainos * PapildomasMokestis *DienuSkaicius;
        }
    }
}
