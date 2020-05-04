using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CallogApp.Data;
using CallogApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CallogApp.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class ApprovalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApprovalController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Approvals.Include(a => a.ApprovalLevel).Include(a => a.ApprovedStatus).Include(a => a.Currency).Include(a => a.Department).Include(a => a.PaymentMode).Include(a => a.Requester);
            return View(await applicationDbContext.ToListAsync());
        }


        public IActionResult Create()
        {

            ViewData["ApprovalLevelId"] = new SelectList(_context.ApprovalLevels, "Id", "Name");
            ViewData["ApprovedStatusId"] = new SelectList(_context.ApprovedStatuses, "Id", "Name");
            ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Name");
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            ViewData["PaymentModeId"] = new SelectList(_context.PaymentModes, "Id", "Name");
            ViewData["RequesterId"] = new SelectList(_context.Requesters, "Id", "Name");
            ViewBag.ApprovalLevelId = 6;
            ViewBag.ApprovedStatusId = 3;
            ViewBag.DateCreated = DateTime.Now;
            ViewBag.UserId = User.Identity.Name;
            TempData["Message"] = "Request sent successfully";



            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateCreated,Name,RequesterId," +
            "PaymentModeId,CurrencyId,LeagerName,AnnualBudget,YTD,CurrentRequest,YTDPercent," +
            "Beneficiary,JobDescription,Reason,TotalCost,AdvanceRequired,PreparedBy" +
            ",DepartmentId,ApprovalLevelId,ApprovedStatusId")] Approval approval)
        {
            if (ModelState.IsValid)
            {
                _context.Add(approval);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApprovalLevelId"] = new SelectList(_context.ApprovalLevels, "Id", "Name", approval.ApprovalLevelId);
            ViewData["ApprovedStatusId"] = new SelectList(_context.ApprovedStatuses, "Id", "Name", approval.ApprovedStatusId);
            ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Name", approval.CurrencyId);
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", approval.DepartmentId);
            ViewData["PaymentModeId"] = new SelectList(_context.PaymentModes, "Id", "Name", approval.PaymentModeId);
            ViewData["RequesterId"] = new SelectList(_context.Requesters, "Id", "Name", approval.RequesterId);
            ViewBag.ApprovalLevelId = 6;
            ViewBag.ApprovedStatusId = 3;
            ViewBag.UserId = User.Identity.Name;
            TempData["Message"] = "Request sent successfully";

            return View(approval);
        }

        // GET: Admin/Approvals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var approval = await _context.Approvals.FindAsync(id);
            if (approval == null)
            {
                return NotFound();
            }
            ViewData["ApprovalLevelId"] = new SelectList(_context.ApprovalLevels, "Id", "Name", approval.ApprovalLevelId);
            ViewData["ApprovedStatusId"] = new SelectList(_context.ApprovedStatuses, "Id", "Name", approval.ApprovedStatusId);
            ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Name", approval.CurrencyId);
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", approval.DepartmentId);
            ViewData["PaymentModeId"] = new SelectList(_context.PaymentModes, "Id", "Name", approval.PaymentModeId);
            ViewData["RequesterId"] = new SelectList(_context.Requesters, "Id", "Name", approval.RequesterId);
            return View(approval);
        }

        // POST: Admin/Approvals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateCreated,Name,RequesterId,PaymentModeId,CurrencyId,LeagerName,AnnualBudget,YTD,CurrentRequest,YTDPercent,Beneficiary,JobDescription,Reason,TotalCost,AdvanceRequired,PreparedBy,CheckedBy,AuthorisedBy,ApprovedBy,DepartmentId,ApprovalLevelId,ApprovedStatusId")] Approval approval)
        {
            if (id != approval.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(approval);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApprovalExists(approval.Id))
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
            ViewData["ApprovalLevelId"] = new SelectList(_context.ApprovalLevels, "Id", "Name", approval.ApprovalLevelId);
            ViewData["ApprovedStatusId"] = new SelectList(_context.ApprovedStatuses, "Id", "Name", approval.ApprovedStatusId);
            ViewData["CurrencyId"] = new SelectList(_context.Currencies, "Id", "Name", approval.CurrencyId);
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", approval.DepartmentId);
            ViewData["PaymentModeId"] = new SelectList(_context.PaymentModes, "Id", "Name", approval.PaymentModeId);
            ViewData["RequesterId"] = new SelectList(_context.Requesters, "Id", "Name", approval.RequesterId);
            return View(approval);
        }

        private bool ApprovalExists(int id)
        {
            return _context.Approvals.Any(e => e.Id == id);
        }
    }
}