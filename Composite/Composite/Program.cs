using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Basil = new Employee { Name = "BASİL AVAD" };
            Employee Muhammed = new Employee { Name = "MUHAMMED AVAD" };
            Basil.AddSubordinat(Muhammed);
            Employee Talal = new Employee { Name = "TALAL AVAD " };
            Basil.AddSubordinat(Talal);
            Contractor Ali = new Contractor { Name = "Ali" };
            Talal.AddSubordinat(Ali);

            Employee Ahmed = new Employee { Name = "Ahmed" };
            Talal.AddSubordinat(Ahmed);
            Console.WriteLine(Basil.Name);

            foreach (Employee manager in Basil)
            {
                Console.WriteLine(manager.Name);            
 
                foreach (IPerson employee in manager)
                {
                    Console.WriteLine(employee.Name);
                }
            }
            Console.ReadLine();
   
        }
    }
    interface IPerson
    {// bir interface vasıtıyla bütün personalımda olması gereken sabit bilgileri yazdım [ isim olur soisim da olur her neyse ]
         string Name { get; set; }
    }

    class Contractor:IPerson
    {
        public string Name { get; set; } 
    }
    // aynı zamanda bu nesneler ulasabilecegimi soyledim | IEnumerable<IPerson> | bununla 
    class Employee :IPerson,IEnumerable<IPerson>
    {
        // burada bir kullancının alt nesneler belirliyoruz .
        List<IPerson> _subordinates = new List<IPerson>();
        public void AddSubordinat(IPerson person)
        {
            _subordinates.Add(person);
        }
         public void RemoveSubordinat(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinat(int index)
        {
            return _subordinates[index];
        }
        //-------------------------------------------------------// Add Remov gibi 
        public string  Name { get; set; }
        IEnumerator<IPerson> IEnumerable<IPerson>.GetEnumerator()
        {
           foreach (var subordinat in _subordinates)
            {
                yield return subordinat;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
