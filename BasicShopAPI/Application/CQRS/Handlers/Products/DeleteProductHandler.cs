using BasicShopAPI.Application.CQRS.Commands.Products;
using BasicShopAPI.Domain.Interfaces;

namespace BasicShopAPI.Application.CQRS.Handlers.Products
{
    public class DeleteProductHandler(IProductRepository repo)
    {
        private readonly IProductRepository _repo = repo;

        public async Task Handle(DeleteProductCommand cmd)
        {
            await _repo.Delete(cmd.id);
        }
    }
}
