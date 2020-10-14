using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            CMevzuat aMevzuat = new CMevzuat();
            aMevzuat.Degerlendir();
            aMevzuat.Kaydet();
            Console.ReadLine();
        }
    }
    abstract class MevzuatBase // Sınıf yapısı sahib ortak operasyonlar ve ortak olmayan operasyonlar olabilir
    {
        protected MevzuatBase()
        {

        }
        public abstract void Degerlendir();//Tamamlanmamış
        public virtual void Kaydet()//Tamamlanmış
        {
            Console.WriteLine("Kaydedildi ");
        }
    }
    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A mevzutına gore degerlendirdim ");
        }
    } 
    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B mevzutına gore degerlendirdim ");
        }
    } 
    class CMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("C mevzutına gore degerlendirdim ");
        }
        public override void Kaydet()
        {
            Console.WriteLine("C mevzutına gore degerlendirdim ve kaydetim ");
            base.Kaydet();
        }
       
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine(" Added ");
        } 
        public void Delete()
        {
            Console.WriteLine(" Deleted  ");
        }

    }
}
