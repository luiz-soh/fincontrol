using Domain.Entities.Category;
using Domain.Enums;

namespace Domain.DTOs.Category
{
    public class CategoryDTO
    {
        public CategoryDTO() { }
        public CategoryDTO(CategoryEntity entity) 
        {
            Id = entity.Id;
            Name = entity.Name;
            Type = entity.Type;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public CategoryTypeEnum Type { get; set; }
    }
}
