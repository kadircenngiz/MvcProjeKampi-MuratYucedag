using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Geçilemez");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadı Boş Geçilemez");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda Kısmı Boş Geçilemez");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan Kısmı Boş Geçilemez");
            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın");
            RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("Lütfen en az 2 karakter girişi yapınız");
        }
    }
}
