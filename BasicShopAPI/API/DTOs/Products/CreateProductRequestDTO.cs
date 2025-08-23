using System.ComponentModel.DataAnnotations;

namespace BasicShopAPI.API.DTOs.Products
{
    public record CreateProductRequestDTO
    {
        [Required, StringLength(50)]
        public required string Name { get; set; }

        [StringLength(150)]
        public string? Description { get; set; }
        [Required, Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(1, int.MaxValue)]
        public int Stock { get; set; }

        [Required, AllowedValues("men", "women", "kids")]
        public required string Gender { get; set; } 
    }
    
}
