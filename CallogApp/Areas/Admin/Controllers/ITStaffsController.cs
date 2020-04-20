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
    public class ITStaffsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ITStaffsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ITStaffs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ITStaffs.ToListAsync());
        }

        // GET: Admin/ITStaffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTStaff = await _context.ITStaffs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (iTStaff == null)
            {
                return NotFound();
            }

            return View(iTStaff);
        }

        // GET: Admin/ITStaffs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ITStaffs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Specialisation")] ITStaff iTStaff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iTStaff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iTStaff);
        }

        // GET: Admin/ITStaffs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTStaff = await _context.ITStaffs.FindAsync(id);
            if (iTStaff == null)
            {
                return NotFound();
            }
            return View(iTStaff);
        }

        // POST: Admin/ITStaffs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Specialisation")] ITStaff iTStaff)
        {
            if (id != iTStaff.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iTStaff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ITStaffExists(iTStaff.Id))
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
            return View(iTStaff);
        }

        // GET: Admin/ITStaffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iTStaff = await _context.ITStaffs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (iTStaff == null)
            {
                return NotFound();
            }

            return View(iTStaff);
        }

        // POST: Admin/ITStaffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iTStaff = await _context.ITStaffs.FindAsync(id);
            _context.ITStaffs.Remove(iTStaff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ITStaffExists(int id)
        {
            return _context.ITStaffs.Any(e => e.Id == id);
        }
    }
}
