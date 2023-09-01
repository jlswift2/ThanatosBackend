using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public record GetTagRequestResponse
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
    }
}
