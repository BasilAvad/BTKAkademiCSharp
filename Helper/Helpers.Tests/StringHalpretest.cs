using Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHalpretest
    {
        [TestMethod]
        public void Girilen_ifadenin_basindaki_ve_sonundaki_bosluklar_silinmelidir()
        {
            //Arange
            var ifade = "    basil avad";
            var beklenen = "basil avad";
            //Act
            var gerceklesen = StringHelper.fazlabosluklarasil(ifade);

            // Assert
            Assert.AreEqual(beklenen, gerceklesen);

        }
        [TestMethod]
        public void Girilen_ifadenin_fazla_bosluklar_silinmelidir()
        {
            //Arange 
            var ifade = "   basil   avad   ahmed    salih ";
            var beklenen = "basil avad ahmed salih";
            //Act
            var gerceklesen = StringHelper.fazlabosluklarasil(ifade);

            // Assert
            Assert.AreEqual(beklenen, gerceklesen);

        }
    }
}
