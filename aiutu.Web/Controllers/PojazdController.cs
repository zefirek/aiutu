using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aiutu.Web.Controllers
{
    public class PojazdController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
