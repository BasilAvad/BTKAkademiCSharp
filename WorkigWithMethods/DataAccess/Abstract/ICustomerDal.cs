using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICustomerDal
    {
        void Add(Customer customer);
        bool CustomerExists(Customer customer);
    }
}
