using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager basil = new Manager { Name="Basil ",Salary=1200};
            Manager ahmed = new Manager { Name = "Basil ", Salary = 1200 };

            Worker salam = new Worker { Name = "Salam", Salary = 20 };
            Worker şarmota = new Worker { Name = "Basil ", Salary = 200 };
            basil.Subordinates.AddFirst(ahmed);
            ahmed.Subordinates.AddFirst(salam);
            ahmed.Subordinates.AddFirst(şarmota);
            OrganisationStructure organisationStructure = new OrganisationStructure(basil);

            PayrolVisitor payrolVisitor = new PayrolVisitor();
            Payrise payrise = new Payrise();

            organisationStructure.Accept(payrolVisitor);
            organisationStructure.Accept(payrise);
            Console.ReadLine();
        }
    }
    class OrganisationStructure // personelerin maaslarını zam yapalım 
    {
      public  EmployeeBase Employee;

        public OrganisationStructure(EmployeeBase FirstEmployee)
        {
            Employee = FirstEmployee;
        }
        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }
    }
  abstract  class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitor);
        public string Name { get; set; }
        public decimal Salary { get; set; }

    }
    class Manager : EmployeeBase
    {
        // Managerin altında calışanlar olabilir bu yuzden EmployeeBase List of verdik 
       public LinkedList<EmployeeBase> Subordinates { get; set; }
        public Manager()
        {
            Subordinates = new LinkedList<EmployeeBase>();
        }
        public override void Accept(VisitorBase visitor)
        {
            visitor.visit(this);
            foreach (var employee in Subordinates)
            {
                employee.Accept(visitor);
            }
        }
    }
    class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.visit(this);
        }
    }
   abstract class VisitorBase
    {
        public abstract void visit(Worker worker);
         public abstract void visit(Manager manager);

        
    }
    class PayrolVisitor : VisitorBase
    {
      

        public override void visit(Worker worker)
        {
            Console.WriteLine("  {0} paid {1} " ,worker.Name,worker.Salary );
        }

        public override void visit(Manager manager)
        {
            Console.WriteLine("  {0} paid {1} ", manager.Name, manager.Salary);
        }
    }
    class Payrise : VisitorBase
    {
        public override void visit(Worker worker)
        {
            Console.WriteLine("  {0} Payrise salary increased to {1} ", worker.Name, worker.Salary*(decimal)1.1);
        }

        public override void visit(Manager manager)
        {
            Console.WriteLine("  {0} Payrise salary increased to {1} ", manager.Name, manager.Salary*(decimal)1.2);
        }
    }
}
