namespace AeProp.Api.Dtos
{
    public class PropertyCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public string Category { get; set; } = "Apartment";
    }
}
