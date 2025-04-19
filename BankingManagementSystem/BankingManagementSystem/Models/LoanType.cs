using System.ComponentModel.DataAnnotations;

namespace BankingManagementSystem.Models
{
    public class LoanType
    {
        public int Id { get; set; }
        [Display(Name = "Loan Type")]
        [Required(ErrorMessage = "Loan type is required.")]
        public string Name { get; set; }
    }
}
