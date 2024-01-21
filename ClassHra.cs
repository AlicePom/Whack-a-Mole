using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whack_a_Mole
{
    internal class ClassHra
    {
        private ClassKrtek classKrtek;
        private ClassHrac classHrac;
        Stopwatch stopwatch = new Stopwatch();

        public ClassHra(ClassKrtek krtek, ClassHrac hrac)
        {
            classKrtek = krtek;
            classHrac = hrac;
            SpustSe();
        }

        public void SpustSe()
        {
            stopwatch.Start(); // 

            while (stopwatch.Elapsed < TimeSpan.FromSeconds(30))
            {
                classKrtek.ObjevSe();
                classHrac.Zasahni();
                classKrtek.BylJsemZasazen();
            }

            stopwatch.Stop();
            Console.WriteLine($"Konec hry, počet Tvých zásahů je {classKrtek.whacks}.");
        }
    }
}
