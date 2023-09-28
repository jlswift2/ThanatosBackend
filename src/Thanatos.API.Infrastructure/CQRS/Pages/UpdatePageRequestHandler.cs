using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanatos.API.Infrastructure.Exceptions;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class UpdatePageRequestHandler : IRequestHandler<UpdatePageRequest, UpdatePageRequestResponse>
    {
        private readonly ThanatosDbContext _dbContext;
        private readonly IMapper _mapper;

        public UpdatePageRequestHandler(IMapper mapper, ThanatosDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<UpdatePageRequestResponse> Handle(UpdatePageRequest request, CancellationToken cancellationToken)
        {
            var page = _dbContext.Pages.FirstOrDefault(x => x.Id == request.Route.Id);

            if (page == null)
            {
                throw new NotFoundException();
            }

            _mapper.Map(request.Body, page);

            _dbContext.Pages.Update(page);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<UpdatePageRequestResponse>(page);
        }
    }
}
