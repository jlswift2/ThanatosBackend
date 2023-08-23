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
    }
}
