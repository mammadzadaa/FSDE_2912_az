using Contact_App.Model;
using Contact_App.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App.Validation
{
    class AddContactValidator :AbstractValidator<AddCOntactsVM>
    {
        public AddContactValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty()
                .MinimumLength(3);
            RuleFor(x => x.Phone)
                .NotEmpty()
                .Matches(@"^[1-9]\d{9}");
            RuleFor(x => x.Email)
               .EmailAddress();
               
        }
    }
}
