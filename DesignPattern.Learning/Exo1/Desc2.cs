using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Learning.Exo2
{
    public class Desc2
    {
        private int _mult;
        private readonly IArc _arc;

        public Desc2(int mult)
        {
            _mult = mult;
            _arc = new Arc();
        }

        public int getCpt { get { return _arc.Cpt; } }
        public int Mult { get { return _arc.Cpt * _mult; } }

        public void display()
        {
            Console.WriteLine(Mult);
        }
    }
}
