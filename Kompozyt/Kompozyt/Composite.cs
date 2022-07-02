using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    class Composite : IComponent
    {
        public List<IComponent> components = new List<IComponent>();

        private string _name;
        public Composite(string name)
        {
            this._name = name;
        }

        public void Operation()
        {
            Console.WriteLine(_name);
            foreach(var component in components)
            {
                component.Operation();
            }    
        }
    }
}
