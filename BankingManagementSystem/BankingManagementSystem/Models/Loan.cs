using System.ComponentModel.DataAnnotations;

namespace BankingManagementSystem.Models
{
    public class Loan
    {
        public int Id { get; set; }
        [Display(Name = "Loan Number")]
        public string LoanNumber { get; set; }
        [Display(Name = "Amount")]
        public decimal LoanAmount { get; set; }
        [Display(Name = "Interest Rate")]
        public float InterestRate { get; set; }
        [Display(Name = "Duration")]
        public int TotalMonth { get; set; }
        [Display(Name = "Applied Date")]
        public DateTime AppliedDate { get; set; }
        [Display(Name = "Approved Date")]
        public DateTime ApprovedDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Loan Type")]
        public int LoanTypeId { get; set; }
        [Display(Name = "Customer Name")]
        public int CustomerId { get; set; }
        [Display(Name = "Loan Type")]
        public virtual LoanType LoanType { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
