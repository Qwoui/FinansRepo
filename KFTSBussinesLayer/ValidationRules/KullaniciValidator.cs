using FluentValidation;
using KFTSEntityLayer.Concrete;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFTSBussinesLayer.ValidationRules
{
    public class KullaniciValidator : AbstractValidator<Kullanıcı>
    {
        public KullaniciValidator()
        {
            RuleFor(x => x.KullaniciAdiSoyadi).NotEmpty().WithMessage("Kullanıcı Adı Soyadı Boş Geçilemez");
            RuleFor(x => x.KullaniciEmail).NotEmpty().WithMessage("Kullanıcı Email Boş Geçilemez");
            RuleFor(x => x.KullaniciEmail).EmailAddress().WithMessage("Lütfen Geçerli Bir Email Girin");
            RuleFor(x => x.KullaniciSifre).NotEmpty().WithMessage("Kullanıcı Şifre Boş Geçilemez");
            RuleFor(x => x.KullaniciAdiSoyadi).MinimumLength(4).WithMessage("Kullanıcı Adı Soyadı 4 Karakterden Az Olamaz");
            RuleFor(x => x.KullaniciAdiSoyadi).MaximumLength(50).WithMessage("Kullanıcı Adı Soyadı 50 Karakterden Fazla Olamaz");
            RuleFor(x => x.KullaniciSifre).Equal(x => x.KullaniciSifreTekrar).WithMessage("Şifreler Eşleşmiyor");
          
        }
    }
}
