namespace BasicShopAPI.API.DTOs.Products
{
    public record ProductResponseDTO(
        int Id,
        string Name,
        string? Description,
        decimal Price,
        int Stock
    );
}
