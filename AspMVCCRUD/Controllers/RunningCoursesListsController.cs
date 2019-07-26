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
    public class RunningCoursesListsController : Controller
    {
        private readonly UserContext _context;

        public RunningCoursesListsController(UserContext context)
        {
            _context = context;
        }

        // GET: RunningCoursesLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.RunningCoursesLists.ToListAsync());
        }

        // GET: RunningCoursesLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var runningCoursesList = await _context.RunningCoursesLists
                .FirstOrDefaultAsync(m => m.RunningCoursesListId == id);
            if (runningCoursesList == null)
            {
                return NotFound();
            }

            return View(runningCoursesList);
        }

        // GET: RunningCoursesLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RunningCoursesLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RunningCoursesListId,trainerId,CourseId,TrainerName")] RunningCoursesList runningCoursesList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(runningCoursesList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(runningCoursesList);
        }

        // GET: RunningCoursesLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var runningCoursesList = await _context.RunningCoursesLists.FindAsync(id);
            if (runningCoursesList == null)
            {
                return NotFound();
            }
            return View(runningCoursesList);
        }

        // POST: RunningCoursesLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RunningCoursesListId,trainerId,CourseId,TrainerName")] RunningCoursesList runningCoursesList)
        {
            if (id != runningCoursesList.RunningCoursesListId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(runningCoursesList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RunningCoursesListExists(runningCoursesList.RunningCoursesListId))
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
            return View(runningCoursesList);
        }

        // GET: RunningCoursesLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var runningCoursesList = await _context.RunningCoursesLists
                .FirstOrDefaultAsync(m => m.RunningCoursesListId == id);
            if (runningCoursesList == null)
            {
                return NotFound();
            }

            return View(runningCoursesList);
        }

        // POST: RunningCoursesLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var runningCoursesList = await _context.RunningCoursesLists.FindAsync(id);
            _context.RunningCoursesLists.Remove(runningCoursesList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RunningCoursesListExists(int id)
        {
            return _context.RunningCoursesLists.Any(e => e.RunningCoursesListId == id);
        }
    }
}
