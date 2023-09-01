using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class GetTagRequestHandler : IRequestHandler<GetTagRequest, GetTagRequestResponse>
    {
        private readonly ThanatosDbContext _context;
        private readonly IMapper _mapper;

        public GetTagRequestHandler(ThanatosDbContext thanatosDbContext, IMapper mapper)
        {
            _context = thanatosDbContext;
            _mapper = mapper;
        }

        public async Task<GetTagRequestResponse> Handle(GetTagRequest request, CancellationToken cancellationToken)
        {
            var tag = await _context.Tags.FindAsync(request.Route.Id, cancellationToken);

            return _mapper.Map<GetTagRequestResponse>(tag);
        }
    }
}
