
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Web.Models.Dtos.Request;
using Web.Models.Dtos.Response;
using Web.Services.Interfaces;

namespace Web.Services.Implementations
{
    public class ProductService : IProductService
    {
        private static readonly List<ProductResponseDto> _productos = new();
        private static int _id = 1;

        public async Task<ProductResponseDto> CreateAsync(ProductRequestDto dto)
        {
            var nuevoProducto = new ProductResponseDto
            {
                Id = _id++,
                Name = dto.Name,
                Price = dto.Price,
                Category = dto.Category,
                Quantity = dto.Quantity
            };

            _productos.Add(nuevoProducto);
            return await Task.FromResult(nuevoProducto);
        }

        public async Task<ProductResponseDto?> GetByIdAsync(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            return await Task.FromResult(producto);
        }

        public async Task<IEnumerable<ProductResponseDto>> GetAllAsync()
        {
            return await Task.FromResult(_productos);
        }
    }
}
