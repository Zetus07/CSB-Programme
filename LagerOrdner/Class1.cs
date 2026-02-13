using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombo
{
    internal class Class1
    {

        public static void  Main(string[] args)
        {
            DVD();
        }

        public static void DVD()
        {
            int x = 1;
            int y = 1;
            int dx = 1;
            int dy = 1;
            int maxX = Console.WindowWidth;
            int maxY = Console.WindowHeight;
            char[] trailSymb = { '#', 'o', 'o', '.', '.', '.' };
            List<(int x, int y)> trailcords = new List<(int x, int y)>();
            
            Console.CursorVisible = false;


            while (true)
            {


                if (x <= 0 || x >= maxX - 1) // richtungswechsel x
                {
                    dx = dx * -1;
                }
                if (y <= 0 || y >= maxY - 1) // richtungswechsel y
                {
                    dy = dy * -1;
                }



                x = x + dx;
                y = y + dy;

                trailcords.Add((x, y)); // Koordinaten werden gespeichert


                int traillength = trailcords.Count()-1; // wie viele Koordinaten

                if (traillength >= 5)        // mehr als 6 Kords?
                {
                    trailcords.RemoveAt(0); // ältstes wird gelöscht

                }
                int j = 0;

                if (traillength > 4)
                {
                    for (int i = 5; i >= 0; i--) // ausgabe der Elemente
                    {
                        if (traillength <= 5)
                        {

                            Console.SetCursorPosition(trailcords[j].x, trailcords[j].y);
                            Console.Write(trailSymb[j]);
                            j++;
                            Thread.Sleep(50);
                        }
                        else
                        {
                            break;
                        }

                    }
                    Console.Clear();
                }






                




            }

        }

    }

}






/*
trail.Add((x, y));
int trailLength = trail.Count();

if (trailLength > 6)
{
    trail.RemoveAt(0);

}
char trailSymbol = trailSymb[0];
int j = 0;
for (int i = 5; i >= 0; i--)
{
    trailSymbol = trailSymb[i];
    int length = trailLength - i;
    int var = trailLength - 1 - j;
    if (length > 1 && var < 6) {

        Console.SetCursorPosition(trail[trailLength-1-j].x, trail[trailLength -1 - j].y);
        Console.Write(trailSymb[j]);
        j++;
    }


}




Console.Clear();

Console.SetCursorPosition(x, y);

Thread.Sleep(50);






*/

