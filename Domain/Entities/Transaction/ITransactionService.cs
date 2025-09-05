using Domain.DTOs.Transaction;

namespace Domain.Entities.Transaction
{
    public interface ITransactionService
    {
        Task CreateTransaction(TransactionDTO dto);
    }
}
