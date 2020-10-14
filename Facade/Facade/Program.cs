using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManader customerManader = new CustomerManader();
            customerManader.Save();
            Console.ReadLine();
        }
    }
    class Logging:ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }
    interface ILogging
    {
        void Log();
    }

    class Caching:ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    internal interface ICaching
    {
        void Cache();
    }
    class Validation:IValidate
    {
        public void Validate()
        {
            Console.WriteLine(" Validated ...!");
        }
    }

    internal interface IValidate
    {
        void Validate();
    }

    class Authorize:IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("Check  User");
        }
    }

    internal interface IAuthorize
    {
        void CheckUser();
    }

    class CustomerManader
    {
        // dahga güzel ve mantıklı bir şekilde halletik
        //private ILogging _logging;
        // private ICaching _caching;
        // private IAuthorize _authorize;
        private CrossCuttongConcernsFacade _concerns;
        public CustomerManader(/*ILogging logging, ICaching caching, IAuthorize authorize*/)
        {
            // _logging = logging;
            // _caching = caching;
            //_authorize = authorize;
            _concerns = new CrossCuttongConcernsFacade();
        }
        public void Save()
        {
            //_logging.Log();
            //_caching.Cache();
            //_authorize.CheckUser();
            _concerns.Logging.Log();
            _concerns.Caching.Cache();
            _concerns.Authorize.CheckUser();
            _concerns.Validation.Validate();
            Console.WriteLine(" the AMK is saved :) ");
        }
    }
    // üç tane nesne oluşturduk ve bu nesneler bir fasad içeresinde new'ledim 
    //----- ):   ve " Customer Manager " class'inde kullanıyor olduk 
    class CrossCuttongConcernsFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;
        public IValidate Validate;
       public CrossCuttongConcernsFacade()
        {

          
            Authorize = new Authorize();
            Caching = new Caching();
            Logging = new Logging();
            Validation = new Validation();

        }

         public Validation Validation { get; }

    }
}
