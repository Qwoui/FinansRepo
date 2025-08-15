using FluentValidation;
using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.ValidationRules
{
    public class VarlikSilValidator : AbstractValidator<Varlik>
    {
        public VarlikSilValidator()
        {
            RuleFor(x => x.VarlikId).GreaterThan(0).WithMessage("Lütfen Bir Varlık Seçiniz");
        }
    }
}
