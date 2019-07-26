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
    public class VideoListsController : Controller
    {
        private readonly UserContext _context;

        public VideoListsController(UserContext context)
        {
            _context = context;
        }

        // GET: VideoLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.VideoLists.ToListAsync());
        }

        // GET: VideoLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoList = await _context.VideoLists
                .FirstOrDefaultAsync(m => m.VideoId == id);
            if (videoList == null)
            {
                return NotFound();
            }

            return View(videoList);
        }

        // GET: VideoLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VideoLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VideoId,name,VideoField")] VideoList videoList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(videoList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(videoList);
        }

        // GET: VideoLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoList = await _context.VideoLists.FindAsync(id);
            if (videoList == null)
            {
                return NotFound();
            }
            return View(videoList);
        }

        // POST: VideoLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VideoId,name,VideoField")] VideoList videoList)
        {
            if (id != videoList.VideoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(videoList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideoListExists(videoList.VideoId))
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
            return View(videoList);
        }

        // GET: VideoLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoList = await _context.VideoLists
                .FirstOrDefaultAsync(m => m.VideoId == id);
            if (videoList == null)
            {
                return NotFound();
            }

            return View(videoList);
        }

        // POST: VideoLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var videoList = await _context.VideoLists.FindAsync(id);
            _context.VideoLists.Remove(videoList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideoListExists(int id)
        {
            return _context.VideoLists.Any(e => e.VideoId == id);
        }
    }
}
