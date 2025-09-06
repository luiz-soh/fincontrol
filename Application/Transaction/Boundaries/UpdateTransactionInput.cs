using System.ComponentModel.DataAnnotations;

namespace Application.Transaction.Boundaries
{
    public class UpdateTransactionInput
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public decimal TransactionAmount { get; set; }
    }
}
