using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        private CartIten _cartIten;
        private CartManager _CartManager;
        [TestInitialize]
        public void TestIinitialize()
        {
             _CartManager = new CartManager();
            _cartIten = new CartIten()
            {
                product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500

                },
                Quantity = 1
            };
            _CartManager.Add(_cartIten);
        }
        
        [TestMethod]
        public void testCleanUp()
        {
            _CartManager.Clear();
        }

        [TestMethod]
        public void Sepeteuruneklenebilmelidir()
        {
            // Arrange
            const int beklenen = 1;
            //Act
           var toplamElemanSayisi =_CartManager.TotalItems;
            //assert
            Assert.AreEqual(beklenen, toplamElemanSayisi); 
        }
        [TestMethod]
        public void Sepeteuruncikarabilmelidir()
        {
            // Arrange
            var sepetteOlanElemanSayisi = _CartManager.TotalItems;
            //Act
            var sepetteKalanElemanSayisi = _CartManager.TotalItems;
            //assert
            Assert.AreEqual(sepetteOlanElemanSayisi, sepetteKalanElemanSayisi); 
        }
        [TestMethod]
        public void Sepettetemizlenebilmelidir()
        {
            // Arrange
            _CartManager.Clear();
            //Act
           
            //assert
            Assert.AreEqual(0, _CartManager.TotalQuantity);
            Assert.AreEqual(0, _CartManager.TotalItems); 
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sepetteayniurundenikikezeklendigindehatavermelidir()
        {
            _CartManager.Add(_cartIten);
        }
    }
}
