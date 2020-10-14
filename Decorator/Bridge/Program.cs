//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bridge
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MessageManager messageManager = new MessageManager();
//            messageManager.MessageSender = new EmailSender();
//            messageManager.UpdateCustomer();
//            Console.ReadLine();
//        }

//    }
//    abstract class MessageSender
//    {
//        public void Save()
//        {
//            Console.WriteLine("Saved ....)");

//        }
//        // Degişecek olan kısım 
//        public abstract void Send(Body body );  

//    }
//    class Body
//    {
//        public string Title  { get; set; }
//        public string  Text { get; set; }
//    }
//    class SmsSender : MessageSender
//    {
//        public override void Send(Body body)
//        {
//            Console.WriteLine(" {0}  was sent via Smssender",body.Title);
//        }
//    }
//    class EmailSender : MessageSender
//    {
//        public override void Send(Body body)
//        {
//            Console.WriteLine(" {0}  was sent via EmailSender", body.Title);
//        }
//    }

//    class MessageManager
//    {
//        // Bridge burada 
//        public MessageSender MessageSender { get; set; }
//        public void UpdateCustomer()
//        {
//            //SmsSender smsSender = new SmsSender();
//            //smsSender.Send(new Body());
//            MessageSender.Send(new Body { Title = " Bişo ... " });

//            Console.WriteLine(  " customer update : .... ");
//        }
//    }



//}
using System;

namespace DoFactory.GangOfFour.Bridge.Structural
{
    /// <summary>

    /// MainApp startup class for Structural

    /// Bridge Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>

    /// The 'Abstraction' class

    /// </summary>

    class Abstraction

    {
        protected Implementor implementor;

        // Property

        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    /// <summary>

    /// The 'Implementor' abstract class

    /// </summary>

    abstract class Implementor

    {
        public abstract void Operation();
    }

    /// <summary>

    /// The 'RefinedAbstraction' class

    /// </summary>

    class RefinedAbstraction : Abstraction

    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }

    /// <summary>

    /// The 'ConcreteImplementorA' class

    /// </summary>

    class ConcreteImplementorA : Implementor

    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }

    /// <summary>

    /// The 'ConcreteImplementorB' class

    /// </summary>

    class ConcreteImplementorB : Implementor

    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
