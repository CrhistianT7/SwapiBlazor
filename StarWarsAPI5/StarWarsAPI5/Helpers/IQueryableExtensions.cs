using StarWarsAPI5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Helpers
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, PaginationRepository pagination)
        {
            return queryable
                .Skip((pagination.CurrentPage - 1) * pagination.QuantityPerPage)
                .Take(pagination.QuantityPerPage);
        }
    }
}
