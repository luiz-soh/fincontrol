using Domain.DTOs.Transaction;

namespace Application.Transaction.Boundaries
{
    public class TransactionOutput
    {
        public TransactionOutput() { }
        public TransactionOutput(TransactionDTO dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            TransactionAmount = dto.TransactionAmount;
            CategoryId = dto.CategoryId;
            TransactionDate = dto.TransactionDate;
        }

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal TransactionAmount { get; set; }
    }
}
