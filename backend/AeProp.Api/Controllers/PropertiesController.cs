using AeProp.Api.Domain.Entities;
using AeProp.Api.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AeProp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropertiesController: ControllerBase
    {
        private readonly AePropDbContext _context;

        public PropertiesController(AePropDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Property>>> GetProperties()
        {
            // ToListAsync to avoid excecution thread blockage
            return await _context.Properties.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Property>> CreateProperty(Property property)
        {
            _context.Properties.Add(property);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProperties), new { id = property.Id }, property);
        }
    }
}
