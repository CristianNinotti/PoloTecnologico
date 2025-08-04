using Web.Models.Dtos.Request;
using Web.Models.Dtos.Response;

namespace Web.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryResponseDto> CreateAsync(CategoryRequestDto dto);
        Task<IEnumerable<CategoryResponseDto>> GetAllAsync();
        Task<CategoryResponseDto?> GetByIdAsync(int id);
        Task<CategoryResponseDto?> GetByNameAsync(string name);
    }
}
