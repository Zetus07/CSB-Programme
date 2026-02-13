using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomboLager.NewFolder
{
    internal class TTT
    {
        public static void Main(string[] args)     // Main (mit großem m schreiben)

        {
            TicTacToe_Ausgabe.AnsichtErzeugen();
            TicTacToe_Ausgabe.veruchnr27();
        }

    }
    //---------------------------------------------------------



    internal class TicTacToe_Ausgabe
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



        public static void veruchnr27()
        {
            char[] Feld = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] spielerSymbol = { 'x', 'o' };
            int spielerDran = 0;
            bool spielerGesetzt = false;

            while (true)
            {

                Console.WriteLine($"Spieler Symbol {spielerSymbol[spielerDran]} ist dran: ");
                Console.WriteLine("Wähle ein Feld aus. (1-9)");
                int input = Convert.ToInt32(Console.ReadLine());
                input--;
                // zahl zu groß/ klein?
                if (input < 0 || input > 8)
                {
                    Console.WriteLine("Cuuuuuh, bis du dumm? Kannst du nicht lesen amenakoyumdenasai.");
                    continue;
                }


                // feld wird mit symbol belegt
                if (Feld[input] != spielerSymbol[0] && Feld[input] != spielerSymbol[1])
                {
                    Feld[input] = spielerSymbol[spielerDran];

                }
                else
                {
                    Console.WriteLine("Ungültige Nummer.");
                    continue;
                }

                for (int i = 0; i <= 8; i++) // neues feld wird ausgegeben
                {
                    if (Feld[i] == spielerSymbol[0])
                    {
                        Console.Write("  " + spielerSymbol[0] + "\t"); //wenn im Array spielersymbol ist, wird es ausgegeben, keine zahl
                        if (i == 2 || i == 5 || i == 8)
                        {
                            Console.WriteLine();
                        }
                        spielerGesetzt = true;

                    }
                    else if (Feld[i] == spielerSymbol[1])
                    {
                        Console.Write("  " + spielerSymbol[1] + "\t");
                        if (i == 2 || i == 5 || i == 8)
                        {
                            Console.WriteLine();
                        }
                        spielerGesetzt = true;

                    }
                    else
                    {
                        Console.Write("  " + (i + 1) + "\t");
                        if (i == 2 || i == 5 || i == 8)
                        {
                            Console.WriteLine();
                        }
                        spielerGesetzt = true;
                    }


                }
                // spieler wechsel
                if (spielerDran == 0 && spielerGesetzt == true)
                {
                    spielerDran = 1;
                    spielerGesetzt = false;
                }
                else if (spielerDran == 1 && spielerGesetzt == true)
                {
                    spielerDran = 0;
                    spielerGesetzt = false;
                }



                for (int i = 0; i <= 3; i = i + 3) //horizontal
                {
                    if (Feld[i] == 'x' && Feld[i + 1] == 'x' && Feld[i + 2] == 'x')
                    {
                        Console.WriteLine($"Spieler {spielerSymbol[0]} hat gewonnen.");
                        break;
                    }

                    else if (Feld[i] == 'o' && Feld[i + 1] == 'o' && Feld[i + 2] == 'o')
                    {
                        Console.WriteLine($"Spieler {spielerSymbol[1]} hat gewonnen.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kein Gewinner, Unentschieden.");
                        break;
                    }
                }

                //spiel beendet für vertikale
                for (int i = 0; i <= 2; i++)
                {
                    if (Feld[i] == 'x' && Feld[i + 3] == 'x' && Feld[i + 6] == 'x')
                    {
                        Console.WriteLine($"Spieler {spielerSymbol[0]} hat gewonnen.");
                        break;
                    }

                    else if (Feld[i] == 'o' && Feld[i + 3] == 'o' && Feld[i + 6] == 'o')
                    {
                        Console.WriteLine($"Spieler {spielerSymbol[1]} hat gewonnen.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kein Gewinner, Unentschieden.");
                        break;
                    }

                }




                //spiel beendet (für diagonale)
                if (Feld[0] == 'x' && Feld[1] == 'x' && Feld[2] == 'x' || Feld[0] == 'x' && Feld[4] == 'x' && Feld[8] == 'x' || Feld[2] == 'x' && Feld[4] == 'x' && Feld[6] == 'x')
                {
                    Console.WriteLine($"Spieler {spielerSymbol[0]} hat gewonnen ");
                    break;
                }
                else if (Feld[0] == 'o' && Feld[1] == 'o' && Feld[2] == 'o' || Feld[0] == 'o' && Feld[4] == 'o' && Feld[8] == 'o' || Feld[2] == 'o' && Feld[4] == 'o' && Feld[6] == 'o')
                {
                    Console.WriteLine($"Spieler {spielerSymbol[1]} hat gewonnen ");
                    break;
                }

                else
                {
                    Console.WriteLine("Kein Gewinner, Unentschieden.");
                    break;
                }


            }


        }

    }
}




