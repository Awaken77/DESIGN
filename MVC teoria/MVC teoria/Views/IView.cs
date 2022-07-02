using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_teoria.Views
{
    public interface IView
    {
        string GenerateView();

        string GenerateView(Models.IModel model);
    }
}
