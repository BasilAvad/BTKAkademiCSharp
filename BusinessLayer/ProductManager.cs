using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductManager
    {
        public bool kullanciEkle(string ad, string tel, string email)

        {
            if (ad.Length < 4) return false;
            if (Regex.IsMatch(tel,"[0-9]")) return false;

            if (email.Contains("@")) return false;


            return true;
        }
    }
}
