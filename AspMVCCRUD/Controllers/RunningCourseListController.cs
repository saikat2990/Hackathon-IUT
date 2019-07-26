using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspMVCCRUD.Controllers
{
    public class RunningCourseListController : Controller
    {
        private readonly UserContext _context;
        // GET: RunningCourseList
        public async Task<IActionResult> Index()
        {
            return View(await _context.RunningCoursesLists.ToListAsync());
        }

        // GET: RunningCourseList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RunningCourseList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RunningCourseList/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RunningCourseList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RunningCourseList/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RunningCourseList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RunningCourseList/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}