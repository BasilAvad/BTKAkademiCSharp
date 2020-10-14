using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void StockControl();
     public class Prodoct
    {
        private int _Stock;

        public Prodoct(int stock)
        {
            _Stock = stock;
        }

        public event StockControl StokControlEvent;
        public string ProductName { get; set; }
        public int Stock { 
            get 
            {
                return _Stock;
            }
            set 
            {
                _Stock = value;
                //Ürün <=15 ve StokControlEvent !=null kullancı bu eventi apone olmuş ise çalıştır
                if (value<=19 && StokControlEvent !=null)
                {
                    StokControlEvent();
                }
            }
        }
        public void Sell(int amount)
        {
            //stock kalan ürünler eksi (Sell) satılan ürünler
            Stock -= amount;
            Console.WriteLine("{1} Stock Amount : {0}",Stock,ProductName);
        }
    }
}
