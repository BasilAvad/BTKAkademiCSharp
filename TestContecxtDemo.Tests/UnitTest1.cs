using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestContecxtDemo.Tests
{
    
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("TestInitialize..\n");
            TestContext.WriteLine("Test Ad  : {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu  : {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Durumu  : {0}", TestContext.FullyQualifiedTestClassName); // UnitTest1 class adını bize verir
            TestContext.Properties["bilgi"] = "bu bir ekstra bilgidir"; // Veri saklayabiliriz 
        }
        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("TestCleanup..\n");
            TestContext.WriteLine("Test Ad  : {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu  : {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Durumu  : {0}", TestContext.Properties["bilgi"]); // UnitTest1 class adını bize verir
            Assert.AreEqual(1, 1);
        }



        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("TestMethod...\n");
            TestContext.WriteLine("Test Ad  : {0}",TestContext.TestName);
            TestContext.WriteLine("Test Durumu  : {0}",TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Durumu  : {0}", TestContext.FullyQualifiedTestClassName); // UnitTest1 class adını bize verir
            TestContext.WriteLine("Test Durumu  : {0}", TestContext.Properties["bilgi"]);
        }
    }
}
