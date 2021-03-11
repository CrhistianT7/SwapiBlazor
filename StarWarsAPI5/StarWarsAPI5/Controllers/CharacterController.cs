using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarWarsAPI5.Helpers;
using StarWarsAPI5.Models;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Controllers
{
    /*[ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CharacterController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Character>>> Get([FromQuery]PaginationRepository pagination)
        {
            var queryable = _appDbContext.People.AsQueryable();
            await HttpContext.InsertPaginationParameterInResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
        }
    }*/
}
