using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_abstrakcyjna
{
    public interface IClothesFactory
    {
        Shirt CreateShirt();
        Trousers CreateTrousers();
    }
}
