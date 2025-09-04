using Domain.Enums;

namespace Application.Category.Boundaries
{
    public class UpdateCategoryInput
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public CategoryTypeEnum Type { get; set; }
    }
}
