using Domain.DTOs.Transaction;
using Domain.Entities.Transaction;
using Infra.Configuration;

namespace Infra.Repositories
{
    public class TransactionRepository(ContextBase context) : ITransactionRepository
    {
        private readonly ContextBase _context = context;

        public async Task CreateTransaction(TransactionDTO dto)
        {
            var entity = new TransactionEntity()
            {
                Name = dto.Name,
                TransactionDate = dto.TransactionDate,
                CategoryId = dto.CategoryId,
                TransactionAmount = dto.TransactionAmount
            };

            _context.FinTransaction.Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}
