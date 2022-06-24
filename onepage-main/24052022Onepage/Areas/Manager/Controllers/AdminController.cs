using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 24052022Onepage.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
