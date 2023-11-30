using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Learning.Exo2
{
    public class Arc : IArc
    {
        private int _cpt = 0;

        public int Cpt { get { return ++_cpt; } }
    }
}
