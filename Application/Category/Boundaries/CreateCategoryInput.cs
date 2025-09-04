using Domain.Enums;

namespace Application.Category.Boundaries
{
    public class CreateCategoryInput
    {
        public string Name { get; set; } = string.Empty;
        public CategoryTypeEnum Type { get; set; }
    }
}
