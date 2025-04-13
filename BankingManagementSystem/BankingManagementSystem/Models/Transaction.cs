namespace BankingManagementSystem.Models
{
    public class Transaction
    {
        //Navigation Key
        public int Id { get; set; }
        //Navigation Property
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public decimal? WidthdrawBalance { get; set; }
        public decimal? DepositBalance { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal CurrentBalance { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
    }
    public enum TransactionStatus
    {
        Pending,
        Successed,
        Canceled
    }
}
