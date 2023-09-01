using AutoMapper;
using MediatR;
using Thanatos.API.Infrastructure.Data;
using Thanatos.API.Infrastructure.Exceptions;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class UpdateTagRequestHandler : IRequestHandler<UpdateTagRequest, UpdateTagRequestResponse>
    {
        private readonly ThanatosDbContext _context;
        private readonly IMapper _mapper;

        public UpdateTagRequestHandler(ThanatosDbContext thanatosDbContext, IMapper mapper)
        {
            _context = thanatosDbContext;
            _mapper = mapper;
        }

        public async Task<UpdateTagRequestResponse> Handle(UpdateTagRequest request, CancellationToken cancellationToken)
        {
            var tag = await _context.Tags.FindAsync(request.Route.Id, cancellationToken);

            if (tag == null) throw new NotFoundException();

            _mapper.Map(request.Body, tag);

            _context.Tags.Update(tag);
            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<UpdateTagRequestResponse>(tag);
        }
    }
}
