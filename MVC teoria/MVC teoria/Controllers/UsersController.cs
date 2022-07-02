using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_teoria.Controllers
{
    class UsersController : IController
    {
        public void Display()
        {
            Models.IModel model = new Models.UserModel
            {
                Name = "Jan",
                Surname = "Kowalski",
                Address = new Models.AddressModel
                {
                    Street = "POW 3/5",
                    City = "Łódź",
                    Postal = "90-100"
                }

            };

            Models.IModel model2 = new Models.AddressModel
            {
                Street = "POW 3/5",
                City = "Łódź",
                Postal="90-100"
            };

            Views.IView view = new Views.UserSimpleView();
            Views.IView view2 = new Views.UserComplexView();

            Console.WriteLine(view2.GenerateView(model));



        }
    }
}
