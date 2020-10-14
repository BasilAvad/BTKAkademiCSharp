using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Tests
{
    [TestClass]
    public class GruplauiciTests
    {
        private List<olcum> olcumslistesiolustur(int adet)
        {
            var olcumler = new List<olcum>();
            for (int i = 0; i < adet; i++)
            {
                olcumler.Add(
                new olcum
                {
                    Enyuksek = 10,
                    Endusuk = 1

                });

            }
            return olcumler;
        }
        [TestMethod]
        public void bir_elemanlı_ve_birer_gruplanmak_istendiğinde_grup_sayisi_bir_olmalıdır()
        {
            var olcumler = new List<olcum>() // listem var bir elemanlı ve birer gruplanmak istiyorum 
            {
                new olcum
                {
                    Enyuksek=10,
                    Endusuk=1

                }
            };
            var gruplayici = new Gruplayici(1);
            var gruplar = gruplayici.Grupla(olcumler);
            Assert.AreEqual(1, gruplar.Count);
        }
        [TestMethod]
        public void Altı_elemanlı_liste_ikişerli_gruplanmak_istendiğinde_grup_sayisi_üç_olmalıdır()
        {
            var olcumler = new List<olcum>() // listem var bir elemanlı ve birer gruplanmak istiyorum 
            {
                new olcum
                {
                    Enyuksek=10,
                    Endusuk=1

                },
                new olcum
                {
                    Enyuksek=10,
                    Endusuk=1

                },
                new olcum
                {//4
                    Enyuksek=10,
                    Endusuk=1

                },
                new olcum
                {//3
                    Enyuksek=10,
                    Endusuk=1

                },
                new olcum
                {
                    //2
                    Enyuksek=10,
                    Endusuk=1

                },
                new olcum
                {
                    //1
                    Enyuksek=10,
                    Endusuk=1

                }
            };
            var gruplayici = new Gruplayici(2);
            var gruplar = gruplayici.Grupla(olcumler);
            Assert.AreEqual(3, gruplar.Count);
        }
        [TestMethod]
        public void elli_elemanlı_liste_ikişerli_gruplanmak_istendiğinde_grup_sayisi_beş_olmalıdır()
        {
            var olcumler = olcumslistesiolustur(50); // listem var bir elemanlı ve birer gruplanmak istiyorum 
            var gruplayici = new Gruplayici(10);
            var gruplar = gruplayici.Grupla(olcumler);
            Assert.AreEqual(5, gruplar.Count);
        }
    }
}