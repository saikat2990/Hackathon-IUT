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
    public class StudentsListsController : Controller
    {
        private readonly UserContext _context;

        public StudentsListsController(UserContext context)
        {
            _context = context;
        }



        // GET: StudentsLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentsLists.ToListAsync());
        }

        // GET: StudentsLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsList = await _context.StudentsLists
                .FirstOrDefaultAsync(m => m.StudentsListId == id);
            if (studentsList == null)
            {
                return NotFound();
            }

            return View(studentsList);
        }

        // GET: StudentsLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentsLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentsListId,studentname,password,completeCourse,DuePoints")] StudentsList studentsList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentsList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentsList);
        }

        // GET: StudentsLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsList = await _context.StudentsLists.FindAsync(id);
            if (studentsList == null)
            {
                return NotFound();
            }
            return View(studentsList);
        }

        // POST: StudentsLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentsListId,studentname,password,completeCourse,DuePoints")] StudentsList studentsList)
        {
            if (id != studentsList.StudentsListId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentsList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentsListExists(studentsList.StudentsListId))
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
            return View(studentsList);
        }

        // GET: StudentsLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsList = await _context.StudentsLists
                .FirstOrDefaultAsync(m => m.StudentsListId == id);
            if (studentsList == null)
            {
                return NotFound();
            }

            return View(studentsList);
        }

        // POST: StudentsLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentsList = await _context.StudentsLists.FindAsync(id);
            _context.StudentsLists.Remove(studentsList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentsListExists(int id)
        {
            return _context.StudentsLists.Any(e => e.StudentsListId == id);
        }
    }
}
