using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:ICustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Entity Framework kullanarak veritabanına eklendi");
        }
        public bool  CustomerExists(Customer customer)
        {
            return true;
        }
    }
}
