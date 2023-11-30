using DesignPattern.Learning.Exo2.Client.Canards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Learning.Exo2.Client
{
    public class Animal<TModel> : IAnimal where TModel : Canard
    {
        private TModel _model;

        public Animal(TModel model)
        {
            _model = model;
        }
        public void Run()
        {
            _model.ExecuteFly();
        }

        public void Scream()
        {
            _model.ExecuteCanCan();
        }
    }
}
