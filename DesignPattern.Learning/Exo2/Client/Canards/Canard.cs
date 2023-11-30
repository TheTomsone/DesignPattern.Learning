using DesignPattern.Learning.Exo2.CanClass;
using DesignPattern.Learning.Exo2.FlyClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Learning.Exo2.Client.Canards
{
    public abstract class Canard
    {
        private ICan _canBehavior;
        private IFly _flyBehavior;

        public ICan CanBehavior
        {
            set { _canBehavior = value; }
        }
        public IFly FlyBehavior
        {
            set { _flyBehavior = value; }
        }

        public abstract void Display();
        public void Swim()
        {
            Console.WriteLine("Canard is swimming");
        }
        public void ExecuteCanCan()
        {
            _canBehavior.CanCan();
        }
        public void ExecuteFly()
        {
            _flyBehavior.Fly();
        }

    }
}
