using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public class Gruplayici
    {
        private int _gruoSayisi;

        public Gruplayici(int grupSayisi)
        {
            _gruoSayisi = grupSayisi;
        }

        public List<List<olcum>> Grupla(List<olcum> olcumler)
        {
            var gruplar = new List<List<olcum>>(); // Eleman sayısı 0
            for (int i = 0; i < olcumler.Count; )
            {
                var grup = olcumler.Skip(i).Take(_gruoSayisi).ToList();

                gruplar.Add(grup);// Bir tane eleman ekleyorum

                i += _gruoSayisi;
            }
            
            return gruplar;
        }


    }
}