using DesignPattern.Learning.Exo2.CanClass;
using DesignPattern.Learning.Exo2.FlyClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Learning.Exo2.Client.Canards
{
    public class Colvert : Canard
    {
        public Colvert()
        {
            CanBehavior = new CanCan();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine(typeof(Colvert).Name);
        }
    }
}
