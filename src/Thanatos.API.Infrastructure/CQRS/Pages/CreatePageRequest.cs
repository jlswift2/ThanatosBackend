using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class CreatePageRequest : IRequest<CreatePageRequestResponse>
    {
        public CreatePageRequest(CreatePageBody body)
        {
            Body = body;
        }

        public CreatePageBody Body { get; set; }
    }

    public record CreatePageBody
    {
        public string Title { get; set; }
        public Category Category { get; set; }
    }
}
