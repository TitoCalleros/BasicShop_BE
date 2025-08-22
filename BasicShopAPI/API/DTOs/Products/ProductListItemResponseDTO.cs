namespace BasicShopAPI.API.DTOs.Products
{
    public record ProductListItemResponseDTO(
        Guid Id,
        string Name,
        decimal Price,
        int Stock
    );
}
