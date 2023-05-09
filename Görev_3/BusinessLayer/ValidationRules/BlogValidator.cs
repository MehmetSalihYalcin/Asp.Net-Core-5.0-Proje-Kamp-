using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Blog_Title).NotEmpty().WithMessage("Blog başlığı aLanı boş geçilemez");
            RuleFor(x => x.Blog_Content).NotEmpty().WithMessage("Blog içeriği boş geçilemez");
            RuleFor(x => x.Blog_Image).NotEmpty().WithMessage("Blog görseli boş geçilemez");
            RuleFor(x => x.Blog_ThumbNailImage).NotEmpty().WithMessage("Küçük blog görseli boş geçilemez");
            RuleFor(x => x.Blog_Title).MaximumLength(150).WithMessage("En fazla 150 karakterden az veri girişi yapınız");
            RuleFor(x => x.Blog_Title).MinimumLength(4).WithMessage("En az 4 karakterden fazla veri girişi yapınız");
        }
    }
}
