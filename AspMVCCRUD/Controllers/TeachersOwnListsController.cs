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
    public class TeachersOwnListsController : Controller
    {
        private readonly UserContext _context;

        public TeachersOwnListsController(UserContext context)
        {
            _context = context;
        }

        // GET: TeachersOwnLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeachersOwnLists.ToListAsync());
        }

        // GET: TeachersOwnLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachersOwnList = await _context.TeachersOwnLists
                .FirstOrDefaultAsync(m => m.TeachersOwnListId == id);
            if (teachersOwnList == null)
            {
                return NotFound();
            }

            return View(teachersOwnList);
        }

        // GET: TeachersOwnLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeachersOwnLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeachersOwnListId,courseId,completeCourse,PointPerCourses,NumberofClassPerCourses,NumberofDoneClassPerCourses,PickUpAmmount")] TeachersOwnList teachersOwnList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teachersOwnList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teachersOwnList);
        }

        // GET: TeachersOwnLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachersOwnList = await _context.TeachersOwnLists.FindAsync(id);
            if (teachersOwnList == null)
            {
                return NotFound();
            }
            return View(teachersOwnList);
        }

        // POST: TeachersOwnLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeachersOwnListId,courseId,completeCourse,PointPerCourses,NumberofClassPerCourses,NumberofDoneClassPerCourses,PickUpAmmount")] TeachersOwnList teachersOwnList)
        {
            if (id != teachersOwnList.TeachersOwnListId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teachersOwnList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeachersOwnListExists(teachersOwnList.TeachersOwnListId))
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
            return View(teachersOwnList);
        }

        // GET: TeachersOwnLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachersOwnList = await _context.TeachersOwnLists
                .FirstOrDefaultAsync(m => m.TeachersOwnListId == id);
            if (teachersOwnList == null)
            {
                return NotFound();
            }

            return View(teachersOwnList);
        }

        // POST: TeachersOwnLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teachersOwnList = await _context.TeachersOwnLists.FindAsync(id);
            _context.TeachersOwnLists.Remove(teachersOwnList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeachersOwnListExists(int id)
        {
            return _context.TeachersOwnLists.Any(e => e.TeachersOwnListId == id);
        }
    }
}
