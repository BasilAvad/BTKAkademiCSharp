using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Customermanager customermanager = new Customermanager(new LoggerFactyory2());
            customermanager.save();
            Console.ReadLine();
        }
    }
    public class LoggerFactyory: ILoggerFactyory

    {
        public ILogger CeateLogger()
        {
            // Business to decide factoey 
            return new EdLogger();
        }
    }
    public class LoggerFactyory2 : ILoggerFactyory

    {
        public ILogger CeateLogger()
        {
            // Business to decide factoey 
            return new LogfNetLogger();
        }
    }
    public interface ILoggerFactyory
    {
        ILogger CeateLogger();
    }

    public interface ILogger
    {
        void Log();
    }
    public class EdLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine(" Logged with EdLogger");

        }
        
    }

    public class LogfNetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine(" Logged with LogfNetLogger");

        }

    }


    public class Customermanager
    {
     private ILoggerFactyory _loggerFactyory;

        public Customermanager(ILoggerFactyory loggerFactyory)
        {
            _loggerFactyory = loggerFactyory;
        }

        public void save()
        {
            Console.WriteLine(" Saved");
            ILogger logger = _loggerFactyory.CeateLogger();
            logger.Log(); 
        }
    }
}
