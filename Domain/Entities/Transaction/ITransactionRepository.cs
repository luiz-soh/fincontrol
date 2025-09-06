using Domain.DTOs.Transaction;

namespace Domain.Entities.Transaction
{
    public interface ITransactionRepository
    {
        Task CreateTransaction(TransactionDTO dto);

        Task UpdateTransaction(TransactionDTO dto);
        Task<TransactionEntity?> GetTransactionById(int id);
        Task<List<TransactionEntity>> ListTransactions();
        Task DeleteTransactionById(int id);
    }
}
