using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("* BANKAMATİK PROGRAMI Versiyon 1 *");
            Console.WriteLine("***********************************\n");
            //Mevcut bakiye varsayılan olarak 5000 TL olarak parola ise 12345 olarak ayarlanmıştır.
            int bakiye = 1050, admin_parola = 12345, parola = 0, para_cek = 0, secim;
            char tercih_e_h;
        basagit:
            Console.Clear();
            Console.Write("Parola Giriniz: ");
            parola = Convert.ToInt32(Console.ReadLine());
            if (admin_parola == parola)
            {
            baska_islem_git:
                Console.Clear();
                Console.WriteLine("1.Şifre Değiştirme.");
                Console.WriteLine("2.Para Çekme.");
                Console.WriteLine("3.Bakiye Göster.");
                Console.Write("Seçiminizi Yapın ve klavyeden Enter'a basın. (1-2-3) : ");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Mevcut Şifrenizi Girin: ");
                        parola = Convert.ToInt32(Console.ReadLine());
                        if (admin_parola == parola)
                        {
                            Console.Write("Yeni parolanızı gerin: ");
                            admin_parola = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Parola değiştirme işlemi başarılı...");
                            Console.Write("Başka işlem yapmak ister misiniz? (E/H) : ");
                            tercih_e_h = Convert.ToChar(Console.ReadLine());
                            if (tercih_e_h == 'E' || tercih_e_h == 'e')
                            {
                                goto baska_islem_git;
                            }
                            else
                                break;
                        }
                        else
                        {
                            Console.Write("Parolanızı yanlış girdiniz. Tekrar denemek ister misiniz? (E/H) : ");
                            tercih_e_h = Convert.ToChar(Console.ReadLine());
                            if (tercih_e_h == 'E' || tercih_e_h == 'e')
                            {
                                goto case 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                    case 2:
                        Console.Clear();
                        Console.Write("Çekmek istediğiniz tutarı girin: ");
                        para_cek = Convert.ToInt32(Console.ReadLine());
                        if (para_cek > bakiye)
                        {
                            Console.WriteLine("Bakiyeniz yetersiz.");
                            Console.Write("Çekmek stediğiniz tutarı değiştirmek misiniz? (E/H) : ");
                            tercih_e_h = Convert.ToChar(Console.ReadLine());
                            if (tercih_e_h == 'E' || tercih_e_h == 'e')
                            {
                                goto case 2;
                            }
                            else
                                break;
                        }
                        else
                        {
                            bakiye = bakiye - para_cek;
                            Console.WriteLine("{0} TL çektiniz.", para_cek);
                            Console.Write("Başka işlem yapmak ister misiniz? (E/H) : ");
                            tercih_e_h = Convert.ToChar(Console.ReadLine());
                            if (tercih_e_h == 'E' || tercih_e_h == 'e')
                            {
                                goto baska_islem_git;
                            }
                            else
                                break;
                        }
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Mevcut bakiyeniz: {0} TL", bakiye);
                        Console.Write("Başka işlem yapmak ister misiniz? (E/H) : ");
                        tercih_e_h = Convert.ToChar(Console.ReadLine());
                        if (tercih_e_h == 'E' || tercih_e_h == 'e')
                        {
                            goto baska_islem_git;
                        }
                        else
                            break;
                    default:
                        Console.WriteLine("1-2-3 Seçiminizi doğru yapmadınız.");
                        Console.Write("Başka işlem yapmak ister misiniz? (E/H) : ");
                        tercih_e_h = Convert.ToChar(Console.ReadLine());
                        if (tercih_e_h == 'E' || tercih_e_h == 'e')
                        {
                            goto baska_islem_git;
                        }
                        else
                            break;
                }
            }
            else
            {
                Console.Write("Parolanızı yanlış girdiniz. Tekrar denemek ister misiniz? (E/H) : ");
                tercih_e_h = Convert.ToChar(Console.ReadLine());
                if (tercih_e_h == 'E' || tercih_e_h == 'e')
                {
                    goto basagit;
                }
            }
            Console.WriteLine("\nİyi günler dileriz.");
            Console.WriteLine("\n\n***************************************************************");
            Console.WriteLine("*..::www.bilisimizle.com::..||Bilişim Teknolojileri Sitesi..::*");
            Console.WriteLine("***************************************************************");
            //Facebook ve Youtube sayfalarımızı takip edip yeni eklenen içeriklerden haberdar olabilirsiniz.
            Console.ReadKey();
        }
    }
}
