using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CallogApp.Models
{
    public class Call
    {
        public int Id { get; set; }
        [Required]
        public string Caller { get; set; }
        [Required]
        public string Receiver { get; set; }
        [Required]
        [DisplayName("Subject")]
        public string Suject { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Note { get; set; }
        [DataType(DataType.MultilineText)]
        public string Remark { get; set; }
        [Required]
        [DisplayName("Date")]
        public DateTime CreateDate { get; set; }
        [DisplayName("Departments")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        [DisplayName("Issues")]
        public int IssueId { get; set; }
        [ForeignKey("IssueId")]
        public virtual Issue Issue { get; set; }
    


    }
}
