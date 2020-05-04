using System.ComponentModel.DataAnnotations;

namespace CallogApp.Models
{
    public class ApprovedStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}