using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CallogApp.Models
{
    public class ITStaff
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Specialisation { get; set; }
    }
}
