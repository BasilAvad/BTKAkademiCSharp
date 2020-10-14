using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HesabMakinası
{
    class Program
    {
        public static float sayi1, sayi2;
        public static float toplama, carpma, bolme, cikarma;
       public static void Main(string[] args)
        {
            
            calistır();
           
            Console.ReadKey();
        }
        public static void calistır()
        {
            Console.WriteLine(" Hangi işlem yapmak istiyorsunuz : ");
            Console.WriteLine(" 1.Çarpma\n" + " 2.Bölme\n" + " 3.Çikarma\n" + " 4.Toplama\n" + " 5.Çıkış Yap");
            int islem = Convert.ToInt32(Console.ReadLine());
            if (islem <= 4 && islem >= 1)
            {
                Console.WriteLine(" Birincisayı gir : ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ikincisayı gir : ");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                switch (islem)
                {
                    case 1:
                        carpmaislemi();
                        break;
                    case 2:
                        bolmeislemi();
                        break;
                    case 3:
                        cikarmaislemi();
                        break;
                    case 4:
                        toplamislemi();
                        break;
                    case 5:
                        cikisyap();
                        break;

                }
            }
            else if (islem > 5 && islem < 1)
            {
                Console.WriteLine(" Lütfen 1-5 arası bir sayı giriniz !! ");
                calistır();
            }
            else
            {
                cikisyap();
            }
        }
        public static void carpmaislemi ()
        {
            
            toplama = sayi1 + sayi2;
            Console.WriteLine(" Toplama işleminin sonucu :  ", toplama);
             islemlertekrarlasorusu();
            calistır();
          

        }
        public static void bolmeislemi ()
        {
            carpma = sayi1 * sayi2;
            Console.WriteLine(" carpmaislemi işleminin sonucu :  ",carpma );
            islemlertekrarlasorusu();
            calistır();
        }
        public static void cikarmaislemi ()
        {
            bolme = sayi1 /sayi2;
            Console.WriteLine(" bolmeislemi işleminin sonucu :  ", bolme);
            islemlertekrarlasorusu();
            calistır();
        }
        public static void toplamislemi()
        {
            cikarma = sayi1 - sayi2;
            Console.WriteLine(" cikarmaislemi işleminin sonucu :  ",cikarma );
            islemlertekrarlasorusu();
            calistır();
            
        }
        public static void islemlertekrarlasorusu()
        {
            Console.WriteLine(" Yeni bir işlem yapmak ister misiniz ? E/H ");
            char yeniden = char.Parse(Console.ReadLine().ToLower());
            if (yeniden=='e')
            {
                calistır();
            }
            else if(yeniden=='h')
            {
                Console.WriteLine(  " Program kapatılyor  ");
                calistır();
            }
            else
            {
                Console.WriteLine(" E Yada H Harfları kullanınız !! ");
                islemlertekrarlasorusu();
                calistır();
            }
        }
        public static void cikisyap()
        {
            Console.WriteLine(" çıkış Yapılıyor ........ ");
            
        }

       
    }
}
