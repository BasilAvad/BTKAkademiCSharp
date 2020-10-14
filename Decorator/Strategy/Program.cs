using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
     /// <summary>
     /// Bir bankanın müşterilri katıldıkları yıla göre kredi verme işlem
     /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.CreditCulcalatorBase = new After2010CreditCulcalator();
            customerManager.SaveCredit();
            
            customerManager.CreditCulcalatorBase = new Before2010CreditCulcalator();
            customerManager.SaveCredit();
            Console.ReadKey();

        }
    }
   abstract class CreditCulcalatorBase
    {
        public abstract void Culculate();
    }
    class Before2010CreditCulcalator : CreditCulcalatorBase
    {
        public override void Culculate()
        {
            Console.WriteLine(" Credit calculate using befoe2010");
        }
    }
    class After2010CreditCulcalator : CreditCulcalatorBase
    {
        public override void Culculate()
        {
            Console.WriteLine(" Credit calculate using After2010CreditCulcalator ");
        }
    }
    class CustomerManager
    {
        public CreditCulcalatorBase CreditCulcalatorBase { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine(" Customer Manager ");
            CreditCulcalatorBase.Culculate();
        }
    }

}
