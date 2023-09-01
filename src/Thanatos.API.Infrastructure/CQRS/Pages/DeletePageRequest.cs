using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class DeletePageRequest : IRequest
    {
        public DeletePageRequest() { throw new NotImplementedException(); }
    }

    public record DeletePageRoute
    {
        public DeletePageRoute() { throw new NotImplementedException(); }
    }
}
