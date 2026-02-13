using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomboLager
{
    internal class DVD_Logo
    {
        public static void Main(string[] args)
        {
            DVD_Logo.sache();
        }


        public static void sache()
        {

            /*
           int x = 1;
           int y = 1;
           bool richtungX = true;
           bool richtungY = true;
           int i = 1;



           Console.SetCursorPosition(1, 1);

           while (true)

           {

               if (x + 1 >= Console.WindowWidth || x - 1 < 0)
               {
                   richtungX = !richtungX;

               }

               if (y + 1 >= Console.WindowHeight || y - 1 < 0)
               {
                   richtungY = !richtungY;

               }


               if (richtungX == true)
               {
                   x++;
               }
               else
               {
                   x--;
               }

               if (richtungY == true)
               {
                   y++;
               }
               else
               {
                   y--;
               }




               Console.SetCursorPosition(x, y);
               Console.Write("S");

               if (i == x + 1 && i == y +1) 
               {

                   Console.SetCursorPosition(x + 1, y + 1);
                   Console.Write("o");
               }
               if (i == x + 1 && i == y - 1) 
               {

                   Console.SetCursorPosition(x - 1, y + 1);
                   Console.Write("o");
               }
               if (i == x - 1 && i == y - 1)
               {

                   Console.SetCursorPosition(x - 1, y - 1);
                   Console.Write("o");
               }
               if (i == x - 1 && i == y + 1) 
               {
                   Console.SetCursorPosition(x - 1, y + 1);
                   Console.Write("o");

               }
               i++;

                Thread.Sleep(10);








           }
            */
            //--------------------------------------------------

            int x = 0;  int dx = 1;
            int y = 0;  int dy = 1; 
            int maxWidth = Console.WindowWidth;
            int maxHeight = Console.WindowHeight;

            while (true) { 
            x += dx;
            y += dy;

            if(x<=0 || x>= maxWidth - 1) // x am Rand? umgekehrt
            {
                dx = -1;

            }
            if (y <= 0 || y >= maxWidth - 1) // y am Rand? umgekehrt
            {
                dy = -1;

            }

            Console.Clear();
            Console.SetCursorPosition(x,y);
            Console.Write('#');

            List<(int x, int y)> spur = new List<(int x, int y)>();
            spur.Add((x, y));
            if (spur.Count> 6)
            {
                spur.RemoveAt(0);
            }
            foreach(var p in spur)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write('.');
                   
            }
            Console.SetCursorPosition(x, y);
            Console.Write('o');

             char mainChar = 'O';
             char[] spurChars = { '#', 'o', '.', '.' };

                Thread.Sleep(50);
            }
        }
    }
}
