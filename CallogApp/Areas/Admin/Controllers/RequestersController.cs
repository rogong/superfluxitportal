using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CallogApp.Data;
using CallogApp.Models;

namespace CallogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RequestersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequestersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Requesters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Requesters.ToListAsync());
        }

        // GET: Admin/Requesters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requester = await _context.Requesters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requester == null)
            {
                return NotFound();
            }

            return View(requester);
        }

        // GET: Admin/Requesters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Requesters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Requester requester)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requester);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requester);
        }

        // GET: Admin/Requesters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requester = await _context.Requesters.FindAsync(id);
            if (requester == null)
            {
                return NotFound();
            }
            return View(requester);
        }

        // POST: Admin/Requesters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Requester requester)
        {
            if (id != requester.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requester);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequesterExists(requester.Id))
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
            return View(requester);
        }

        // GET: Admin/Requesters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requester = await _context.Requesters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requester == null)
            {
                return NotFound();
            }

            return View(requester);
        }

        // POST: Admin/Requesters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requester = await _context.Requesters.FindAsync(id);
            _context.Requesters.Remove(requester);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequesterExists(int id)
        {
            return _context.Requesters.Any(e => e.Id == id);
        }
    }
}
