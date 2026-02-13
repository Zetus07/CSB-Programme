namespace BomboLager.NewFolder
{
    internal class Struktogramme_Umsetzen
    {
        static void Main(string[] args)
        {
            Schaltjahr.schaltjahrHerausfinden();

        }
    }

    //--------------------------------------------------------

    internal class Bankautomat
    {
        public void AutomatAbrufen()
        {
            int PIN = 1234;
            int input = Convert.ToInt32(Console.ReadLine());
            double Kontostand = -20.0;

            if (input == PIN)
            {
                Console.WriteLine("Passwort ist richtig! Was möchten sie abrufen?");
                Console.WriteLine("Drücken sie die 1 für Auszahlung, die 2 für Kontostand.");
                int input2 = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Auszahlung ausgewählt.");
                    Console.WriteLine("Wählen sie nun ihren Betrag in Euro.");
                    int betrag = Console.Read();
                    Kontostand = Kontostand + betrag;

                }
                else
                {
                    Console.WriteLine("Ihr Kontostand beträgt: " + Kontostand);
                }
            }
            else
            {
                Console.WriteLine("Falsches Passwort, bitte versuchen sie es später noch einmal.");
            }

        }



    }

    //--------------------------------------------------------


    internal class Parkautomat
    {
        public static void AutomatAbrufen(string[] args)
        {
            double proStd = 1.20;
            double abDreiStd = 1.0;
            Console.WriteLine("Wie lange haben sie hier geparkt (in ganzen Stunden)?");
            int zeit = Convert.ToInt32(Console.ReadLine());
            if (zeit < 3)
            {
                Console.WriteLine("Gebühr: " + zeit * proStd);

            }
            else
            {
                Console.WriteLine("Gebühr: " + (zeit - 3 * abDreiStd + 3 * proStd));
            }
        }
    }



    //--------------------------------------------------------
    internal class Kaffeautomat1
    {


        public static void AutomatAbrufen(string[] args)
        {
            Console.WriteLine("Hallo!");
            Console.WriteLine("Geben sie eine Zahl ein: 1: Kakao, 2: Kaffee, 3: Espresso");
            int input = Convert.ToInt32(Console.ReadLine());
            if (1 == input)
            {
                Console.WriteLine("Welche Größe möchten sie? 1: Klein, 2: Groß");
                int input2 = Convert.ToInt32(Console.ReadLine());
                if (input2 == 1)
                {
                    Console.WriteLine("In Bearbeitung: kleinen Kakao");
                }
                else
                {

                    Console.WriteLine("In Bearbeitung: großen Kakao");
                }

            }

            if (2 == input)
            {
                Console.WriteLine("Welche Größe möchten sie? 1: Klein, 2: Groß");
                int input2 = Convert.ToInt32(Console.ReadLine());
                if (input2 == 1)
                {
                    Console.WriteLine("Welches von denen möchten sie dazu haben? 1: Ja, 2: Nein");
                    int input3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Möchten sie Zucker dazu haben? 1:Ja, 2:Nein");
                    int input4 = Convert.ToInt32(Console.ReadLine());
                    if (input3 == 1 && input4 == 1)
                    {
                        if (input2 == 1)
                            Console.WriteLine("In Bearbeitung: kleiner Kaffee mit Milch und Zucker");

                    }
                    if (input3 == 1 && input4 != 1)
                    {
                        Console.WriteLine("In Bearbeitung: kleiner Kaffee mit Milch.");

                    }
                    if (input3 != 1 && input4 == 1)
                    {
                        Console.WriteLine("In Bearbeitung: kleiner Kaffee mit Zucker.");

                    }
                    else
                    {
                        Console.WriteLine("InvalidNumber, Bitte versuche es nochmal.");

                    }
                }

            }

            if (3 == input)
            {

                Console.WriteLine("Milch? 1: Ja, 2: Nein");
                int input3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zucker? 1:Ja, 2:Nein");
                int input4 = Convert.ToInt32(Console.ReadLine());
                if (input3 == 1 && input4 == 1)
                {

                }
                if (input3 == 1 && input4 != 1)
                {
                    Console.WriteLine("In Bearbeitung: kleiner Kaffee mit Milch.");

                }
                if (input3 != 1 && input4 == 1)
                {
                    Console.WriteLine("In Bearbeitung: kleiner Kaffee mit Zucker.");

                }
                else
                {
                    Console.WriteLine("InvalidNumber, Bitte versuche es nochmal.");

                }
            }

        }

        //--------------------- incomplete KaffeeAutomat
    }

    //--------------------------------------------------------
    internal class Falkultät
    {


        public static void fakultätausrechnen()
        {
            Console.WriteLine("Fakultät Rechner: Welche Zahl möchtest du fakultieren?");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int vorherZahl = zahl;
            if (zahl > 0)
            {
                int i = zahl - 1;
                while (i > 1)
                {
                    zahl = zahl * i;
                    i--;
                }
                Console.WriteLine("Die Fakultät von " + vorherZahl + " ist " + zahl);
            }

        }
    }


    //-----------------------------------------------------------

    internal class Schaltjahr
    {
        public static void schaltjahrHerausfinden()
        {
            Console.WriteLine("Schaltjahr Checken: Gib ein Jahr.");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 1582)
            {
                Console.WriteLine("Das Jahr " + input + " ist ein Schaltjahr");

                if (input % 4 == 0)
                {
                    if (input % 100 == 0 && input % 400 != 0)
                    {
                        Console.WriteLine("Das Jahr " + input + " ist kein Schaltjahr");

                    }
                    if (input % 400 == 0)
                    {
                        Console.WriteLine("Das Jahr " + input + " ist ein Schaltjahr");  //incomplete a bit

                    }

                }

            }
        }


    }

}



