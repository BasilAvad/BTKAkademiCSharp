
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
       CreditBase credit   = new CrediManagerProxy();
            Console.WriteLine(credit.Calculate());
            Console.WriteLine(credit.Calculate());
            Console.ReadLine();
        }
    }
    // operasyon sınıfımıza karşılık gelir ve bunun bir hesablama olduğunu belirledik 
    abstract class CreditBase
    {
        public abstract int Calculate();
        
    }
    class CrediManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 1; i < 6; i++)
            {
                result = result * i;
                Thread.Sleep(100);

            }
            return result;
        }

    }
    class CrediManagerProxy : CreditBase
    {
    private  CrediManager _CrediManager;
        private int cachedVslue;
        public override int Calculate()
        {
            if (_CrediManager == null)
            {
                _CrediManager = new CrediManager();
                cachedVslue = _CrediManager.Calculate();
            }
            return cachedVslue;
        }
    }
}
