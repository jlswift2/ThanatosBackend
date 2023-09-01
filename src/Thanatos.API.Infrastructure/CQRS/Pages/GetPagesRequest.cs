using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class GetPagesRequest : IRequest<List<GetPagesRequestResponse>>
    {
        public GetPagesRequest(GetPagesQuery query)
        {
            Query = query;
        }

        public GetPagesQuery Query { get; }
    }

    public record GetPagesQuery
    {
        public string? Title { get; set; }
        public Category? Category { get; set; }
    }
}
