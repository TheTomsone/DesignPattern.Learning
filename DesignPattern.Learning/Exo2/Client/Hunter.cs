using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Learning.Exo2.Client
{
    public class Hunter
    {
        public void Scope(IAnimal animal)
        {
            Console.WriteLine("PANNNNN !");
            animal.Scream();
            animal.Run();
        }
    }
}
