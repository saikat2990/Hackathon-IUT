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
    public class CourseTables1Controller : Controller
    {
        private readonly UserContext _context;

        public CourseTables1Controller(UserContext context)
        {
            _context = context;
        }

        // GET: CourseTables1
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourseTables.ToListAsync());
        }

        // GET: CourseTables1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseTable = await _context.CourseTables
                .FirstOrDefaultAsync(m => m.courseId == id);
            if (courseTable == null)
            {
                return NotFound();
            }

            return View(courseTable);
        }

        // GET: CourseTables1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourseTables1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("courseId,coursename,coursetype")] CourseTable courseTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseTable);
        }

        // GET: CourseTables1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseTable = await _context.CourseTables.FindAsync(id);
            if (courseTable == null)
            {
                return NotFound();
            }
            return View(courseTable);
        }

        // POST: CourseTables1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("courseId,coursename,coursetype")] CourseTable courseTable)
        {
            if (id != courseTable.courseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseTableExists(courseTable.courseId))
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
            return View(courseTable);
        }

        // GET: CourseTables1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseTable = await _context.CourseTables
                .FirstOrDefaultAsync(m => m.courseId == id);
            if (courseTable == null)
            {
                return NotFound();
            }

            return View(courseTable);
        }

        // POST: CourseTables1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseTable = await _context.CourseTables.FindAsync(id);
            _context.CourseTables.Remove(courseTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseTableExists(int id)
        {
            return _context.CourseTables.Any(e => e.courseId == id);
        }
    }
}
