using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototytpe
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Firstname = "Basil", Lastname = "Avad", Id = 1, City = "Hatay" };

            Customer customer2 = (Customer)customer.Clone();
            customer2.Firstname = "BASİL AVAD";
            Console.WriteLine(customer.Firstname);

            Console.WriteLine(customer2.Firstname);
            Console.ReadLine();
        }
    }

    public abstract class Person
    {
        // pozitif halıne getirmek için |
        public abstract Person Clone();
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
    public class Customer:Person
    {
        public string City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
