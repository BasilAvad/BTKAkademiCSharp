using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" birinci sayınız girin AMK :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ikinci sayınız girin AMK :");

            int sayi2 = Convert.ToInt32(Console.ReadLine());
            var tip = typeof(Dortİslem);
            Dortİslem dortİslem = new Dortİslem(sayi1, sayi2);
            Console.WriteLine("sayıların toplamı :{0}", dortİslem.Topla2());
            Console.WriteLine(dortİslem.Carp(sayi1, sayi2));
            var metodlar = tip.GetMethods();
            var instance = Activator.CreateInstance(tip, 4, 5);
            MethodInfo methodInfo = instance.GetType().GetMethod("topla2");
            Console.WriteLine("......................");
            //Console.WriteLine(methodInfo.Invoke(instance,null));
            var method = tip.GetMethods();
            foreach (var info in method)
            {
                Console.WriteLine("Method Adı :{0}", info.Name);
                foreach (var parameterInfo in info.GetParameters()) 
                {
                    Console.WriteLine("Parameter: {0} ",parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine(" Attribute Name :{0}",attribute.GetType().Name);
                }
            }

            Console.ReadLine();

        }
    }
   public class Dortİslem
    {
        private int _sayi1;
        private int _sayi2;
        public Dortİslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
          

        public decimal  Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public decimal Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public decimal Topla2()
        {
            return _sayi1 + _sayi2;
        }
        public decimal Carp2()
        {
            return _sayi1 *_sayi2;
        }
        public class MetodNameAttribute : Attribute
        {
            public MetodNameAttribute(string Name)
            {

            }
        }

    }
}
