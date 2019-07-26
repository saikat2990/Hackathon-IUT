using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCCRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspMVCCRUD.Controllers
{
    public class RunningController : Controller
    {
        private readonly UserContext _context;

        public async Task<IActionResult> Index()
        {
            return View(await _context.RunningController.ToListAsync());
        }
    }
}