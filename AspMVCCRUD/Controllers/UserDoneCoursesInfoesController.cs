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
    public class UserDoneCoursesInfoesController : Controller
    {
        private readonly UserContext _context;

        public UserDoneCoursesInfoesController(UserContext context)
        {
            _context = context;
        }

        // GET: UserDoneCoursesInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserDoneCoursesInfos.ToListAsync());
        }

        // GET: UserDoneCoursesInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDoneCoursesInfo = await _context.UserDoneCoursesInfos
                .FirstOrDefaultAsync(m => m.UserDoneCoursesInfoId == id);
            if (userDoneCoursesInfo == null)
            {
                return NotFound();
            }

            return View(userDoneCoursesInfo);
        }

        // GET: UserDoneCoursesInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserDoneCoursesInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserDoneCoursesInfoId,courseId,TrainerName,DoneCourses,Grade")] UserDoneCoursesInfo userDoneCoursesInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userDoneCoursesInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userDoneCoursesInfo);
        }

        // GET: UserDoneCoursesInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDoneCoursesInfo = await _context.UserDoneCoursesInfos.FindAsync(id);
            if (userDoneCoursesInfo == null)
            {
                return NotFound();
            }
            return View(userDoneCoursesInfo);
        }

        // POST: UserDoneCoursesInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserDoneCoursesInfoId,courseId,TrainerName,DoneCourses,Grade")] UserDoneCoursesInfo userDoneCoursesInfo)
        {
            if (id != userDoneCoursesInfo.UserDoneCoursesInfoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userDoneCoursesInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserDoneCoursesInfoExists(userDoneCoursesInfo.UserDoneCoursesInfoId))
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
            return View(userDoneCoursesInfo);
        }

        // GET: UserDoneCoursesInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDoneCoursesInfo = await _context.UserDoneCoursesInfos
                .FirstOrDefaultAsync(m => m.UserDoneCoursesInfoId == id);
            if (userDoneCoursesInfo == null)
            {
                return NotFound();
            }

            return View(userDoneCoursesInfo);
        }

        // POST: UserDoneCoursesInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userDoneCoursesInfo = await _context.UserDoneCoursesInfos.FindAsync(id);
            _context.UserDoneCoursesInfos.Remove(userDoneCoursesInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserDoneCoursesInfoExists(int id)
        {
            return _context.UserDoneCoursesInfos.Any(e => e.UserDoneCoursesInfoId == id);
        }
    }
}
