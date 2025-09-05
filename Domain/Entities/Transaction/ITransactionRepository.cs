using Domain.DTOs.Transaction;

namespace Domain.Entities.Transaction
{
    public interface ITransactionRepository
    {
        Task CreateTransaction(TransactionDTO dto);
    }
}
