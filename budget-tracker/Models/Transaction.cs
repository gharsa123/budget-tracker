namespace BudgetTracker.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}

public enum TransactionType 
{
    Income,
    Expense
}
