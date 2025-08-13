using FluentValidation;
using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.ValidationRules
{
    public class GelirValidator : AbstractValidator<Gelir>
    {
        public GelirValidator() {
            RuleFor(x => x.GelirMiktar).GreaterThanOrEqualTo("0").WithMessage("Gelir Miktarı 0'dan Küçük Olamaz!");
        }
    }
}
