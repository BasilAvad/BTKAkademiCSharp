using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class Program
    {
        

        static void Main(string[] args)
        {
           IKernel kernel = new StandardKernel();
            kernel.Bind<IProductDal>().To<NhProductDal>().InSingletonScope(); 


            ProductManager productManager = new ProductManager(kernel.Get<IProductDal>());
            productManager.Save();
            Console.ReadLine();
        }
    }

    interface IProductDal
    {
        void Save();
    }
    class EfProductDal:IProductDal
    {
            private IProductDal _productDal;

        public void Save()
        {
            Console.WriteLine(" Savad with Ef ");
        }
    }
    class NhProductDal:IProductDal
    {
            private IProductDal _productDal;

        public void Save()
        {
            Console.WriteLine(" Savad with Nh ");
        }
    }
    class ProductManager
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            
            _productDal = productDal;
        }

        public void Save()
        {
            
            _productDal.Save();
           
        }
    }
}
