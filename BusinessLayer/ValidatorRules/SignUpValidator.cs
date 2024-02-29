using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidatorRules
{
    public class SignUpValidation:AbstractValidator<SignUpDto>
    {
        public SignUpValidation()
        {

            RuleFor(x => x.UserName).NotEmpty().WithMessage("İstifadəçi Adı boş keçiləməz ");
            RuleFor(x => x.UserName).MaximumLength(15).WithMessage("İstifadəçi Adı ən çox 15 hərfdən ibaret olsun ");
            RuleFor(x => x.UserName).MinimumLength(4).WithMessage("İstifadəçi Adı ən azı 4 hərfdən ibaret olsun ");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Adı boş keçiləməz");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Adı Ən azı 2 hərfdən ibarət olsun");
            RuleFor(x => x.Name).MaximumLength(17).WithMessage("Adı Ən çox 17 hərfdən ibarət olsun");

            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyadı boş keçiləməz");
            RuleFor(x => x.SurName).MinimumLength(5).WithMessage("Soyad Ən azı 5 hərfdən ibarət olsun");
            RuleFor(x => x.SurName).MaximumLength(25).WithMessage("Soyad Ən çox 25 hərfdən ibarət olsun");


        }
    }
}
