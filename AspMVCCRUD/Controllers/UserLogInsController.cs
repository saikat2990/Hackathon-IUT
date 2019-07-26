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
    public class UserLogInsController : Controller
    {
        private readonly UserContext _context;

        public UserLogInsController(UserContext context)
        {
            _context = context;
        }

        // GET: UserLogIns
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserLogIns.ToListAsync());
        }

        // GET: UserLogIns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLogIn = await _context.UserLogIns
                .FirstOrDefaultAsync(m => m.userId == id);
            if (userLogIn == null)
            {
                return NotFound();
            }

            return View(userLogIn);
        }

        // GET: UserLogIns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserLogIns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("userId,name,password,Email,phnNumber")] UserLogIn userLogIn)
        {
            if (ModelState.IsValid)
            {   

                _context.Add(userLogIn);


                var studentsList = await _context.StudentsLists
                .FirstOrDefaultAsync(m => m.studentname == userLogIn.name);


                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userLogIn);
        }

        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn([Bind("name,password")] UserLogIn userLogIn)
        {




                if (userLogIn.name == "admin")
                {
                    if (userLogIn.password == "iit123")
                    {
                        return Redirect("../Home/About");
                    }
                }



                    var teacher = await _context.TeachersLists.ToListAsync();


                    foreach (var teachers in teacher) {

                        if (teachers.trianername == userLogIn.name && teachers.password == userLogIn.password) {
                            return Redirect("../StudentPages/Index");
                        }
                    }

                    var student = await _context.StudentsLists.ToListAsync();

                    foreach (var students in student)
                    {

                        if (students.studentname == userLogIn.name)
                        {
                            return Redirect("../StudentPages/Create");
                        }
                    }
                

            


            return View();
        }








        // GET: UserLogIns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLogIn = await _context.UserLogIns.FindAsync(id);
            if (userLogIn == null)
            {
                return NotFound();
            }
            return View(userLogIn);
        }

        // POST: UserLogIns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("userId,name,password,Email,phnNumber")] UserLogIn userLogIn)
        {
            if (id != userLogIn.userId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userLogIn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserLogInExists(userLogIn.userId))
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
            return View(userLogIn);
        }

        // GET: UserLogIns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLogIn = await _context.UserLogIns
                .FirstOrDefaultAsync(m => m.userId == id);
            if (userLogIn == null)
            {
                return NotFound();
            }

            return View(userLogIn);
        }

        // POST: UserLogIns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userLogIn = await _context.UserLogIns.FindAsync(id);
            _context.UserLogIns.Remove(userLogIn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserLogInExists(int id)
        {
            return _context.UserLogIns.Any(e => e.userId == id);
        }
    }
}
