using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class CreatePageRequest : IRequest<CreatePageRequestResponse>
    {
        public CreatePageRequest() { throw new NotImplementedException(); }

    }

    public record CreatePageBody
    {
        public CreatePageBody() { throw new NotImplementedException(); }
    }
}
