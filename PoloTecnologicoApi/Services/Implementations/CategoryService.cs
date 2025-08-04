using Web.Models.Dtos.Request;
using Web.Models.Dtos.Response;
using Web.Services.Interfaces;

namespace Web.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private static readonly List<CategoryResponseDto> _categories = new();
        private static int _id = 1;

        public async Task<CategoryResponseDto> CreateAsync(CategoryRequestDto dto)
        {
            var nuevaCategoria = new CategoryResponseDto
            {
                Id = _id++,
                Name = dto.Name,
                Description = dto.Description
            };

            _categories.Add(nuevaCategoria);
            return await Task.FromResult(nuevaCategoria);
        }

        public async Task<IEnumerable<CategoryResponseDto>> GetAllAsync()
        {
            return await Task.FromResult(_categories);
        }

        public async Task<CategoryResponseDto?> GetByIdAsync(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            return await Task.FromResult(category);
        }

        public async Task<CategoryResponseDto?> GetByNameAsync(string name)
        {
            var category = _categories
                .FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            return await Task.FromResult(category);
        }
    }
}
