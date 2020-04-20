using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CallogApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CallogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
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

            ViewBag.usersCount = users;
            ViewBag.requestsCount = requests;
            ViewBag.callsCount = calls;

            return View();
        }
    }
}