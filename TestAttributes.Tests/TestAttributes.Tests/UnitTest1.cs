using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAttributes.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod,Ignore] // Ignore testmethod1 yok say demek
        [Owner(" BASİL")] // TestMethod hahibi belirler 
        [TestCategory("TeSTLEr")]
        [TestCategory("Developer")]
        
        [Priority(1)] // Öncelik sirasına göre guroblamak için
        [TestProperty("Güncelle", "Engin")]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        [Owner(" BASİL")]
        [TestCategory("TeSTLEr")]
        [Priority(1)]
        [TestProperty("Güncelle", "Engin")]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod,Timeout(1700)] // eger testmethod3 1 sanye üzerinde çilarsa Timeout çalişsin
        [Owner(" BASİL")]
        [TestCategory("Developer")]
        [Priority(1)]
        public void TestMethod3()
        {
            Thread.Sleep(1500);
            Assert.AreEqual(1, 1);
        }
         [TestMethod, Timeout(TestTimeout.Infinite)]
        [Owner(" Engin")]
        [TestCategory("Developer")]
        [Priority(2)]
       
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod, Description("bu bir karekok tewsti yapan metotdur ")]
        [Owner(" Engin")]
        [TestCategory("Developer")]
        [Priority(3)]
        //[Description("bu bir karekok tewsti yapan metotdur ")] //Açiklama girmek istediğimizde bu kullanılır
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
        
    }
}
