using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Learning.Exo2.CanClass
{
    public class BegCan<TSourceCan> : ICan where TSourceCan : ICan
    {
        private TSourceCan _can;

        public BegCan(TSourceCan sourceCan)
        {
            _can = sourceCan;
        }

        public void CanCan()
        {
            _can.CanCan();
            _can.CanCan();
        }
    }
}
