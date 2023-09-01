using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class GetPageRequest : IRequest<GetPageRequestResponse>
    {
        public GetPageRequest() { throw new NotImplementedException(); }
    }

    public record GetPageRoute
    {
        public GetPageRoute() { throw new NotImplementedException(); }
    }
}
