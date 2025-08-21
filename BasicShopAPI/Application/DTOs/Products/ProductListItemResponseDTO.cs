namespace BasicShopAPI.Application.DTOs.Products
{
    public record ProductListItemResponseDTO(
        int Id,
        string Name,
        decimal Price,
        int Stock
    );
}
