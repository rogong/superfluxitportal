using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CallogApp.Data;
using CallogApp.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CallogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.SuperAdminUser + "," + SD.AdminUser)]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext  db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _db.ApplicationUsers.CountAsync();
            var requests = await _db.Requests.CountAsync();
            var calls = await _db.Calls.CountAsync();

            var todayRequests = await _db.Requests
             .Where(r => r.DateCreated.Date == DateTime.Today.Date)
             .CountAsync();

            ViewBag.usersCount = users;
            ViewBag.requestsCount = requests;
            ViewBag.callsCount = calls;
            ViewBag.todayRequests = todayRequests;

            return View();
        }
    }
}