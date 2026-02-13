using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomboLager.NewFolder
{
    public class TTT
    {
        public static void Main(string[] args)     // Main (mit großem m schreiben)

        {
            char[] Feld = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] spielerSymbol = { 'x', 'o' };
            int spielerDran = 0;
            bool spielerGesetzt = false;
            int input = Convert.ToInt32(Console.ReadLine());


            startFeld.AnsichtErzeugen();
            Gueltigkeit.GueltgkeitChecken(input, Feld, spielerSymbol, spielerDran);
            BomboLager.SpielBeenden.Beenden();

        }

    }
    //---------------------------------------------------------




}




