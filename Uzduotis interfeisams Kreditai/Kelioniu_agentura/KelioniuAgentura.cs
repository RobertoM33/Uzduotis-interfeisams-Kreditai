using Finansu_kreditai;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Uzduotis_interfeisams_Kreditai;

namespace Uzduotis_interfeisams_Kreditai
{
    public class KelioniuAgentura
    {
        private List<Kelione> keliones = new List<Kelione>();

        private void PridetiKelione(Kelione kelione)

        {
            keliones.Add(kelione);
            return;
        }
        public void UzsakytiKelione(string kelionesTipas, string kryptis, int dienuSk)
        {

            Kelione kelione = null;
            switch (kelionesTipas.ToLower())
            {
                case "atostogos":
                    kelione = new Atostogos();
                    break;
                case "komandiruote":
                    kelione = new Komandiruote();
                    break;
                case "ekstrimali":
                    kelione = new EkstrimaliKelione();
                    break;
                default:
                    Console.WriteLine("Nezinomas keliones tipas");
                    return;
            }
            kelione.UzsakytiKelione(kryptis, dienuSk);
            PridetiKelione(kelione);
            Console.WriteLine($" Kelione i {kryptis} uzsakyta sekmingai. Galutine kaina: {kelione.GautiKelionesKaina()} eur");
        }
        public void RodytiVisasKeliones()
        {
            foreach (var kelione in keliones)
            {
                Console.WriteLine($"Kelione i {kelione.Kryptis}, Dienu skaicius: {kelione.GautiKelionesKaina()},Kaina: {kelione.GautiKelionesKaina()} eur);");
            }
        }
    }
}















