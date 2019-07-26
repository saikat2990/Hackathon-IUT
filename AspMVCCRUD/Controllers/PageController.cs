using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspMVCCRUD.Controllers
{
    public class PageController : Controller
    {
        public IActionResult StudentPage()
        {
            return View();
        }
    }
}