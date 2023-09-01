using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class UpdatePageRequestHandler : IRequestHandler<UpdatePageRequest, UpdatePageRequestResponse>
    {
        public UpdatePageRequestHandler() { throw new NotImplementedException(); }

        public Task<UpdatePageRequestResponse> Handle(UpdatePageRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
