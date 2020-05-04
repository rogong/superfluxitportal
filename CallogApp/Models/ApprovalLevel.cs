using System.ComponentModel.DataAnnotations;

namespace CallogApp.Models
{
    public class ApprovalLevel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}