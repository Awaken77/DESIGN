using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_teoria.Models
{
    class AddressModel : IModel
    {
        public int ID => 2;

        public string Street { get; set; }

        public string City { get; set; }

        public string Postal { get; set; }
    }
}
