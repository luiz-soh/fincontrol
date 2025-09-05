namespace Application.Transaction.Boundaries
{
    public class CreateTransactionInput
    {
        public string Name { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal TransactionAmount { get; set; }
    }
}
