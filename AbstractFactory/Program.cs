using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Factory2());
            productManager.GetAll();
            Console.ReadLine();
        }
    }
    public abstract class Logging
    {
        public abstract void Log(string message);

    }
    public class Logg4netLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine(" Logged with log4Net");
        }
    }

    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine(" Logged with nlogger");
        }
    }
    public abstract class Caching
    {
        public abstract void cach(string data);
    }
    public class Namecache : Caching
    {
        public override void cach(string data)
        {
            Console.WriteLine(" cached with namecache");
        }
    }

    public class RedisCacheRedisCache : Caching
    {
        public override void cach(string data)
        {
            Console.WriteLine(" cached with RedisCache");
        }
    }
    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CeateLogger();
        public abstract Caching CeateCaching();
    }
    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Caching CeateCaching()
        {
            return new RedisCacheRedisCache();
        }

        public override Logging CeateLogger()
        {
             return new Logg4netLogger();
        }
    }

    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Caching CeateCaching()
        {
            return new RedisCacheRedisCache();
        }

        public override Logging CeateLogger()
        {
            return new NLogger();
        }
    }

    public class ProductManager
    {
        CrossCuttingConcernsFactory _crossCuttingConcernsFactory;

        Logging _logging;
        Caching _caching;

        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = _crossCuttingConcernsFactory.CeateLogger();
            _caching = _crossCuttingConcernsFactory.CeateCaching();
        }

        public void GetAll()
        {
            _logging.Log("Logged");
            _caching.cach("Data");
            Console.WriteLine(" products listsd");
        }
    }
}

