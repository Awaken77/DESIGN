using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    class Leaf : IComponent
    {
        private string _name;
        public Leaf(string name)
        {
            this._name = name;
        }
        public void Operation()
        {
            Console.WriteLine(_name);
        }
    }
}
