using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] City1 = new string[] { "Ankara", "Hatay", "İstanbul" };
            string[] City2 = new string[] { "Bolu", "Eskişehir", "Antalya" };
            City2 = City1;
            City2[0] = "Şam";
            Console.WriteLine(City2[1]);
            Console.ReadLine();

        }

    }
   


}
