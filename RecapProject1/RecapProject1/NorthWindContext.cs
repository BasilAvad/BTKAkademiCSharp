using RecapProject1.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject1
{
    public class NorthWindContext: DbContext
    {
        //بشكل عام لدي منتج وهذا المنتج يطهر في قاعدة بياناتي بقسم المنتوجات
        public DbSet<Product> products { get; set; }
        public DbSet <Category> categories { get; set; }

    }
}
