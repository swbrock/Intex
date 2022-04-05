using System;
using System.Linq;

namespace Intex.Models
{
    public class EFAccidentsRepository : IAccidentsRepository
    {
        private AccidentsDbContext context { get; set; }

        public EFAccidentsRepository (AccidentsDbContext temp)
        {
            context = temp;
        }

        public IQueryable<Accident> Accidents => context.Accidents;
    }
}
