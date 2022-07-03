using Fabryka_abstrakcyjna.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_abstrakcyjna
{
    class CasualClothesFactory : IClothesFactory
    {
        public Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        public Trousers CreateTrousers()
        {
            return new Jeans();
        }
    }
}
