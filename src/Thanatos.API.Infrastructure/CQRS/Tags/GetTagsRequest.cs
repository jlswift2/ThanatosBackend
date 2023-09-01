using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class GetTagsRequest : IRequest<List<GetTagsRequestResponse>>
    {
        public GetTagsRequest(GetTagsQuery query)
        {
            Query = query;
        }

        public GetTagsQuery Query { get; init; }
    }

    public record GetTagsQuery
    {
          public string? Name { get; init; }
    }
}
