using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class UpdatePageRequest : IRequest<UpdatePageRequestResponse>
    {
        public UpdatePageRequest() { throw new NotImplementedException(); }
    }

    public record UpdatePageRoute
    {
        public UpdatePageRoute() { throw new NotImplementedException(); }
    }

    public record UpdatePageBody
    {
        public UpdatePageBody() { throw new NotImplementedException(); }
    }
}
