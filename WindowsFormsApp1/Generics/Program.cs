﻿using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BildList<string>("ankara ","izmir","hatay");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BildList<Customer>(new Customer { FirstName="basil"}, new Customer { FirstName="avad"});
            foreach (var Customer in result2)
            { 
                Console.WriteLine(Customer.FirstName);
            }

            
            Console.ReadLine();

        }
        class Utilities
        {
            public List<T> BildList<T>(params T[] items)
            {

                return new List<T>(items);
                
            }
            
        }
        class Product : IEntity
        { 

        }
        interface IProductDal: IRepository<Product>
        {
          

        }
        class Customer :IEntity
        {
            public string FirstName { get; set; }
        }
        interface ICustomerDal :IRepository<Customer>
        {

            void Costom();
        }
    interface IEntity
    {

    }
        interface IRepository <T> where T:class,IEntity ,new()
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T entity);
            void Delete(T entity);
            void Update(T entity);
        }
        class ProductDal : IProductDal
        {
            public void Add(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product entity)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }
        }
        class Customerdal : ICustomerDal
        {
            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Costom()
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
