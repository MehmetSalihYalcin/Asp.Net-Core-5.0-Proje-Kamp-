using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.Writer_Name).NotEmpty().WithMessage("Yazar Adı Soyadı ALanı Boş Geçilemez");
            RuleFor(x => x.Writer_Mail).NotEmpty().WithMessage("Mail ALanı Boş Geçilemez");
            RuleFor(x => x.Writer_Mail).EmailAddress().WithMessage("Lütfen Geçerli Bir Mail Giriniz");
            RuleFor(x => x.Writer_Password).NotEmpty().WithMessage("Şifre ALanı Boş Geçilemez");
			RuleFor(x => x.Writer_Password)
			.Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$")
			.WithMessage("Şifre alanı en az bir büyük harf, bir küçük harf ve bir sayı içermelidir.");

			RuleFor(x => x.Writer_Name).MinimumLength(3).WithMessage("Yazar Adı Soyadı  Alanı En az 3 Karakter Olabilir");
            RuleFor(x => x.Writer_Name).MaximumLength(50).WithMessage("Yazar Adı Soyadı En Fazla 50 Karakter Olabilir");
        }
    }
}
