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
    public class ApprovalLevelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApprovalLevelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ApprovalLevels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ApprovalLevels.ToListAsync());
        }

        // GET: Admin/ApprovalLevels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var approvalLevel = await _context.ApprovalLevels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (approvalLevel == null)
            {
                return NotFound();
            }

            return View(approvalLevel);
        }

        // GET: Admin/ApprovalLevels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ApprovalLevels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ApprovalLevel approvalLevel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(approvalLevel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(approvalLevel);
        }

        // GET: Admin/ApprovalLevels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var approvalLevel = await _context.ApprovalLevels.FindAsync(id);
            if (approvalLevel == null)
            {
                return NotFound();
            }
            return View(approvalLevel);
        }

        // POST: Admin/ApprovalLevels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ApprovalLevel approvalLevel)
        {
            if (id != approvalLevel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(approvalLevel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApprovalLevelExists(approvalLevel.Id))
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
            return View(approvalLevel);
        }

        // GET: Admin/ApprovalLevels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var approvalLevel = await _context.ApprovalLevels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (approvalLevel == null)
            {
                return NotFound();
            }

            return View(approvalLevel);
        }

        // POST: Admin/ApprovalLevels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var approvalLevel = await _context.ApprovalLevels.FindAsync(id);
            _context.ApprovalLevels.Remove(approvalLevel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApprovalLevelExists(int id)
        {
            return _context.ApprovalLevels.Any(e => e.Id == id);
        }
    }
}
