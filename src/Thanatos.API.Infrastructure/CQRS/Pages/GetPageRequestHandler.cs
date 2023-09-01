using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class GetPageRequestHandler : IRequestHandler<GetPageRequest, GetPageRequestResponse>
    {
        public GetPageRequestHandler() { throw new NotImplementedException(); }
        public Task<GetPageRequestResponse> Handle(GetPageRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
