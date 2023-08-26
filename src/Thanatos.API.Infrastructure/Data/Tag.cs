using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.Data
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Page> Pages { get; set; }
    }
}
