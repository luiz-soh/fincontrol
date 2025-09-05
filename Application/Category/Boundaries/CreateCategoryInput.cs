using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Application.Category.Boundaries
{
    public class CreateCategoryInput
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(0, 1)]
        public CategoryTypeEnum Type { get; set; }
    }
}
