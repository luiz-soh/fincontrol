using Domain.DTOs.Transaction;

namespace Domain.Entities.Transaction
{
    public interface ITransactionService
    {
        Task CreateTransaction(TransactionDTO dto);
        Task UpdateTransaction(TransactionDTO dto);
        Task<TransactionDTO> GetTransactionById(int id);
        Task<List<TransactionDTO>> ListTransactions();
        Task DeleteTransactionById(int id);
    }
}
