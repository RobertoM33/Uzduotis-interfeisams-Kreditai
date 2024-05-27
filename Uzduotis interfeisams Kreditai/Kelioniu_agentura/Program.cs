using System;
using Uzduotis_interfeisams_Kreditai;

namespace Finansu_kreditai
{
    public class Pagrindine
    {
        static void Main(string[] args)
        {
            KelioniuAgentura agentura = new KelioniuAgentura();

            agentura.UzsakytiKelione("atostogos", "Ispanija", 7);
            agentura.UzsakytiKelione("komandiruote", "Vokietija", 3);
            agentura.UzsakytiKelione("ekstrimali", "Nepalas", 5);


            Console.WriteLine("\nVisos keliones");
            agentura.RodytiVisasKeliones();

        }
    }
}


