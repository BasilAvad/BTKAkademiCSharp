using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
       
        private List<string> _kullancılar;
        [TestInitialize]
        public void DataOlustur()
        {
            _kullancılar = new List<string>();
            _kullancılar.Add("Basil"); 
            _kullancılar.Add("Ahmed");
            _kullancılar.Add("Avad");
        }
        [TestMethod]
        public void elemanlarvesırasıaynıolmalıdır()
        {
            List<string> yenikulancilar = new List<string>();
            yenikulancilar.Add("Basil");
            yenikulancilar.Add("Ahmed");
            yenikulancilar.Add("Avad");
            CollectionAssert.AreEqual(_kullancılar, yenikulancilar); // Elemanlar sırası ve Degerleri ayni olmalidir .
        }
        [TestMethod]
        public void elemanlaraynifakarsirasifarkli()
        {
            List<string> yenikulancilar = new List<string>();
            yenikulancilar.Add("Basil");
            yenikulancilar.Add("Ahmed");
            yenikulancilar.Add("Avad");
            CollectionAssert.AreEquivalent(_kullancılar, yenikulancilar);
        }
        [TestMethod]
        public void elemanlarvesırasıaynıolmamalıdır()
        {
            List<string> yenikulancilar = new List<string>();
            yenikulancilar.Add("Avad");
            yenikulancilar.Add("Ahmed");
            yenikulancilar.Add("Basil");
            CollectionAssert.AreNotEqual(_kullancılar, yenikulancilar); // Elemanlar sırası ve Degerleri ayni olmamalidir .
        }
        [TestMethod]
        public void elemanlarfarklıolmalıdır()
        {
            List<string> yenikulancilar = new List<string>();
            yenikulancilar.Add("Basil");
            yenikulancilar.Add("Ahmed");
            yenikulancilar.Add("Khalid ");
            CollectionAssert.AreNotEquivalent(_kullancılar, yenikulancilar); // Elemanlar sırası ve Degerleri ayni olmamalidir .
        }
        [TestMethod]
        public void kullancılar_null_degeri_almamalıdır()
        {
            //_kullancılar.Add(null); hatalı is Not Null
            CollectionAssert.AllItemsAreNotNull(_kullancılar); 
        }
        [TestMethod]
        public void kullancılar_benzersiz_almalıdır()
        {
            _kullancılar.Add("Basil"); // burada hata
            CollectionAssert.AllItemsAreUnique(_kullancılar); 
        }
        [TestMethod]
        public void tum_elemanlar_aynı_tipte_olmalıdır()
        {
            ArrayList list = new ArrayList
            {
                "Basil","Ahmed","Avad",5  // 5 ekledıgımde hata virir sadece  string elemanlar eklenir
            };
            CollectionAssert.AllItemsAreInstancesOfType(list,typeof(string)); 
        }
    }
}
