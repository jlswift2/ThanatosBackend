using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class DeleteTagRequestHandler : IRequestHandler<DeleteTagRequest>
    {
        ThanatosDbContext _dbContext;

        public DeleteTagRequestHandler(ThanatosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Handle(DeleteTagRequest request, CancellationToken cancellationToken)
        {
            _dbContext.Tags.Remove(new Tag { Id = request.Route.Id });
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
