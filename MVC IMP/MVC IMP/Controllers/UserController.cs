using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_IMP.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var model = new Models.UserModel
            {
                Name = "Andrzej",
                Surname = "Fogiel",
                Address = "POW 3/5, 90-100 Łódź"
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            var model = new Models.UserModel
            {
                Name = "Andrzej",
                Surname = "Fogiel",
                Address = "POW 3/5, 90-100 Łódź"
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Models.UserModel model)
        {
            return View(model);
        }
    }
}
