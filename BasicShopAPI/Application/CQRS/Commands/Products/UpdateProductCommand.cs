namespace BasicShopAPI.Application.CQRS.Commands.Products
{
    public record UpdateProductCommand(Guid id, string Name, string? Description, decimal Price, int Stock);
}
