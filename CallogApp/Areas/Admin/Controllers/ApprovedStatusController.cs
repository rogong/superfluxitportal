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
    public class ApprovedStatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApprovedStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ApprovedStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.ApprovedStatuses.ToListAsync());
        }

        // GET: Admin/ApprovedStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var approvedStatus = await _context.ApprovedStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (approvedStatus == null)
            {
                return NotFound();
            }

            return View(approvedStatus);
        }

        // GET: Admin/ApprovedStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ApprovedStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ApprovedStatus approvedStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(approvedStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(approvedStatus);
        }

        // GET: Admin/ApprovedStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var approvedStatus = await _context.ApprovedStatuses.FindAsync(id);
            if (approvedStatus == null)
            {
                return NotFound();
            }
            return View(approvedStatus);
        }

        // POST: Admin/ApprovedStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ApprovedStatus approvedStatus)
        {
            if (id != approvedStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(approvedStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApprovedStatusExists(approvedStatus.Id))
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
            return View(approvedStatus);
        }

        // GET: Admin/ApprovedStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var approvedStatus = await _context.ApprovedStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (approvedStatus == null)
            {
                return NotFound();
            }

            return View(approvedStatus);
        }

        // POST: Admin/ApprovedStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var approvedStatus = await _context.ApprovedStatuses.FindAsync(id);
            _context.ApprovedStatuses.Remove(approvedStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApprovedStatusExists(int id)
        {
            return _context.ApprovedStatuses.Any(e => e.Id == id);
        }
    }
}
