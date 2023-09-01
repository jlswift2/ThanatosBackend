using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class UpdateTagRequestValidator : AbstractValidator<UpdateTagRequest>
    {
        public UpdateTagRequestValidator()
        {
            RuleFor(x => x.Route.Id).NotEmpty().WithMessage("Route Id value must not be empty");
            RuleFor(x => x.Body.Name).NotEmpty().WithMessage("Name in the body must not be empty");
        }
    }
}
