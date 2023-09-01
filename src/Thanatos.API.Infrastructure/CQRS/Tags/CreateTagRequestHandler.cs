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
    public class CreateTagRequestHandler : IRequestHandler<CreateTagRequest, CreateTagRequestResponse>
    {
        private readonly ThanatosDbContext _context;
        private readonly IMapper _mapper;

        public CreateTagRequestHandler(ThanatosDbContext thanatosDbContext, IMapper mapper)
        {
            _context = thanatosDbContext;
            _mapper = mapper;
        }

        public async Task<CreateTagRequestResponse> Handle(CreateTagRequest request, CancellationToken cancellationToken)
        {
            var tag = _mapper.Map<CreateTagRequest, Tag>(request);
            tag.Id = Guid.NewGuid();

            await _context.Tags.AddAsync(tag, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<CreateTagRequestResponse>(tag);
        }
    }
}
