using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inversion of control
            //Ninject,Unity,Castle Windsor,Structur map, AutoFac

            var kernal = new StandardKernel(); // It should not be used here, just used it to show you
            kernal.Bind<IMevzuat>().To<First>().InSingletonScope();


            CustomerManager customerManager = new CustomerManager(kernal.Get<IMevzuat>()); 
            customerManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private IMevzuat _mevzuat;

        public CustomerManager(IMevzuat mevzuat)
        {
            _mevzuat = mevzuat;
        }

        public void Add()
        {
            _mevzuat.İslemyap();
        }

    }
    interface IMevzuat
    {
        void İslemyap();
    }
    public class First : IMevzuat
    {
        public void İslemyap()
        {
            Console.WriteLine("First Legislation was added");
        }
    }
    public class Second : IMevzuat
    {
        public void İslemyap()
        {
            Console.WriteLine("Second Legislation was added");
        }
    }
}
