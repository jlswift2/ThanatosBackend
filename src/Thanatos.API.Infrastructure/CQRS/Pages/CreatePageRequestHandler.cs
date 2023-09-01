using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class CreatePageRequestHandler : IRequestHandler<CreatePageRequest, CreatePageRequestResponse>
    {
        public CreatePageRequestHandler() { throw new NotImplementedException(); }

        public Task<CreatePageRequestResponse> Handle(CreatePageRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
