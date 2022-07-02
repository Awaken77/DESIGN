using Fabryka_abstrakcyjna.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_abstrakcyjna
{
    class CasualClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new Jeans();
        }
    }
}
