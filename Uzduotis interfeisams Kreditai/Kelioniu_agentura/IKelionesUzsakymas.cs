using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finansu_kreditai
{
    internal interface IKelionesUzsakymas
    {
        void UzsakytiKelione(string kryptis, int dienuSk);
        double GautiKelionesKaina();

    }
}
