using FluentValidation;
using Web.Models.Dtos.Request;

namespace Web.Models.Dtos.Validators
{
    public class CategoryRequestDtoValidator : AbstractValidator<CategoryRequestDto>
    {
        public CategoryRequestDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("El nombre es obligatorio")
                .MaximumLength(100).WithMessage("Máximo 100 caracteres");
            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Máximo 500 caracteres");
        }
    }

}
