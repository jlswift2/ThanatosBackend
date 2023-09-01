using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class GetTagsRequestHandler : IRequestHandler<GetTagsRequest, List<GetTagsRequestResponse>>
    {
        private readonly ThanatosDbContext _context;
        private readonly IMapper _mapper;

        public GetTagsRequestHandler(ThanatosDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<GetTagsRequestResponse>> Handle(GetTagsRequest request, CancellationToken cancellationToken)
        {
            var tagsQueryable = _context.Tags.AsQueryable();
            if (request.Query.Name != null) tagsQueryable = tagsQueryable.Where(t => t.Name.Contains(request.Query.Name));
            var tags = await tagsQueryable.ToListAsync(cancellationToken: cancellationToken);

            return _mapper.Map<List<GetTagsRequestResponse>>(tags);
        }
    }
}
