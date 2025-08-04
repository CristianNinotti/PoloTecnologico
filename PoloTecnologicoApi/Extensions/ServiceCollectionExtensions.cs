using FluentValidation;
using FluentValidation.AspNetCore;
using Web.Models.Dtos.Request;
using Web.Models.Dtos.Validators;
using Web.Services.Implementations;
using Web.Services.Interfaces;

namespace Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();


            return services;
        }

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();

            services.AddScoped<IValidator<ProductRequestDto>, ProductRequestDtoValidator>();
            services.AddScoped<IValidator<CategoryRequestDto>, CategoryRequestDtoValidator>();

            return services;
        }
    }
}
