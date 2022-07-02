using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator
{
    public sealed class Hyundai : ICar
    {
        public string Make
        {
            get { return "Hatchback"; }
        }
        public double GetPrice()
        {
            return 80000;
        }
    }
}
