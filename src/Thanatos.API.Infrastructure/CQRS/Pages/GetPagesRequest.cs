using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class GetPagesRequest : IRequest<List<GetPagesRequestResponse>>
    {
        public GetPagesRequest() { throw new NotImplementedException(); }
    }

    public record GetPagesQuery
    {
        public GetPagesQuery() { throw new NotImplementedException(); }
    }
}
