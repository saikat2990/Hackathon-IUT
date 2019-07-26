using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspMVCCRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context) {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }
    }
}