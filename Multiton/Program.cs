using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiton
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera camera11 = Camera.GetCamera("NIKon"); 
            Camera camera1 = Camera.GetCamera("Canon");  
            Camera camera2= Camera.GetCamera("NIKon"); 
            Camera camera3= Camera.GetCamera("Canon"); 
            Camera camera4= Camera.GetCamera("NIKon");

            Console.WriteLine(camera11.Id);
            Console.WriteLine(camera1.Id);
            Console.WriteLine(camera2.Id);
            Console.WriteLine(camera3.Id);
            Console.WriteLine(camera4.Id);
            Console.ReadLine();

        }
    }
    class Camera /// Multiton 
    {
        static Dictionary<string, Camera> _camera = new Dictionary<string, Camera>();
        static object _lock = new object();
        public Guid Id { get; set; }
        private Camera()
        {
            Id = Guid.NewGuid();
        }
        public static Camera GetCamera(string brand)
        {
            lock (_lock)
            {
                if (!_camera.ContainsKey(brand))
                {
                    _camera.Add(brand, new Camera());
                }
            }
            return _camera[brand];
        }
    }
}
