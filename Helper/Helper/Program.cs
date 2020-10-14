using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class StringHelper
    {
        // Gereksimeler
        // Girilen ifadenin basindaki ve sonundaki bosluklar silinmelidir
        //Girilen ifadenin fazla bosluklar silinmelidir
        public static string fazlabosluklarasil(string ifade)
        {
            ifade = ifade.Trim();
            string yeniifede = string.Empty;
            for (int i = 0; i < ifade.Length; i++)
            {
                if (ifade[i] == ' ' && ifade[i + 1] == ' ')
                    continue;
                yeniifede += ifade[i];

            }
            return yeniifede;

        }
    }
}
