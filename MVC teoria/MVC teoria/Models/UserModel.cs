using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_teoria.Models
{
    class UserModel : IModel
    {
        public int ID => 1;

        public string Name { get; set; }

        public string Surname { get; set; }

        public AddressModel Address { get; set; }
    }
}
