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
    [Authorize(Roles = SD.SuperAdminUser)]
    public class RequestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Requests
        public async Task<IActionResult> Index()
        {
            var requests = _context.Requests
                .Include(r => r.Department)
                .Include(r => r.Device)
                .Include(r => r.Issue)
                .Include(r => r.RequestType)
                .Include(r => r.Status)
                .Include(r => r.ITStaff)
                ;
           
            
            if(requests == null)
            {
                return RedirectToAction("Create", "Request", new { Area = "Admin" });
            }
            return View(await requests.ToListAsync());
        }

        // GET: Admin/Requests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Requests
                .Include(r => r.Department)
                .Include(r => r.Device)
                .Include(r => r.Issue)
                .Include(r => r.RequestType)
                .Include(r => r.Status)
                .Include(r => r.ITStaff)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }

        // GET: Admin/Requests/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            ViewData["DeviceId"] = new SelectList(_context.Devices, "Id", "Name");
            ViewData["IssueId"] = new SelectList(_context.Issues, "Id", "Name");
            ViewData["RequestTypeId"] = new SelectList(_context.RequestTypes, "Id", "Name");
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Name");
            ViewData["ITStaffId"] = new SelectList(_context.ITStaffs, "Id", "Name");
            ViewBag.DateCreated = DateTime.Now;
            ViewBag.UserId = User.Identity.Name;
            TempData["Message"] = "Request sent successfully";
            return View();
        }

        // POST: Admin/Requests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StatusId,UserId,DateCreated,DepartmentId,IssueId,DeviceId,RequestTypeId,Subject,Message,ITStaffId")] Request request)
        {
            if (ModelState.IsValid)
            {
                _context.Add(request);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", request.DepartmentId);
            ViewData["DeviceId"] = new SelectList(_context.Devices, "Id", "Name", request.DeviceId);
            ViewData["IssueId"] = new SelectList(_context.Issues, "Id", "Name", request.IssueId);
            ViewData["RequestTypeId"] = new SelectList(_context.RequestTypes, "Id", "Name", request.RequestTypeId);
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Name", request.StatusId);
            ViewData["ITStaffId"] = new SelectList(_context.ITStaffs, "Id", "Name", request.ITStaffId);
            return View(request);
        }

        // GET: Admin/Requests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Requests.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", request.DepartmentId);
            ViewData["DeviceId"] = new SelectList(_context.Devices, "Id", "Name", request.DeviceId);
            ViewData["IssueId"] = new SelectList(_context.Issues, "Id", "Name", request.IssueId);
            ViewData["RequestTypeId"] = new SelectList(_context.RequestTypes, "Id", "Name", request.RequestTypeId);
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Name", request.StatusId);
            ViewData["ITStaffId"] = new SelectList(_context.ITStaffs, "Id", "Name", request.ITStaffId);
            return View(request);
        }

        // POST: Admin/Requests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StatusId,UserId,DateCreated,DepartmentId,IssueId,DeviceId,RequestTypeId,Subject,Message,ITStaffId")] Request request)
        {
            if (id != request.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(request);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestExists(request.Id))
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
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", request.DepartmentId);
            ViewData["DeviceId"] = new SelectList(_context.Devices, "Id", "Name", request.DeviceId);
            ViewData["IssueId"] = new SelectList(_context.Issues, "Id", "Name", request.IssueId);
            ViewData["RequestTypeId"] = new SelectList(_context.RequestTypes, "Id", "Name", request.RequestTypeId);
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Name", request.StatusId);
            ViewData["ITStaffId"] = new SelectList(_context.ITStaffs, "Id", "Name", request.ITStaffId);
            return View(request);
        }

        // GET: Admin/Requests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Requests
                .Include(r => r.Department)
                .Include(r => r.Device)
                .Include(r => r.Issue)
                .Include(r => r.RequestType)
                .Include(r => r.Status)
                .Include(r => r.ITStaff)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }

        // POST: Admin/Requests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var request = await _context.Requests.FindAsync(id);
            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequestExists(int id)
        {
            return _context.Requests.Any(e => e.Id == id);
        }
    }
}
