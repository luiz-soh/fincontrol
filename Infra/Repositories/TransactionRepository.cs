using Domain.DTOs.Transaction;
using Domain.Entities.Transaction;
using Infra.Configuration;
using Microsoft.EntityFrameworkCore;

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

        public async Task DeleteTransactionById(int id)
        {
            var entity = await _context.FinTransaction.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (entity is not null)
            {
                _context.FinTransaction.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<TransactionEntity?> GetTransactionById(int id)
        {
            return await _context.FinTransaction.Include(x => x.Category).Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<List<TransactionEntity>> ListTransactions()
        {
            return await _context.FinTransaction.AsNoTracking().ToListAsync();
        }

        public async Task UpdateTransaction(TransactionDTO dto)
        {
            var entity = new TransactionEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                TransactionDate = dto.TransactionDate,
                CategoryId = dto.CategoryId,
                TransactionAmount = dto.TransactionAmount
            };

            _context.FinTransaction.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
