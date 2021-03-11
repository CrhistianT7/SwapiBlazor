using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Models
{
    public class PaginationRepository
    {
        public int CurrentPage { get; set; } = 1;
        public int QuantityPerPage { get; set; } = 3;
    }
}
