using System;
using Microsoft.EntityFrameworkCore;

namespace Intex.Models
{
    public class AccidentsDbContext : DbContext
    {
        public AccidentsDbContext(DbContextOptions<AccidentsDbContext> options) : base (options)
        {
        }

        public DbSet<Accident> Accidents { get; set; }
    }
}
