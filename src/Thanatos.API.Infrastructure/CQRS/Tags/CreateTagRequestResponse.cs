using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public record CreateTagRequestResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
