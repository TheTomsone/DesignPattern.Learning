using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Learning.Exo2.CanClass
{
    public class AltCan<TFirst, TSecond> : ICan
        where TFirst : ICan
        where TSecond : ICan
    {
        private static int _cpt = 0;
        private TFirst _first;
        private TSecond _second;

        public AltCan(TFirst first, TSecond second)
        {
            _first = first;
            _second = second;
        }

        public void CanCan()
        {
            if (_cpt++ % 2 == 0)
                _first.CanCan();
            else
                _second.CanCan();
        }
    }
}
