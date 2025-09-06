using Domain.DTOs.Transaction;

namespace Application.Transaction.Boundaries
{
    // apenas para mostrar um exemplo simples de herança
    public class GetTransactionOutput : TransactionOutput
    {
        public GetTransactionOutput() { }
        public GetTransactionOutput(TransactionDTO dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            TransactionAmount = dto.TransactionAmount;
            CategoryId = dto.CategoryId;
            CategoryName = dto.CategoryName;
            TransactionDate = dto.TransactionDate;
        }
        public string CategoryName { get; set; } = string.Empty;
    }
}
