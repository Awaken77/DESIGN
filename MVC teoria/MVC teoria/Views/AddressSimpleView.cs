using MVC_teoria.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_teoria.Views
{
    class AddressSimpleView : IView
    {
        public string GenerateView()
        {
            throw new NotImplementedException();
        }

        public string GenerateView(IModel model)
        {
            if(model != null || model.GetType() == typeof(AddressModel))
            {
                throw new WrongModelException();
            }

            var address = (AddressModel)model;

            var template = string.Format("Adres: {0}, {1} {2}", address.Street, address.Postal, address.City);

            return template;
        }
    }
}
