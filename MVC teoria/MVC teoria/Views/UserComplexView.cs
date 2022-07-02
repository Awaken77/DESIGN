using MVC_teoria.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_teoria.Views
{
    class UserComplexView : IView
    {
        public string GenerateView()
        {
            throw new NotImplementedException();
        }

        public string GenerateView(IModel model)
        {
            if (model == null || model.GetType() != typeof(UserModel))
            {
                throw new WrongModelException();
            }

            var user = (UserModel)model;

            var template = string.Format("Name:{0}, Surname:{1}, Address:{2},{3} {4}", user.Name, user.Surname, user.Address?.Street, user.Address?.Postal, user.Address?.City).Trim();

            return template;
                
                
                
                
        }
    }
}
