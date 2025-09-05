using Domain.Entities.Category;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Transaction
{
    [Table("fin_transaction")]
    public class TransactionEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("category_id")]
        [ForeignKey("category")]
        public int CategoryId { get; set; }

        [Column("transaction_date")]
        public DateTime TransactionDate { get; set; }

        [Column("transaction_amount")]
        public decimal TransactionAmount { get; set; } //Decimal é uma boa opção para valores monetarios pois não arredonda como double ou float

        public virtual CategoryEntity? Category { get; set; } //Eager Loading
    }
}
