using System;
using System.Collections.Generic;
using System.Text;
using CallogApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CallogApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Call> Calls  { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Issue> Issues { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Devices> Devices { get; set; }

        public DbSet<RequestType> RequestTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<ITStaff> ITStaffs { get; set; }
    }
}
