using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
                Prodoct HadSATA3 = new Prodoct(30);
                HadSATA3.ProductName = "Hard disk";
                Prodoct gsm = new Prodoct(30);
                gsm.ProductName = "GSM";
            gsm.StokControlEvent += Gsm_StokControlEvent;
                for (int i = 0; i < 20; i++)
                {
                    HadSATA3.Sell(10);
                    gsm.Sell(10);
                    Console.ReadLine();
                }
                Console.ReadLine();

                Console.WriteLine("...........");
            
        }

        private static void Gsm_StokControlEvent()
        {
            Console.WriteLine("GSM about to finish");
        }
    }
}
