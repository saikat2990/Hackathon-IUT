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
    public class UserRunningCoursesInfoesController : Controller
    {
        private readonly UserContext _context;

        public UserRunningCoursesInfoesController(UserContext context)
        {
            _context = context;
        }

        // GET: UserRunningCoursesInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserRunningCoursesInfos.ToListAsync());
        }

        // GET: UserRunningCoursesInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRunningCoursesInfo = await _context.UserRunningCoursesInfos
                .FirstOrDefaultAsync(m => m.UserRunningCoursesInfoId == id);
            if (userRunningCoursesInfo == null)
            {
                return NotFound();
            }

            return View(userRunningCoursesInfo);
        }

        // GET: UserRunningCoursesInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserRunningCoursesInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserRunningCoursesInfoId,courseId,TrainerName,CourseName,CompleteClasses,remainingPoints")] UserRunningCoursesInfo userRunningCoursesInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRunningCoursesInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userRunningCoursesInfo);
        }

        // GET: UserRunningCoursesInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRunningCoursesInfo = await _context.UserRunningCoursesInfos.FindAsync(id);
            if (userRunningCoursesInfo == null)
            {
                return NotFound();
            }
            return View(userRunningCoursesInfo);
        }

        // POST: UserRunningCoursesInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserRunningCoursesInfoId,courseId,TrainerName,CourseName,CompleteClasses,remainingPoints")] UserRunningCoursesInfo userRunningCoursesInfo)
        {
            if (id != userRunningCoursesInfo.UserRunningCoursesInfoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userRunningCoursesInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRunningCoursesInfoExists(userRunningCoursesInfo.UserRunningCoursesInfoId))
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
            return View(userRunningCoursesInfo);
        }

        // GET: UserRunningCoursesInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRunningCoursesInfo = await _context.UserRunningCoursesInfos
                .FirstOrDefaultAsync(m => m.UserRunningCoursesInfoId == id);
            if (userRunningCoursesInfo == null)
            {
                return NotFound();
            }

            return View(userRunningCoursesInfo);
        }

        // POST: UserRunningCoursesInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userRunningCoursesInfo = await _context.UserRunningCoursesInfos.FindAsync(id);
            _context.UserRunningCoursesInfos.Remove(userRunningCoursesInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRunningCoursesInfoExists(int id)
        {
            return _context.UserRunningCoursesInfos.Any(e => e.UserRunningCoursesInfoId == id);
        }
    }
}
