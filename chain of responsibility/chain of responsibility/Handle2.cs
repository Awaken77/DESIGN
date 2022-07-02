using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibility
{
    class Handle2 : Handler
    {
        private Handler _handler;

        public override void SetHandler(Handler handler)
        {
            _handler = handler;
        }
        public override void HandleRequest(object o)
        {
            if (o.GetType() == typeof(System.Int32))
            {
                Console.WriteLine($"The argument is from type Integer.");
            }
            else
            {
                if (_handler != null)
                {
                    _handler.HandleRequest(o);
                }
                else
                {
                    base.HandleRequest(o);
                }

            }

        }
    }
}
