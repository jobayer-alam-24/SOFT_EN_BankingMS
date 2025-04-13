namespace BankingManagementSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string AccountHolderName { get; set; }
        public long AccountNumber { get; set; }
        public AccountTypes AccountType { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public decimal InitialBalance { get; set; }
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
