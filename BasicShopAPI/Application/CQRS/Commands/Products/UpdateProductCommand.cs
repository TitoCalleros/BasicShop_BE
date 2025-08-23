namespace BasicShopAPI.Application.CQRS.Commands.Products
{
    public record UpdateProductCommand(Guid Id, string Name, string? Description, decimal Price, int Stock, string Gender);
}
