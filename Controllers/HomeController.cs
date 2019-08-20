using Microsoft.AspNetCore.Mvc;
using ProAspNetCoreMvcModelBinding.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult Index(int id)
        {
            return View("Index", repository[id]);
        }
    }
}
