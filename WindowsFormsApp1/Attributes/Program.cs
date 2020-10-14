using System;
using System.ComponentModel.DataAnnotations;

namespace Attributes
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            Customer Customer = new Customer { Id = 1, LastName = "Avad",Age=22 };
            CustomerDal CustomerDal = new CustomerDal ();
            CustomerDal.Add(Customer);
            Console.ReadLine();
        }
    }
   
    class Customer
    {
        public int  Id { get; set; }
        [Requiredproperty]
       
        public string FirstName { get; set; }
        [Requiredproperty]
        public string LastName { get; set; }
        [Requiredproperty]
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, istead use AddNew Method")]
        public void Add(Customer Customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Adedd!",
                Customer.Id,Customer.FirstName,Customer.LastName,Customer.Age);
        }
        
        public void AddNew(Customer Customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Adedd!",
                Customer.Id, Customer.FirstName, Customer.LastName, Customer.Age);
        }
    }
    [AttributeUsage(AttributeTargets.Property ,AllowMultiple =false)]
    class RequiredpropertyAttribute:Attribute
    {


    }
    
}
