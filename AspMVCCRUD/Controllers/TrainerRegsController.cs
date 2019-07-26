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
    public class TrainerRegsController : Controller
    {
        private readonly UserContext _context;

        public TrainerRegsController(UserContext context)
        {
            _context = context;
        }

        // GET: TrainerRegs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TrainerRegs.ToListAsync());
        }

        // GET: TrainerRegs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainerReg = await _context.TrainerRegs
                .FirstOrDefaultAsync(m => m.trainerId == id);
            if (trainerReg == null)
            {
                return NotFound();
            }

            return View(trainerReg);
        }

        // GET: TrainerRegs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TrainerRegs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("trainerId,c_Id,courseName,Name,Email,password,CardNum")] TrainerReg trainerReg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trainerReg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trainerReg);
        }

        // GET: TrainerRegs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainerReg = await _context.TrainerRegs.FindAsync(id);
            if (trainerReg == null)
            {
                return NotFound();
            }
            return View(trainerReg);
        }

        // POST: TrainerRegs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("trainerId,c_Id,courseName,Name,Email,password,CardNum")] TrainerReg trainerReg)
        {
            if (id != trainerReg.trainerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainerReg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainerRegExists(trainerReg.trainerId))
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
            return View(trainerReg);
        }

        // GET: TrainerRegs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainerReg = await _context.TrainerRegs
                .FirstOrDefaultAsync(m => m.trainerId == id);
            if (trainerReg == null)
            {
                return NotFound();
            }

            return View(trainerReg);
        }

        // POST: TrainerRegs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainerReg = await _context.TrainerRegs.FindAsync(id);
            _context.TrainerRegs.Remove(trainerReg);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainerRegExists(int id)
        {
            return _context.TrainerRegs.Any(e => e.trainerId == id);
        }
    }
}
