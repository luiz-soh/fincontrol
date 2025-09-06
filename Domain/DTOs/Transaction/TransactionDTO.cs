using Domain.Entities.Transaction;

namespace Domain.DTOs.Transaction
{
    public class TransactionDTO
    {
        public TransactionDTO() { }
        public TransactionDTO(TransactionEntity entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            CategoryId = entity.CategoryId;
            TransactionDate = entity.TransactionDate;
            TransactionAmount = entity.TransactionAmount;
            CategoryName = entity.Category?.Name ?? string.Empty;
        }

        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        
        public DateTime TransactionDate { get; set; }
        
        public decimal TransactionAmount { get; set; }

        public string CategoryName { get; set; } = string.Empty; //aproveitar o uso do virtual aqui
    }
}
