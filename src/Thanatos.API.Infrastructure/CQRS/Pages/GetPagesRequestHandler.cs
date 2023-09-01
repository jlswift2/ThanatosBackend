using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class GetPagesRequestHandler : IRequestHandler<GetPagesRequest, List<GetPagesRequestResponse>>
    {
        public GetPagesRequestHandler() { throw new NotImplementedException(); }

        public Task<List<GetPagesRequestResponse>> Handle(GetPagesRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
