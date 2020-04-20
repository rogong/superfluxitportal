using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CallogApp.Data;
using CallogApp.Models;
using Microsoft.AspNetCore.Authorization;
using CallogApp.Utility;

namespace CallogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.SuperAdminUser + "," + SD.AdminUser)]
    public class DevicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DevicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Devices
        public async Task<IActionResult> Index()
        {
            return View(await _context.Devices.ToListAsync());
        }

        // GET: Admin/Devices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devices = await _context.Devices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (devices == null)
            {
                return NotFound();
            }

            return View(devices);
        }

        // GET: Admin/Devices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Devices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Quantity")] Devices devices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(devices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(devices);
        }

        // GET: Admin/Devices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devices = await _context.Devices.FindAsync(id);
            if (devices == null)
            {
                return NotFound();
            }
            return View(devices);
        }

        // POST: Admin/Devices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Quantity")] Devices devices)
        {
            if (id != devices.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(devices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DevicesExists(devices.Id))
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
            return View(devices);
        }

        // GET: Admin/Devices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devices = await _context.Devices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (devices == null)
            {
                return NotFound();
            }

            return View(devices);
        }

        // POST: Admin/Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var devices = await _context.Devices.FindAsync(id);
            _context.Devices.Remove(devices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DevicesExists(int id)
        {
            return _context.Devices.Any(e => e.Id == id);
        }
    }
}
