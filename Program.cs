using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // Tasarım Desinlerindden bir tanesi { Prototype   النموذج المبدئي, Builder, Facade ,Adapter محول .....vs 
    // farklı sistemlerin kende sistemimize entegre edilmesi drmunda kendiv sistemimize mbozulmadan.....
    // .....farklı sıstemin sanki bizim sistemimizmiş gibi davranmasını saglamaktır kısaca  
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Log4NetAdapter());
            productManager.Save();
            Console.ReadLine();
        }
        // Şoyle duşunun disardaki bir servise kendi projeme dahil etmek istyom
        // kimlik paylasım sistemi gibi Türkyede kullanılan 
    }
    class ProductManager   // مدير الإنتاج
    {
        private ILogger _logger;
        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.Log("User Data ");
            Console.WriteLine("saved");
        }
    }
    interface ILogger
    {
        void Log(string Message);
    }
    class EdLogger : ILogger
    {
        public void Log(string Message)
        {
            Console.WriteLine("  logged,{0}", Message);
        }
    }
    // bir tane FrameWork ekleyelim bir şeyden kurtukmak için brojem yazdıktan sonra kod güncelemesinden <=
    // "Log Fornet " geçmek istiyoruz mesela


    // Nuget'tin inderdeğimiz var sayılalım yani bu clas baskası yazmış çunku 
    class Log4Net
    {
        public void LogMessage(string Message)
        {
            Console.WriteLine("logged with Log4Net, {0} ", Message);
        }
    }
    // bir adabtor imblementasyonu gerçekleştirmiş olduk burada .
    class Log4NetAdapter : ILogger
    {
        public void Log(string Message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.LogMessage(Message);
        }
    }
}
