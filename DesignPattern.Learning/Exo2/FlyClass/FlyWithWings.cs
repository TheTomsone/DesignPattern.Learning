using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Learning.Exo2.FlyClass
{
    public class FlyWithWings : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Flap flap flap flap !");
        }
    }
}
