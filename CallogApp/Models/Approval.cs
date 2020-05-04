using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CallogApp.Models
{
    public class Approval
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser ApplicationUser  { get; set; }

        [DisplayName("Date")]
        public DateTime DateCreated { get; set; }
        public string Name { get; set; }
        [DisplayName("Identity")]
        public int RequesterId { get; set; }
        [ForeignKey("RequesterId")]
        public virtual Requester Requester { get; set; }
        [DisplayName("Payment Mode")]
        public int PaymentModeId { get; set; }
        [ForeignKey("PaymentModeId")]
        public virtual PaymentMode PaymentMode { get; set; }
        [DisplayName("Currency")]
        public int CurrencyId { get; set; }
        [ForeignKey("CurrencyId")]
        public virtual Currency Currency { get; set; }
        [DisplayName("Leager Name")]
        public string LeagerName { get; set; }
        [DisplayName("Annual Budget")]
        public double AnnualBudget { get; set; }
        public double YTD { get; set; }

        [DisplayName("Current Request")]
        public double CurrentRequest { get; set; }
        public double YTDPercent { get; set; }
        [DisplayName("BENEFICIARY")]
        public string Beneficiary { get; set; }
        [DisplayName("Job Description")]
        public string JobDescription { get; set; }
        [DisplayName("REASON FOR ADVANCE PAYMENT")]
        public string Reason { get; set; }
        [DisplayName("TOTAL COST")]
        public double TotalCost { get; set; }
        [DisplayName("ADVANCE REQUIRED")]
        public string AdvanceRequired { get; set; }
        [DisplayName("Prepared By")]
        public string PreparedBy { get; set; }
        [DisplayName("Checked By")]
        public string CheckedBy { get; set; }
        [DisplayName("Authorised By")]
        public string AuthorisedBy { get; set; }
        [DisplayName("Approved By")]
        public string ApprovedBy { get; set; }
        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        [DisplayName("Approval Level")]
        public int  ApprovalLevelId { get; set; }
        [ForeignKey("ApprovalLevelId")]
        public virtual ApprovalLevel ApprovalLevel { get; set; }
        [DisplayName("Status")]
        public int ApprovedStatusId { get; set; }
        [ForeignKey("ApprovedStatusId")]
        public virtual ApprovedStatus ApprovedStatus { get; set; }

    }
}
