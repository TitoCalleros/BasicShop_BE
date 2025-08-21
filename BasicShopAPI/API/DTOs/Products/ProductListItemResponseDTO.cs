namespace BasicShopAPI.API.DTOs.Products
{
    public record ProductListItemResponseDTO(
        int Id,
        string Name,
        decimal Price,
        int Stock
    );
}
