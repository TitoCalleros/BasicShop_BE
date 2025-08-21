namespace BasicShopAPI.Application.CQRS.Commands.Products
{
    public record CreateProductCommand(string Name, string? Description, decimal Price, int Stock);
}
