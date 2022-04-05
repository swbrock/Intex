using System;
using System.Linq;

namespace Intex.Models
{
    public interface IAccidentsRepository
    {
        IQueryable<Accident> Accidents { get; }
    }
}
