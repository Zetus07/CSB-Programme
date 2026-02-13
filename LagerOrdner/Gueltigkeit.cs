using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomboLager.NewFolder
{
    internal class Gueltigkeit
    {
        public static int GueltgkeitChecken(int pEingabe, char[] pFeld, char[] pSymbole, int pSpielerdran)
        {
            Console.WriteLine($"Spieler Symbol {pSymbole[pSpielerdran]} ist dran: ");
            Console.WriteLine("Wähle ein Feld aus. (1-9) ");
            pEingabe = pEingabe - 1;
            while (true)
            {
                if (pEingabe < 0 || pEingabe > 8)
                {
                    for (int i = 3; i == 0; i--)
                    {
                        Console.WriteLine($"Nenne eine gültige Zahl. Noch {i} Verusuche.");
                    }

                }
                else if (pFeld[pEingabe] != pSymbole[pSpielerdran])
                {
                    pFeld[pEingabe] = pSymbole[pSpielerdran];
                }
                else
                {
                    Console.WriteLine("Ungültige Nummer.");

                }


                return pEingabe;






            }
        }

    }
}
