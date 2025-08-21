using BasicShopAPI.Application.CQRS.Commands.Products;
using BasicShopAPI.Domain.Interfaces;

namespace BasicShopAPI.Application.CQRS.Handlers.Products
{
    public class UpdateProductHandler
    {
        private readonly IProductRepository _repo;

        public UpdateProductHandler(IProductRepository repo)
        {
            this._repo = repo;
        }

        public async Task Handle(UpdateProductCommand cmd)
        {
            var productoDb = await _repo.GetById(cmd.id) ?? throw new KeyNotFoundException("Product id not found");

            productoDb.Update(cmd.Name, cmd.Description, cmd.Price, cmd.Stock);
            await _repo.Update(productoDb);
        }
    }
}
