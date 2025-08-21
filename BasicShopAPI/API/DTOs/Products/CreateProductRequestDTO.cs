using System.ComponentModel.DataAnnotations;

namespace BasicShopAPI.API.DTOs.Products
{
    public record CreateProductRequestDTO(
        [property: Required, StringLength(50)] string Name,
        [property: StringLength(150)] string? Description,
        [property: Required, Range(0.01, double.MaxValue)] decimal Price,
        [property: Range(1, int.MaxValue)] int Stock
    );
    
}
