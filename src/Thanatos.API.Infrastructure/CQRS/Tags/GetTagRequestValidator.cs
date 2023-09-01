using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class GetTagRequestValidator : AbstractValidator<GetTagRequest>
    {
        public GetTagRequestValidator()
        {
            RuleFor(x => x.Route.Id).NotEmpty().WithMessage("Route Id value must not be empty");
        }
    }
}
