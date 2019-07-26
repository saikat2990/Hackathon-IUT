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
    public class TeachersListsController : Controller
    {
        private readonly UserContext _context;

        public TeachersListsController(UserContext context)
        {
            _context = context;
        }

        // GET: TeachersLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeachersLists.ToListAsync());
        }

        // GET: TeachersLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachersList = await _context.TeachersLists
                .FirstOrDefaultAsync(m => m.TeachersListId == id);
            if (teachersList == null)
            {
                return NotFound();
            }

            return View(teachersList);
        }

        // GET: TeachersLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeachersLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeachersListId,trainername,password,completeCourse,RemainPoints")] TeachersList teachersList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teachersList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teachersList);
        }

        // GET: TeachersLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachersList = await _context.TeachersLists.FindAsync(id);
            if (teachersList == null)
            {
                return NotFound();
            }
            return View(teachersList);
        }

        // POST: TeachersLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeachersListId,trainername,password,completeCourse,RemainPoints")] TeachersList teachersList)
        {
            if (id != teachersList.TeachersListId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teachersList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeachersListExists(teachersList.TeachersListId))
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
            return View(teachersList);
        }

        // GET: TeachersLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachersList = await _context.TeachersLists
                .FirstOrDefaultAsync(m => m.TeachersListId == id);
            if (teachersList == null)
            {
                return NotFound();
            }

            return View(teachersList);
        }

        // POST: TeachersLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teachersList = await _context.TeachersLists.FindAsync(id);
            _context.TeachersLists.Remove(teachersList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeachersListExists(int id)
        {
            return _context.TeachersLists.Any(e => e.TeachersListId == id);
        }
    }
}
