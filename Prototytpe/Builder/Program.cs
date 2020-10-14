using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public class Program
    {
        static void Main(string[] args)
        {
            // ProductDirector Çağırmamız lazım program Çalışsın 
            ProductDirector director = new ProductDirector();
            var builder = new OldCustomer();
            director.GenerateProduct(builder);
            builder.GetModel();
            var model = builder.GetModel();
            Console.WriteLine(model.Id);
            Console.WriteLine(model.CategoryName);
            Console.WriteLine(model.Discont);
            Console.WriteLine(model.DiscountApplied);
            Console.WriteLine(model.UnitPrice);

            Console.ReadLine();

          
        }
    }
   public class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal  UnitPrice { get; set; }
        public decimal Discont { get; set; }
        public bool DiscountApplied { get; set; }

    }
    // farklı Producy Builder oluşturulmasını sağlayabiliriz (   abstract  )

  abstract class ProductBuilder
    {
        // bunun içeresinde çeşitli işlemler uygulanabilir örnek :Temel Ürün bilgilere çekilmesi vs Ekleme.....!
        public abstract void GetProductData();

        public abstract void ApplayDiscount();
        public abstract ProductViewModel GetModel();

    }

    class NewCustomer : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplayDiscount()
        {
            // indirim uyguladık 
            model.Discont =model.UnitPrice*(decimal) 0.90;
            model.DiscountApplied = true;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai";
            model.UnitPrice = 20;
        }
    }
    class OldCustomer : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplayDiscount()
        {
            // indirim uyguladık 
            model.Discont = model.UnitPrice;
            model.DiscountApplied = false;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai";
            model.UnitPrice = 20;
        }
    }
     class ProductDirector
    {
        // amacımız burada hangi builder kullanacağımız yolayalım !
        public void GenerateProduct(ProductBuilder productBuilder)
        {
            productBuilder.GetProductData();
            productBuilder.ApplayDiscount();

        }

    }
}
