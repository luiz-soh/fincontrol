namespace Domain.DTOs.Transaction
{
    public class TransactionDTO
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        
        public DateTime TransactionDate { get; set; }
        
        public decimal TransactionAmount { get; set; }
    }
}
