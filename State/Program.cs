using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            ModifiedState modified = new ModifiedState();
            modified.DoAction(context);

            DeletState delet = new DeletState();
            delet.DoAction(context);
            Console.WriteLine(context.GetState().ToString());

            Console.ReadLine();
        }
    }
    interface IState
    {
        void DoAction(Context context);
    }
    class ModifiedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State:  Modifide");
            context.SetSate(this);
        }

        public override string ToString()
        {
            return "Modifide";
        }
    }
    class DeletState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State:  DeletState");
            context.SetSate(this);
        }
        public override string ToString()
        {
            return "Modifide";
        }
    }
    class AddedtState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State:   Added");
            context.SetSate(this);
        }
        public override string ToString()
        {
            return "Modifide";
        }
    }
    class Context
    {

       private IState _state;
        public void SetSate(IState state)
        {
            _state = state;
        }
        public IState GetState()
        {
            return _state;
        }
    }
}
