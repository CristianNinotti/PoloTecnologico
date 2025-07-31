using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models.Dtos.Request;
using Web.Models.Dtos.Response;

namespace Web.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductResponseDto> CreateAsync(ProductRequestDto dto);
        Task<ProductResponseDto?> GetByIdAsync(int id);
        Task<IEnumerable<ProductResponseDto>> GetAllAsync();
    }
}
