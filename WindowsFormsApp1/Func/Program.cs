using System;
using System.Security.Cryptography;
using System.Threading;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = topla;
            Console.WriteLine(add(34, 0));
            //Console.WriteLine(topla(2,10));
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1,20);
            };
            Console.WriteLine(getRandomNumber());
            // Zamanlayıcı .
            Thread.Sleep(10000);
            // getrandomnuber [() <= sonunda bu barantezler unutma biso ]
            Func<int> grtRandomNumber2 = () => new Random().Next(12,14);
            Console.WriteLine(grtRandomNumber2());
            
            Console.ReadLine();
        }
        static int topla(int S1,int  S2)
        {
            return S1 + S2;
        }
    }
}
