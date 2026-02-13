using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomboLager.NewFolder
{
    internal class SpielerWchsel
    {
        public static void SpielBeenden(int pEingabe, char[] pFeld, char[] pspielerSymbol)
        {


            for (int i = 0; i <= 3; i = i + 3) //horizontal
            {
                if (pFeld[i] == 'x' && pFeld[i + 1] == 'x' && pFeld[i + 2] == 'x')
                {
                    Console.WriteLine(pspielerSymbol[0] + " hat gewonnen!");

                }

                else if (pFeld[i] == 'o' && pFeld[i + 1] == 'o' && pFeld[i + 2] == 'o')
                {
                    Console.WriteLine(pspielerSymbol[1] + " hat gewonnen!");

                }

            }

            //spiel beendet für vertikale
            for (int i = 0; i <= 2; i++)
            {
                if (pFeld[i] == 'x' && pFeld[i + 3] == 'x' && pFeld[i + 6] == 'x')
                {
                    Console.WriteLine(pspielerSymbol[0] + " hat gewonnen!");

                }

                else if (pFeld[i] == 'o' && pFeld[i + 3] == 'o' && pFeld[i + 6] == 'o')
                {
                    Console.WriteLine(pspielerSymbol[1] + " hat gewonnen!");

                }

            }





            //spiel beendet (für diagonale)
            if (pFeld[0] == 'x' && pFeld[4] == 'x' && pFeld[8] == 'x' || pFeld[2] == 'x' && pFeld[4] == 'x' && pFeld[6] == 'x')
            {
                Console.WriteLine($"Spieler {pspielerSymbol[0]} hat gewonnen ");
            }
            if (pFeld[0] == 'o' && pFeld[4] == 'o' && pFeld[8] == 'o' || pFeld[2] == 'o' && pFeld[4] == 'o' && pFeld[6] == 'o')
            {
                Console.WriteLine($"Spieler {pspielerSymbol[1]} hat gewonnen ");

            }




        }

    }



}



