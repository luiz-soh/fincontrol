using Domain.Entities.Category;
using Domain.Entities.Transaction;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configuration
{
    public class ContextBase(DbContextOptions<ContextBase> options) : DbContext(options)
    {
        public DbSet<CategoryEntity> Category => Set<CategoryEntity>();
        public DbSet<TransactionEntity> FinTransaction => Set<TransactionEntity>(); //FinTransaction pois Transaction pode dar um problema como palavra reservada
    }
}
