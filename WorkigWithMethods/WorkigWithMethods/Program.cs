using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkigWithMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new Customer
            {
                Firstname = "basil",
                LastName = "Avad",
                IdentityNumber = "34567"
            });
            customerManager.AdByOtherBusiness(new Customer
            {
                Firstname = "Er",
                LastName = "Avad",
                IdentityNumber = "34567"
            });
            customerManager.Add(new Customer
            {
                Firstname = "Derin",
                LastName = "Avad",
                IdentityNumber = "34567",
                CityId = 1234
            });

            Console.ReadKey();

        }
    }
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            //ValidateFirstNameLength(customer);

            CustomerDal customerDal = new CustomerDal();


            CustomerValidator customerValidator = new CustomerValidator();
           var result= customerValidator.Validate(customer);
            if (result.Errors.Count>0)
            {
                throw new ValidationException(result.Errors);
            }
            CheckCustomerExists(customer);
            customerDal.Add(customer);


        }
        public void AdByOtherBusiness(Customer customer)
        {
            ValidateFirstNameLength(customer);

            CustomerDal customerDal = new CustomerDal();
            CheckCustomerExists(customer);
            customerDal.Add(customer);
        }

        private void ValidateFirstNameLength(Customer customer)
        {
            if (customer.Firstname.Length<2) 
            {
                throw new Exception(" VLİDASYON HATASI OLDU! ");

            }
        }
        private void CheckCustomerExists(Customer customer)
        {
            CustomerDal customerDal = new CustomerDal();
            if (customerDal.CustomerExists(customer))
            {
                throw new Exception("müşteri Zaten mevcut");
            }
        }
    }
    public class CustomerDal
    {
        public void Add(Customer customer)
        {
         
            Console.WriteLine("Eklendi");
        }
        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }
    public class Customer 
    {
        public int Id { get; set; }
        public int CityId { get; set; }


       
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }

    }
}
