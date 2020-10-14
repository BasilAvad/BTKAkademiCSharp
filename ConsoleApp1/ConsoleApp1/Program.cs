using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = new string[3] { "basil ", "avad", "ahmed" };
            student[2] = "avad";
            Console.WriteLine(student[0]);
            Console.Read();


        }
    }
}
