using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibility
{
    abstract class Handler
    {
        public abstract void SetHandler(Handler handler);

        public virtual void HandleRequest(Object o)
        {
            Console.WriteLine($"The request cannot be handled.");
        }
    }

}
