using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CallogApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        [DisplayName("Departments")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        public string Title { get; set; }
    
    }
}
