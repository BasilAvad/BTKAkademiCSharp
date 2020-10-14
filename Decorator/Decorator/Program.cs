using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // bireysel arac kiraliyacağımız zaman nesnesi olusturduk 
            var personalcar = new PersonalCar { Make="BMW",Model="2.30",HirPrice=250000};
            SpecialOffer specialOffer = new SpecialOffer(personalcar);
            specialOffer.Discouns = 10;

            Console.WriteLine("Concrete   :{0}", personalcar.HirPrice);
            Console.WriteLine("special Offer  :{0}" , personalcar.HirPrice);
            Console.ReadLine();
           
        }
      
    }
   abstract  class CarBase
   {
            public abstract string Make { get; set; }
            public abstract string Model { get; set; }
            public abstract decimal  HirPrice { get; set; }

    }
    class PersonalCar : CarBase
    {
        public override string Make { get; set ; }
        public override string Model { get ; set  ; }
        public override decimal HirPrice { get ; set ; }
    }
    class CommercialCar : CarBase
    {
        public override string Make { get; set ; }
        public override string Model { get ; set  ; }
        public override decimal HirPrice { get ; set ; }
    }

   abstract class CarDecoratorBase:CarBase
    {
        private CarBase _CarBase;
        protected  CarDecoratorBase(CarBase carBase)
        {
            _CarBase = carBase;
        }
    }
    class SpecialOffer : CarDecoratorBase
    {
        public int Discouns { get; set; }
        private readonly CarBase _carBase;
        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }

        public override string Make { get; set ; }
        public override string Model { get ; set ; }
        public override decimal HirPrice
        {
            get
            {
                return (_carBase.HirPrice - _carBase.HirPrice) * (Discouns/100);
            }
            
            
            set
            {

            }
        }
    }

}
