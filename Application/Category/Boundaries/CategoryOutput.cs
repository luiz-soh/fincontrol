using Domain.DTOs.Category;
using Domain.Enums;

namespace Application.Category.Boundaries
{
    public class CategoryOutput
    {
        public CategoryOutput() { }
        public CategoryOutput(CategoryDTO entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            TypeDescription = entity.Type.ToString();
            Type = entity.Type;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string TypeDescription { get; set; } = string.Empty;
        public CategoryTypeEnum Type { get; set; }

    }
}
