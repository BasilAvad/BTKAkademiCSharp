using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "kullancilar.XML", "kullanci ", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest()
        {
            var manger = new ProductManager();
            var da = TestContext.DataRow["ad"].ToString();
            var telefon = TestContext.DataRow["telefon"].ToString();
            var mail = TestContext.DataRow["mail"].ToString();
            



            var sonuc = manger.kullanciEkle(da, telefon, mail);
            Assert.IsTrue(sonuc);
        }
    }
}
