using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class DeletePageRequestHandler : IRequestHandler<DeletePageRequest>
    {
        public DeletePageRequestHandler() { throw new NotImplementedException(); }

        public Task Handle(DeletePageRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
