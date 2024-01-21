using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Whack_a_Mole
{
    public class Krtek
    {
        public Hrac hrac;
        public int randomNumber; // náhodné číslo vygenerované krtkem
        public int whacks = 0; // počet bouchnutí krtka

        public Krtek() 
        {
        }

        public void ObjevSe()
        {
            // vygenerování náhodného čísla (krtka)
            Random generateRandomNumber = new Random();
            randomNumber = generateRandomNumber.Next(0, 10);
            Console.WriteLine($"Bouchni krtka: {randomNumber}");
        }

        public void BylJsemZasazen(Hrac classHrac)
        {
            if (classHrac.enteredNumber == randomNumber) // pokud hráč zadá číslo správně (bouchne krtka)
            {
                whacks += 1; // přičte zásah
                Console.Clear();
            }
            else // pokud hráč zadá číslo špatně (krtka netrefí)
            {
                // whacks -= 1; // trestné body (strhávají se)
                classHrac.Zasahni();
            }
        }
    }
}
