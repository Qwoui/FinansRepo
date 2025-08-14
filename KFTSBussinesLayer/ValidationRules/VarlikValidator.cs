using FluentValidation;
using KFTSEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.ValidationRules
{
    public class VarlikValidator : AbstractValidator<Varlik>
    {
        public VarlikValidator() 
        {
            RuleFor(x => x.VarlikAdi).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz!");
            RuleFor(x => x.VarlikFiyat).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz!");
            RuleFor(x => x.VarlikAciklama).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz!");
            RuleFor(x => x.TurId).GreaterThan(0).WithMessage("Bu Alan Boş Bırakılamaz!");

        }
    }
}
