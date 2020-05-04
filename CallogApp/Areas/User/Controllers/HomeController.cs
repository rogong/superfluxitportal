using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using CallogApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using CallogApp.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace CallogApp.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        [BindProperty]
        public  Request Requesst { get; set; }
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;

        }

        public async Task<IActionResult> Dashboard()
        {
            var activeRequest = await _context.Requests
                .Where(r => r.ITStaffId == 7)
                .Where(r => r.UserId == User.Identity.Name)
                .CountAsync();

            var requests = await _context.Requests
                .Where(r => r.UserId == User.Identity.Name)
                .CountAsync();

            var todayRequests =  await _context.Requests
                .Where(r => r.UserId == User.Identity.Name)
                .Where(r => r.DateCreated.Date == DateTime.Today.Date)
                .CountAsync();

            var users = await _context.ApplicationUsers.CountAsync();

            ViewBag.activeRequestCount = activeRequest;
            ViewBag.requestsCount = requests;
            ViewBag.todayRequests = todayRequests;
            ViewBag.users = users;

            return View();
        }

        public IActionResult Index()
        {

          


            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            ViewData["IssueId"] = new SelectList(_context.Issues, "Id", "Name");
            ViewData["RequestTypeId"] = new SelectList(_context.RequestTypes, "Id", "Name");
            ViewData["DeviceId"] = new SelectList(_context.Devices, "Id", "Name");
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Name");
           /// ViewData["ITStaffId"] = new SelectList(_context.ITStaffs, "Id", "Name");
            ViewBag.DateCreated = DateTime.Now;
            ViewBag.UserId = User.Identity.Name;
            ViewBag.StatusId =  1;
            ViewBag.ITStaffId = 7;
            TempData["Message"] = "Request sent successfully";



            return View();
        }

        //[Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StatusId,ITStaffId,UserId,DateCreated,DepartmentId,IssueId,DeviceId,RequestTypeId,Subject,Message,ResolvedBy")] Request request)
        {
            if(!User.Identity.IsAuthenticated)
            {
               
                return RedirectToAction("Login","Account", new { Area = "Identity" });

                }
            if (ModelState.IsValid)
            {
              
                _context.Add(request);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "UserRequest", new { Area = "User" });
            }

            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            ViewData["IssueId"] = new SelectList(_context.Issues, "Id", "Name");
            ViewData["RequestTypeId"] = new SelectList(_context.RequestTypes, "Id", "Name");
            ViewData["DeviceId"] = new SelectList(_context.Devices, "Id", "Name");
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Name");
            ViewBag.DateCreated = DateTime.Now;
            ViewBag.UserId = User.Identity.Name;
            ViewBag.StatusId = 1;
           

            return View(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
