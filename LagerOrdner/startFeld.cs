using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomboLager.NewFolder
{
    internal class startFeld //ansicht erzeugen
    {
        public static void AnsichtErzeugen()
        {
            char[] Feld = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Console.WriteLine("T3 Terminal: ");

            for (int i = 0; i <= 8; i++)
            {
                Console.Write("   " + Feld[i] + "   ");
                if (i == 2 || i == 5)
                {
                    Console.WriteLine();
                    Console.Write("------|-------|------ ");
                    Console.WriteLine();
                }

            }
            Console.WriteLine();


        }

    }
}
