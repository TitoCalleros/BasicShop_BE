namespace BasicShopAPI.API.DTOs.Products
{
    public record ProductListItemResponseDTO(
        Guid Id,
        string Name,
        string? Description,
        decimal Price,
        int Stock
    );
}
