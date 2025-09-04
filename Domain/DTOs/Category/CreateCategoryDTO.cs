using Domain.Enums;

namespace Domain.DTOs.Category
{
    public class CreateCategoryDTO
    {
        public string Name { get; set; } = string.Empty;
        public CategoryTypeEnum Type { get; set; }
    }
}
