using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringContainsTest()
        {
            StringAssert.Contains(" Test Dünya merhaba", "Dünya");
           
        }
        [TestMethod]
        public void StringMatchesTest()
        {
            StringAssert.Matches(" Test Dünya merhaba", new Regex(@"[a-zA-z]"));
            StringAssert.DoesNotMatch(" Test Dünya merhaba", new Regex(@"0-9"));
        }
        [TestMethod]
        public void StartsWithTest()
        {
            StringAssert.StartsWith("Test Dünya merhaba", "Test");
            
        }
        [TestMethod]
        public void EndsWith()
        {
            StringAssert.EndsWith(" Test Dünya merhaba", "merhaba");
           
        }
        
    }
}
