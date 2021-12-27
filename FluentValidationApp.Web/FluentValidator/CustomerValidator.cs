using FluentValidation;
using FluentValidationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.FluentValidator
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz!";
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMessage);

            RuleFor(x => x.Mail).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress().WithMessage("Mail alanı doğru formatta olmalıdır!");

            RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage).InclusiveBetween(18, 60).WithMessage("Age alanı 18-60 aralığında olmalıdır!");

            //Custom validator kullanmak istiyorsam , yani fluentvalidation kütüphanesinin sunduğu validasyonların haricinde kendim bir validasyon kullanmak istiyorsam MUST METODU nu kullanmalıyım!!! 
            RuleFor(x => x.Birthday).NotEmpty().WithMessage(NotEmptyMessage).Must(x =>
              {
                  return DateTime.Now.AddYears(-18) >= x;

              }).WithMessage("Yaşınız 18'den büyük olmalıdır");


            RuleFor(x => x.Gender).IsInEnum().WithMessage("{PropertyName} alanı erkek için 1 bayan için 2 olmalıdır!");


            RuleForEach(x => x.Addresses).SetValidator(new AddressValidator());




        }
    }
}
