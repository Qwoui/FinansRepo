using FluentValidation;
using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.ValidationRules
{
    public class GiderValidator : AbstractValidator<Gider>
    {
        public GiderValidator() {
            RuleFor(x => x.GiderMiktar).GreaterThanOrEqualTo("0").WithMessage("Gider Miktarı 0'dan Küçük Olamaz!");
            RuleFor(x => x.TurId).GreaterThan(0).WithMessage("Lütfen bir tür seçiniz");
        }
    }
}
