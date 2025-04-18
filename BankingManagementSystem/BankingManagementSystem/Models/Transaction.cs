using System.ComponentModel.DataAnnotations;

namespace BankingManagementSystem.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        //Navigation Property
        public virtual Customer Customer { get; set; }
        //Navigation Key
        [Display(Name = "Customer Name")]
        public int CustomerId { get; set; }
        [Display(Name = "Widthdraw Balance")]
        public decimal? WidthdrawBalance { get; set; }
        [Display(Name = "Deposit Balance")]
        public decimal? DepositBalance { get; set; }
        [Display(Name = "Transaction Date")]
        public DateTime TransactionDate { get; set; }
        [Display(Name = "Current Balance")]
        public decimal CurrentBalance { get; set; }
        [Display(Name = "Transaction Status")]
        public TransactionStatus TransactionStatus { get; set; }
    }
    public enum TransactionStatus
    {
        Pending,
        Successed,
        Canceled
    }
}
