using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Learning.Exo2
{
    public class Desc1
    {
        private string _name;
        private readonly IArc _arc;

        public Desc1(string name)
        {
            _name = name;
            _arc = new Arc();
        }

        public int getCpt { get {  return _arc.Cpt; } }
        public string Name { get { return _name + $" : {_arc.Cpt}"; } }

        public void display()
        {
            Console.WriteLine(Name);
        }
    }
}
