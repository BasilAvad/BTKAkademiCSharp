using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Şoyle düşünün bir şirketteyiz ve harcamalar yapıyoz ve bu harcamalar 100 liranın altınad ise normal
    /// mödürümüz harcamaya etki verebiliyor değilse 100 üzerindeyse ozaman baskan yardımcısı onay versin 
    /// 1000 üzerindeki bütün harcamalar da Baskan onay verir 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            VicePresident vicePresident = new VicePresident();
            President president = new President();
            manager.Setsuccessor(vicePresident);
            vicePresident.Setsuccessor(president);
            Expense expense = new Expense { Detail = "Trating ", Amount = 2000 };
            manager.HandleExpense(expense);
            Console.ReadLine();
        }
    }
    class Expense
    {
        public string  Detail { get; set; }      // harcamanın detayi
        public decimal  Amount { get; set; }        // harcamanın tutarı 

    }
   abstract class ExpenseHandlerBase 
    {
      protected ExpenseHandlerBase _successor;
        public abstract void HandleExpense(Expense expense); // harcama onayı yapma süreci 

        public void Setsuccessor(ExpenseHandlerBase expenseHandlerBase) // الحد المسموحا للمصاريف 
        {
            _successor = expenseHandlerBase;
        }
    }

    class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount<=100)
            {
                Console.WriteLine(" manager handled the expense");
            }
            else if(_successor !=null)
            {
                _successor.HandleExpense(expense);
            }
        }
    }
    class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount<=1000)
            {
                Console.WriteLine(" Vice Presidentr handled the expense");
            }
            else if (_successor != null)
            {
                _successor.HandleExpense(expense);
            }
        }
    }

    class President : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000 )
            {
                Console.WriteLine("  Presidentr handled the expense");
            }
            //else if (_successor != null)
            //{
            //    _successor.HandleExpense(expense);
            //}
        }
    }

}
