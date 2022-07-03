using Fabryka_abstrakcyjna.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_abstrakcyjna
{
    class ElegantClothesFactory : IClothesFactory
    {
        public Shirt CreateShirt()
        {
            return new DressShirt();
        }

        public Trousers CreateTrousers()
        {
            return new SuitTrousers();
        }
    }
}
