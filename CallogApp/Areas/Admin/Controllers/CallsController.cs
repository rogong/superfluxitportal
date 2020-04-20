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
    [Authorize(Roles = SD.SuperAdminUser + "," + SD.AdminUser) ]
    public class CallsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CallsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Calls
        public IActionResult Index()
        {
           //var calls = _context.Calls.Include(c => c.Department).Include(c => c.Issue);

            return View();
        }

        

        // GET: Admin/Calls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var call = await _context.Calls
                .Include(c => c.Department)
                .Include(c => c.Issue)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (call == null)
            {
                return NotFound();
            }

            return View(call);
        }

        // GET: Admin/Calls/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            ViewData["IssueId"] = new SelectList(_context.Issues, "Id", "Name");
            ViewBag.CreateDate = DateTime.Now;
            return View();
        }

        // POST: Admin/Calls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Caller,Receiver,Suject,Note,Remark,CreateDate,DepartmentId,IssueId")] Call call)
        {
            if (ModelState.IsValid)
            {
               
                _context.Add(call);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Call has been logged successfully";
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", call.DepartmentId);
            ViewData["IssueId"] = new SelectList(_context.Issues, "Id", "Name", call.IssueId);
            
            
            return View(call);
        }

        // GET: Admin/Calls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var call = await _context.Calls.FindAsync(id);
            if (call == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", call.DepartmentId);
            ViewData["IssueId"] = new SelectList(_context.Issues, "Id", "Name", call.IssueId);
            ViewBag.CreateDate = DateTime.Now;
            return View(call);
        }

        // POST: Admin/Calls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Caller,Receiver,Suject,Note,Remark,CreateDate,DepartmentId,IssueId")] Call call)
        {
            if (id != call.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(call);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CallExists(call.Id))
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
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", call.DepartmentId);
            ViewData["IssueId"] = new SelectList(_context.Issues, "Id", "Name", call.IssueId);
            ViewData["CreateDate"] = DateTime.Now;
            return View(call);
        }

        // GET: Admin/Calls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var call = await _context.Calls
                .Include(c => c.Department)
                .Include(c => c.Issue)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (call == null)
            {
                return NotFound();
            }

            return View(call);
        }

        // POST: Admin/Calls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var call = await _context.Calls.FindAsync(id);
            _context.Calls.Remove(call);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CallExists(int id)
        {
            return _context.Calls.Any(e => e.Id == id);
        }
    }
}
