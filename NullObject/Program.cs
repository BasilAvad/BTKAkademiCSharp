using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            cUSTOMERmANAGER cUSTOMERmANAGER = new cUSTOMERmANAGER(StubLogger.GetLogger());
            cUSTOMERmANAGER.Saved();
            Console.ReadLine();
        }
    }
    class cUSTOMERmANAGER
    {
        private Ilogeer _ılgeer;

        public cUSTOMERmANAGER(Ilogeer ılgeer)
        {
            _ılgeer = ılgeer;
        }
        public void Saved()
        {
            Console.WriteLine(" Saved  ");
            _ılgeer.lOG(); 
        }
    }
    interface Ilogeer
    {
        void lOG();
    }
    class lOG4nETlOGGER : Ilogeer
    {
        public void lOG()
        {
            Console.WriteLine(" Logged with Log4Net ");
        }
    }
    class NLogLogger : Ilogeer
    {
        public void lOG()
        {
            Console.WriteLine(" Logged with NLogLogger ");
        }
    }
    class StubLogger : Ilogeer
    {
        private static StubLogger _stubLogger;
        private static object _lock = new object();
        private StubLogger()
        {

        }
        public static StubLogger GetLogger()
        {
            lock (_lock)
            {
                if (_stubLogger==null)
                {
                    _stubLogger = new StubLogger();
                }
            }
            return _stubLogger;
        }
        public void lOG()
        {
            
        }
    }
    class CustomerManagerTest
    {
        public void Test()
        {
            cUSTOMERmANAGER cUSTOMERmANAGER = new cUSTOMERmANAGER(StubLogger.GetLogger());
            cUSTOMERmANAGER.Saved();


        }
    }
}
