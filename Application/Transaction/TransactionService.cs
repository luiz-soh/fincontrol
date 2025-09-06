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

        public async Task DeleteTransactionById(int id)
        {
            await _transactionRepository.DeleteTransactionById(id);
        }

        public async Task<TransactionDTO> GetTransactionById(int id)
        {
            var dto = await _transactionRepository.GetTransactionById(id);

            if (dto is null)
                return new TransactionDTO();

            return new TransactionDTO(dto);
        }

        public async Task<List<TransactionDTO>> ListTransactions()
        {
            var entities = await _transactionRepository.ListTransactions();

            return [.. entities.Select(x => new TransactionDTO(x))];
        }

        public async Task UpdateTransaction(TransactionDTO dto)
        {
            var transactionExist = await _transactionRepository.GetTransactionById(dto.Id);
            if (transactionExist != null)
            {
                await _transactionRepository.UpdateTransaction(dto);
            }
        }
    }
}
