using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomboLager.NewFolder
{
    internal class ZugWechsel
    {
        public static void Zugwechsel(int pspielerDran, bool pspielerGesetzt)
        {
            if (pspielerDran == 0 && pspielerGesetzt == true)
            {
                pspielerDran = 1;
                pspielerGesetzt = false;
            }
            if (pspielerDran == 1 && pspielerGesetzt == true)
            {
                pspielerDran = 0;
                pspielerGesetzt = false;
            }

        }
    }
}
