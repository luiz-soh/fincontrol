using Domain.DTOs.Transaction;
using Domain.Entities.Transaction;

namespace Application.Transaction
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task CreateTransaction(TransactionDTO dto)
        {
            await _transactionRepository.CreateTransaction(dto);
        }
    }
}
