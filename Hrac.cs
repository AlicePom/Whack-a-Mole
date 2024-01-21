using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whack_a_Mole
{
    public class Hrac
    {
        public Krtek krtek;
        public int enteredNumber; // číslo načtené od hráče

        public Hrac(Krtek krtek) 
        {
            this.krtek = krtek;
        }

        public void Zasahni() 
        {
            // proměnné pro vyčištění inputu od hráče - příprava na další kolo
            var top = Console.CursorTop; 
            var left = Console.CursorLeft;

            // načtení inputu od hráče
            ConsoleKeyInfo input = Console.ReadKey();
            bool parsed = int.TryParse(input.KeyChar.ToString(), out enteredNumber);

            // pokud se nepodařilo sparsovat (nebylo zadáno číslo), nebo se hráč netrefil (zadal špatné číslo)
            while (!parsed || enteredNumber != krtek.randomNumber)
            {
                // vyčištění inputu od hráče
                Console.SetCursorPosition(left, top);
                Console.Write(new string(' ', 1));
                Console.SetCursorPosition(left, top);

                // načtení dalšího pokusu od hráče
                input = Console.ReadKey(); 
                parsed = int.TryParse(input.KeyChar.ToString(), out enteredNumber);
            }
        }
    }
}
