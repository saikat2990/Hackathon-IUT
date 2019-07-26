using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspMVCCRUD.Models;

namespace AspMVCCRUD.Controllers
{
    public class runningCoursesController : Controller
    {
        private readonly UserContext _context;

        public runningCoursesController(UserContext context)
        {
            _context = context;
        }

        // GET: runningCourses
        public async Task<IActionResult> Index()
        {
            return View(await _context.runningCourses.ToListAsync());
        }

        // GET: runningCourses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var runningCourse = await _context.runningCourses
                .FirstOrDefaultAsync(m => m.runningCourseId == id);
            if (runningCourse == null)
            {
                return NotFound();
            }

            return View(runningCourse);
        }

        // GET: runningCourses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: runningCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("runningCourseId,TrainerName,price,numberOfStudents,numberOfClasses")] runningCourse runningCourse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(runningCourse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(runningCourse);
        }

        // GET: runningCourses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var runningCourse = await _context.runningCourses.FindAsync(id);
            if (runningCourse == null)
            {
                return NotFound();
            }
            return View(runningCourse);
        }

        // POST: runningCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("runningCourseId,TrainerName,price,numberOfStudents,numberOfClasses")] runningCourse runningCourse)
        {
            if (id != runningCourse.runningCourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(runningCourse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!runningCourseExists(runningCourse.runningCourseId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(runningCourse);
        }

        // GET: runningCourses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var runningCourse = await _context.runningCourses
                .FirstOrDefaultAsync(m => m.runningCourseId == id);
            if (runningCourse == null)
            {
                return NotFound();
            }

            return View(runningCourse);
        }

        // POST: runningCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var runningCourse = await _context.runningCourses.FindAsync(id);
            _context.runningCourses.Remove(runningCourse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool runningCourseExists(int id)
        {
            return _context.runningCourses.Any(e => e.runningCourseId == id);
        }
    }
}
