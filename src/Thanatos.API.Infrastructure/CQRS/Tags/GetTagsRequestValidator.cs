using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class GetTagsRequestValidator : AbstractValidator<GetTagsRequest>
    {
        public GetTagsRequestValidator()
        {

        }
    }
}
