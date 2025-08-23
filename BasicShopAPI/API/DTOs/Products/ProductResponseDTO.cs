namespace BasicShopAPI.API.DTOs.Products
{
    public record ProductResponseDTO(
        Guid Id,
        string Name,
        string? Description,
        decimal Price,
        int Stock,
        string Gender
    );
}
