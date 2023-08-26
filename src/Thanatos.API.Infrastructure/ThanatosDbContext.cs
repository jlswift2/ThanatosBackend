using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure
{
    public class ThanatosDbContext : DbContext
    {
        public ThanatosDbContext(DbContextOptions<ThanatosDbContext> options) : base(options)
        {
        }

        public DbSet<Data.Page> Pages { get; set; }
        public DbSet<Data.Section> Sections { get; set; }
        public DbSet<Data.Tag> Tags { get; set; }
    }
}
