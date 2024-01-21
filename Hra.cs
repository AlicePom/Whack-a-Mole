using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whack_a_Mole
{
    public class Hra
    {
        public Krtek krtek;
        public Hrac hrac;
        Stopwatch stopwatch = new Stopwatch();

        public Hra()
        {
            krtek = new Krtek();
            hrac = new Hrac(krtek);
            stopwatch.Start(); // spuštění časového limitu
        }

        public void SpustSe()
        {
            while (stopwatch.Elapsed < TimeSpan.FromSeconds(30))
            {
                krtek.ObjevSe();
                hrac.Zasahni();
                krtek.BylJsemZasazen(hrac);
            }

            stopwatch.Stop(); // nemusí tu být, program se ukončí, jakmile přestane platit podmínka v rámci while cyklu
            Console.WriteLine($"Konec hry, počet Tvých zásahů je {krtek.whacks}.");
        }
    }
}
