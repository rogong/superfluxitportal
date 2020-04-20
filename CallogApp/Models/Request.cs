using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CallogApp.Models
{
    public class Request
    {
        public int Id { get; set; }
        [DisplayName("Status")]
        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }

        public string UserId { get; set; }

        [Required]
        [DisplayName("Date")]
        public DateTime DateCreated { get; set; }
        [DisplayName("Departments")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        [DisplayName("Issues")]
        public int IssueId { get; set; }
        [ForeignKey("IssueId")]
        public virtual Issue Issue { get; set; }

        [DisplayName("Device")]
        public int DeviceId { get; set; }
        [ForeignKey("DeviceId")]
        public virtual Devices Device { get; set; }

        [DisplayName("Type Of Request")]
        public int RequestTypeId { get; set; }
        [ForeignKey("RequestTypeId")]
        public virtual RequestType RequestType { get; set; }
       [Required]
        public string Subject { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [DisplayName("ResolvedBy")]
        public int ITStaffId { get; set; }
        [ForeignKey("ITStaffId")]
        public virtual ITStaff ITStaff { get; set; }

    }
}
