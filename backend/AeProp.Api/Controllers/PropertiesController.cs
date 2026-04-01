using AeProp.Api.Domain.Entities;
using AeProp.Api.Dtos;
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
        public async Task<ActionResult<Property>> CreateProperty(PropertyCreateDto propertyDto)
        {
            // TODO: use AutoMapper
            Property property = new Property
            {
                Name = propertyDto.Name,
                Price = propertyDto.Price,
                Address = propertyDto.Address,
                Bedrooms = propertyDto.Bedrooms,
                Bathrooms = propertyDto.Bathrooms,
                Category = propertyDto.Category,
                CreatedAt = DateTime.UtcNow

            };

            _context.Properties.Add(property);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProperties), new { id = property.Id }, property);
        }
    }
}
