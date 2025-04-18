using System.ComponentModel.DataAnnotations;

namespace BankingManagementSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Account Holder Name is required.")]
        [Display(Name = "Account Holder Name")]
        public string AccountHolderName { get; set; }
        [Display(Name = "Account Number")]
        public long AccountNumber { get; set; }
        [Display(Name = "Account Type")]
        public AccountTypes AccountType { get; set; }
        [Display(Name = "Account Status")]
        public AccountStatus AccountStatus { get; set; }
        [Display(Name = "Initial Balance")]
        public decimal InitialBalance { get; set; }
        [Display(Name = "Current Balance")]
        public decimal CurrentBalance { get; set; }
    }
    public enum AccountTypes
    { 
        General,
        Savings,
        Loan,
        VIP,
        Students
    }
    public enum AccountStatus
    { 
        Active,
        Inactive,
        Deleted,
        TemporaryBlocked
    }


}
