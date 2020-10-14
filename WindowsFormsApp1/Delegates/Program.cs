using System;

namespace Delegates
{
    //Delege formatı 
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string Text);
    public delegate int MyDelegate3(int number1,int number2);
    class Program
    {
        static void Main(string[] args)
        {
            // burda delege kullanılmadı 
            CustomerManger customerManger = new CustomerManger();
            //customerManger.SendMessage();
            //customerManger.ShowAlert();
            //Delege kullanmak istiyorisek .. Özel bir elçi Delege formatında çalışan bir elçi
            MyDelegate myDelegate = customerManger.SendMessage;
            //Delegate Çağırdığımız zaman çalışır 
            myDelegate += customerManger.ShowAlert;
            myDelegate -= customerManger.ShowAlert;
            myDelegate();
            MyDelegate2 myDelegate2 = customerManger.SendMessage2;
            myDelegate2 += customerManger.SendMessage2;
            myDelegate2("hello mather faucker");

            Matematik matematik =new Matematik();
            MyDelegate3 myDelegate3 = matematik.topla;
            var sonuc = myDelegate3(34, 12);
            Console.WriteLine("1 :{0}\n",sonuc);
            myDelegate3 += matematik.çıkar;
            var sonuc2 =myDelegate3(34, 12);
            Console.WriteLine("2 :{0}",sonuc2);
            Console.ReadLine();
        }
        public class CustomerManger
        {
            public void SendMessage ()
            {
                Console.WriteLine("Hello World!");
            }
            public void ShowAlert()
            {
                Console.WriteLine("Be Careful...!");
            }
            public void SendMessage2(string message)
            {
                Console.WriteLine(message);
            }
            public void ShowAlert2(string alert)
            {
                Console.WriteLine(alert);
            }
          
        }
        public class Matematik
        {
            public int topla(int sayı1, int sayı2)
            {
                return sayı1 + sayı2;
            }
            public int çıkar(int sayı1, int sayı2)
            {
                return sayı1 - sayı2;
            }
        }
    }
}
