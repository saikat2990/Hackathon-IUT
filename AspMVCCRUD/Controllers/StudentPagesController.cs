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
    public class StudentPagesController : Controller
    {
        private readonly UserContext _context;

        public StudentPagesController(UserContext context)
        {
            _context = context;
        }

        // GET: StudentPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentPages.ToListAsync());
        }

        // GET: StudentPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentPage = await _context.StudentPages
                .FirstOrDefaultAsync(m => m.Roll == id);
            if (studentPage == null)
            {
                return NotFound();
            }

            return View(studentPage);
        }

        // GET: StudentPages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentPages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Roll,student_name")] StudentPage studentPage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentPage);
        }

        // GET: StudentPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentPage = await _context.StudentPages.FindAsync(id);
            if (studentPage == null)
            {
                return NotFound();
            }
            return View(studentPage);
        }

        // POST: StudentPages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Roll,student_name")] StudentPage studentPage)
        {
            if (id != studentPage.Roll)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentPageExists(studentPage.Roll))
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
            return View(studentPage);
        }

        // GET: StudentPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentPage = await _context.StudentPages
                .FirstOrDefaultAsync(m => m.Roll == id);
            if (studentPage == null)
            {
                return NotFound();
            }

            return View(studentPage);
        }

        // POST: StudentPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentPage = await _context.StudentPages.FindAsync(id);
            _context.StudentPages.Remove(studentPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentPageExists(int id)
        {
            return _context.StudentPages.Any(e => e.Roll == id);
        }
    }
}
