using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AeProp.Api.Domain.Entities
{
    public class Property
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(250)]
        public string Address {  get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }

        [MaxLength(500)]
        public string ImageUrl { get; set; } = "https://via.placeholder.com/300";

        public DateTime CreatedAt { get; set; }

        [Required]
        // TODO: convert to enum
        public string Category { get; set; } = "Apartment";
    }
}
