using BasicShopAPI.Application.CQRS.Commands.Products;
using BasicShopAPI.Domain.Entities;
using BasicShopAPI.Domain.Interfaces;

namespace BasicShopAPI.Application.CQRS.Handlers.Products
{
    public class CreateProductHandler
    {
        private readonly IProductRepository _repo;

        public CreateProductHandler(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<Guid> Handle(CreateProductCommand cmd)
        {
            var product = new Product(cmd.Name, cmd.Description, cmd.Price, cmd.Stock);
            await _repo.Add(product);
            return product.Id;
        }
    }
}
