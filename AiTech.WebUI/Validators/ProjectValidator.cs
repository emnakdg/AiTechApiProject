using AiTech.WebUI.DTOs.ProjectDtos;
using FluentValidation;

namespace AiTech.WebUI.Validators
{
    public class ProjectValidator : AbstractValidator<CreateProjectDto>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz.")
                                 .MinimumLength(5).WithMessage("Başlık en az 5 karakter olmalıdır.")
                                 .MaximumLength(30).WithMessage("Başlık en fazla 30 karakter olabilir.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim URL boş bırakılamaz.");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori boş bırakılamaz.");

        }
    }
}
