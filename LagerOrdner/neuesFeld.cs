using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomboLager.NewFolder
{
    internal class neuesFeld
    {
        public static void NeuesFeld(int pEingabe, char[] pFeld, char[] pSymbole, int pSpielerdran, bool pGesetzt)
        {
            for (int i = 0; i <= 8; i++) // neues feld wird ausgegeben
            {
                if (pFeld[i] == pSymbole[0])
                {
                    Console.Write("  " + pSymbole[0] + "\t"); //wenn im Array spielersymbol ist, wird es ausgegeben, keine zahl
                    if (i == 2 || i == 5 || i == 8)
                    {
                        Console.WriteLine();
                    }
                    pGesetzt = true;

                }
                else if (pFeld[i] == pSymbole[1])
                {
                    Console.Write("  " + pSymbole[1] + "\t");
                    if (i == 2 || i == 5 || i == 8)
                    {
                        Console.WriteLine();
                    }
                    pGesetzt = true;

                }
                else
                {
                    Console.Write("  " + (i + 1) + "\t");
                    if (i == 2 || i == 5 || i == 8)
                    {
                        Console.WriteLine();
                    }
                    pGesetzt = true;
                }


            }
        }
    }
}
