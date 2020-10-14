using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
          var customerManager=  CustomerManager.CreateAsSingelton();
            customerManager.save();
        }
    }
    class CustomerManager
    {
      private  static CustomerManager _customerManager;
        static object _lockObject = new object();
        private CustomerManager()
        {
            
        }
        public static CustomerManager CreateAsSingelton()
        {
            // bir bak CustomerManager daha önce oluşturulmuş mu Evet ise tamam değil ise oluştur .


            if (_customerManager == null)
            {
                _customerManager = new CustomerManager();
            }
            return _customerManager;

            //lock (_lockObject)
            ////{
            ////    if)
            ////    {
            ////        _customerManager =new CustomerManager();

            ////    }

            //}

        }
        public  void save()
        {
            Console.WriteLine("Saved! :");
        }



    }
}
