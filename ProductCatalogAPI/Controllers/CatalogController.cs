using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Data;

namespace ProductCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly CatalogContext _context;
        public CatalogController(CatalogContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> CatalogTypes()
        {
            var types = await _context.CatalogTypes.ToListAsync();
            return Ok(types);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> CatalogBrands()
        {
            var brands = await _context.CatalogBrands.ToListAsync();
            return Ok(brands);
        }

    }
}
