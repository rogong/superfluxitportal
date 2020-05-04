using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CallogApp.Models
{
    public class Requester
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [NotMapped]
        public bool checkboxAnswer { get; set; }
    }
}