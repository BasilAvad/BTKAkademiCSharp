using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class IslemManager
    {
       public static void Main(string[] args)
        {
            Console.WriteLine( Topla(1, 5)) ;
            Console.ReadLine();
        }
        public static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
