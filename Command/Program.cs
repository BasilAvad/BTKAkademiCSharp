//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Command // Çok Çok ÇOkçOk Önemli Robot programlamada 
//{
//    class Program // spariş takib sistemi 
//    {
//        static void Main(string[] args)
//        {
//            StockManager stockManager = new StockManager();
//            BuyStock buyStock = new BuyStock(stockManager);
//            SellStock sellStock = new SellStock(stockManager);
//            StockController stockController = new StockController();

//            stockController.TakeOrder(buyStock);  
//            stockController.TakeOrder(sellStock);
//            stockController.TakeOrder(buyStock);
//            stockController.PlaceOrder();

//            Console.ReadLine();

//        }
//    }
//    class StockManager
//    {
//        private string _name = "Laptop";
//        private int _quantity = 30;

//        public void Buy()
//        {
//            Console.WriteLine(" Stock : {0} ,{1} bought! ",_name,_quantity);
//            //if (_quantity==null)
//            //{
//            //    Console.WriteLine(" Quantity : ",_quantity-=_quantity);
//            //}
//            //else
//            //{
//            //    Console.WriteLine(" dejngvunv .................");
//            //}
//        }
//        public void Sell()
//        {
//            Console.WriteLine(" Stock : {0} ,{1} bought! ", _name, _quantity);
//        }
//    }
//    interface IOrder
//    {
//        void Execute(); // butun komutlar calıstırılması saglıyacak komut 
//    }
//    /// <summary>
//    /// Robot programlamada Dönme komutu ilere gitme vs ... zıblama 
//    /// </summary>
//    class BuyStock : IOrder
//    {
//        private StockManager _stockManager;

//        public BuyStock(StockManager stockManager)
//        {
//            _stockManager = stockManager;
//        }

//        public void Execute()
//        {
//            _stockManager.Buy();
//        }
//    } 
//    class SellStock : IOrder
//    {
//         private StockManager _stockManager;

//        public SellStock(StockManager stockManager)
//        {
//            _stockManager = stockManager;
//        }
//        public void Execute()
//        {
//            _stockManager.Sell();
//        }
//    }
//    // komutlar toplayacak nesne 
//    class StockController
//    {
//        // ve burada komut listesi ihtiyac var
//        List<IOrder> _orders = new List<IOrder>();
//        public void TakeOrder( IOrder order)
//        {
//            _orders.Add(order);
//        }
//        public void PlaceOrder()
//        {
//            foreach (var order in _orders)
//            {
//                order.Execute();

//            }
//            _orders.Clear();
//        }

//    }
//}
using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Command.RealWorld
{
    /// <summary>

    /// MainApp startup class for Real-World 

    /// Command Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Create user and let her compute

            User user = new User();

            // User presses calculator buttons

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands

            user.Undo(4);

            // Redo 3 commands

            user.Redo(3);

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>

    /// The 'Command' abstract class

    /// </summary>

    abstract class Command

    {
        public abstract void Execute();
        public abstract void UnExecute();
    }

    /// <summary>

    /// The 'ConcreteCommand' class

    /// </summary>

    class CalculatorCommand : Command

    {
        private char _operator;
        private int _operand;
        private Calculator _calculator;

        // Constructor

        public CalculatorCommand(Calculator calculator,
          char @operator, int operand)
        {
            this._calculator = calculator;
            this._operator = @operator;
            this._operand = operand;
        }

        // Gets operator

        public char Operator
        {
            set { _operator = value; }
        }

        // Get operand

        public int Operand
        {
            set { _operand = value; }
        }

        // Execute new command

        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        // Unexecute last command

        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        // Returns opposite operator for given operator

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default:
                    throw new

            ArgumentException("@operator");
            }
        }
    }

    /// <summary>

    /// The 'Receiver' class

    /// </summary>

    class Calculator

    {
        private int _curr = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }
            Console.WriteLine(
              "Current value = {0,3} (following {1} {2})",
              _curr, @operator, operand);
        }
    }

    /// <summary>

    /// The 'Invoker' class

    /// </summary>

    class User

    {
        // Initializers

        private Calculator _calculator = new Calculator();
        private List<Command> _commands = new List<Command>();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            // Perform redo operations

            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    Command command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            // Perform undo operations

            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    Command command = _commands[--_current] as Command;
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it

            Command command = new CalculatorCommand(
              _calculator, @operator, operand);
            command.Execute();

            // Add command to undo list

            _commands.Add(command);
            _current++;
        }
    }
}
