using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.Data
{
    public class Page
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Section> Sections { get; set; }
    }
}
