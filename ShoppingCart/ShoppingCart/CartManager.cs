using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
  public  class CartManager
    {
        static void Main()
        {
            CartIten cartIten = new CartIten();
            
            Console.ReadKey();
        }
        private readonly List<CartIten> _cartItens;
        public CartManager()
        {
            _cartItens = new List<CartIten>();
        }
        public void Add(CartIten cartIten)
        {
            var addCartIten = _cartItens.SingleOrDefault(t => t.product.ProductId == cartIten.product.ProductId);
            if (addCartIten==null)
            {
                _cartItens.Add(cartIten);

            }
            else
            {
                throw new ArgumentException("This product already been added ");
            }
           
        }
        public void Remove(int prodoctId)
        {
            var product = _cartItens.FirstOrDefault(t => t.product.ProductId == prodoctId);
            _cartItens.Remove(product);
        }
        public List<CartIten> CartItens
        {
            get
            {
                return _cartItens;
            }
        }
        public void Clear()
        {
            _cartItens.Clear();
        }
        public decimal TotalPrice
        {
            get { return _cartItens.Sum(t => t.Quantity*t.product.UnitPrice); }
        }
        public int TotalQuantity
        {
            get { return _cartItens.Sum(t => t.Quantity); }
        }
        public int TotalItems
        {
            get { return _cartItens.Count; }
        }
    }
}

